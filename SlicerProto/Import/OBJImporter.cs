using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using SlicerProto.ObjectModel;
using SlicerProto.Utils;

namespace SlicerProto.Import
{
    internal class OBJImporter : IImporter
    {
        readonly char[] spaceSeparator = new char[] { ' ' };
        readonly char[] slashSeparator = new char[] { '/' };
        List<Vector3> vertices = new List<Vector3>();
        List<Vector3> normals = new List<Vector3>();

        public OBJImporter(Model model)
        {
            Model = model ?? throw new ArgumentNullException("model");
        }

        public Model Model { get; }

        public void Import(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                Import(fs);
            }
        }

        public void Import(Stream stream)
        {
            Model.Clear();
            vertices.Clear();
            normals.Clear();
            using (StreamReader reader = new StreamReader(stream, Encoding.ASCII, false, 4096, true))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine()?.Trim();
                    if (string.IsNullOrEmpty(line))
                        continue;
                    if (line.StartsWith("v "))
                        ParseVertex(line);
                    else if (line.StartsWith("vn "))
                        ParseNormal(line);
                    else if (line.StartsWith("f "))
                        ParseFace(line);
                }
            }
        }

        private void ParseVertex(string line)
        {
            string[] parts = line.Split(spaceSeparator, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 4)
                throw new InvalidDataException("vertex");
            if (parts.Length >= 5)
            {
                Vector4 item = new Vector4
                {
                    X = Convert.ToSingle(parts[1], CultureInfo.InvariantCulture),
                    Y = Convert.ToSingle(parts[2], CultureInfo.InvariantCulture),
                    Z = Convert.ToSingle(parts[3], CultureInfo.InvariantCulture),
                    W = Convert.ToSingle(parts[4], CultureInfo.InvariantCulture)
                };
                vertices.Add(new Vector3(item));
            }
            else
            {
                Vector3 item = new Vector3
                {
                    X = Convert.ToSingle(parts[1], CultureInfo.InvariantCulture),
                    Y = Convert.ToSingle(parts[2], CultureInfo.InvariantCulture),
                    Z = Convert.ToSingle(parts[3], CultureInfo.InvariantCulture)
                };
                vertices.Add(item);
            }
        }

        private void ParseNormal(string line)
        {
            string[] parts = line.Split(spaceSeparator, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 4)
                throw new InvalidDataException("normals");
            Vector3 item = new Vector3
            {
                X = Convert.ToSingle(parts[1], CultureInfo.InvariantCulture),
                Y = Convert.ToSingle(parts[2], CultureInfo.InvariantCulture),
                Z = Convert.ToSingle(parts[3], CultureInfo.InvariantCulture)
            };
            normals.Add(item);
        }

        private void ParseFace(string line)
        {
            string[] parts = line.Split(spaceSeparator, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 4)
                throw new InvalidDataException("face");
            List<Vector3> points = new List<Vector3>(parts.Length - 1);
            Vector3 normal = Vector3.Zero;
            for (int i = 1; i < parts.Length; i++)
            {
                Tuple<int, int, int> indexes = ParseIndexes(parts[i]);
                if (indexes.Item3 != 0 && normal == Vector3.Zero)
                {
                    normal = GetItem(normals, indexes.Item3);
                }
                points.Add(GetItem(vertices, indexes.Item1));
            }
            if (normal == Vector3.Zero)
                normal = CalculateNormal(points);
            Triangulate(normal, points);
        }

        private Tuple<int, int, int> ParseIndexes(string item)
        {
            string[] parts = item.Split(slashSeparator, StringSplitOptions.None);
            int vertexIndex = 0;
            int textureIndex = 0;
            int normalIndex = 0;
            if (parts.Length > 0)
                vertexIndex = Convert.ToInt32(parts[0]);
            if (parts.Length > 1 && !string.IsNullOrEmpty(parts[1]))
                textureIndex = Convert.ToInt32(parts[1]);
            if (parts.Length > 2 && !string.IsNullOrEmpty(parts[2]))
                normalIndex = Convert.ToInt32(parts[2]);
            return new Tuple<int, int, int>(vertexIndex, textureIndex, normalIndex);
        }

        Vector3 GetItem(List<Vector3> collection, int index)
        {
            if (index == 0)
                throw new InvalidDataException("Zero vertex or normal index");
            if (index < 0)
                index += collection.Count;
            else
                index--;
            return collection[index];
        }

        Vector3 CalculateNormal(List<Vector3> points)
        {
            Vector3 first = points[1] - points[0];
            Vector3 second = points[2] - points[0];
            return Vector3.Cross(first, second).Normalized();
        }

        void Triangulate(Vector3 normal, List<Vector3> points)
        {
            if (points.Count == 3)
            {
                Facet facet = new Facet
                {
                    Normal = normal,
                    Vx1 = points[0],
                    Vx2 = points[1],
                    Vx3 = points[2]
                };
                Model.Facets.Add(facet);
            }
            else
            {
                Vector3 up = Vector3.Subtract(points[0], points[1]).Normalized();
                Matrix4 mt = Matrix4.LookAt(normal, Vector3.Zero, up);
                var projected = points.Select(x => Vector3.TransformPosition(x, mt));
                List<float> data = projected.SelectMany(pt => new float[] { pt.X, pt.Y }).ToList();
                IList<int> triangles = Tessellator.Tessellate(data);
                for (int i = 0; i < triangles.Count; i += 3)
                {
                    Facet facet = new Facet
                    {
                        Normal = normal,
                        Vx1 = points[triangles[i]],
                        Vx2 = points[triangles[i + 1]],
                        Vx3 = points[triangles[i + 2]]
                    };
                    Model.Facets.Add(facet);
                }
            }
        }
    }
}
