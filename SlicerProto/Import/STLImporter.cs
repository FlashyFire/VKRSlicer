using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlicerProto.ObjectModel;

namespace SlicerProto.Import
{
    internal class STLImporter : IImporter
    {
        private const int HeaderLength = 84;
        private const int FacetLength = 50;

        public STLImporter(Model model)
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
            if (IsBinaryFormat(stream))
                ReadBinary(stream);
            else
                ReadASCII(stream);
        }

        // https://stackoverflow.com/questions/26171521/verifying-that-an-stl-file-is-ascii-or-binary
        bool IsBinaryFormat(Stream stream)
        {
            if (stream.Length < HeaderLength)
                return false;
            using (BinaryReader reader = new BinaryReader(stream, Encoding.ASCII, true))
            {
                string sign = new string(reader.ReadChars(80));
                UInt32 count = reader.ReadUInt32();
                stream.Seek(0, SeekOrigin.Begin);
                if (stream.Length == count * FacetLength + HeaderLength)
                    return true;
                return !sign.StartsWith("solid ");
            }
        }

        // https://ru.wikipedia.org/wiki/STL_(формат_файла)#ASCII_STL
        void ReadASCII(Stream stream)
        {
            using (StreamReader reader = new StreamReader(stream, Encoding.ASCII, false, 4096, true))
            {
                string line = reader.ReadLine()?.Trim();
                ParseASCIIHeader(line);
                Facet facet = null;
                int vertexIndex = 0;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine()?.Trim();
                    if (string.IsNullOrEmpty(line))
                        continue;
                    if (line.StartsWith("endsolid"))
                        return;
                    if (line.StartsWith("facet"))
                    {
                        facet = new Facet();
                        vertexIndex = 0;
                        ParseFacet(line, facet);
                    }
                    else if (line.StartsWith("endfacet"))
                    {
                        if (facet == null || vertexIndex < 2)
                            throw new InvalidDataException("endfacet");
                        Model.Facets.Add(facet);
                        facet = null;
                    }
                    else if (line.StartsWith("vertex"))
                    {
                        if (facet == null || vertexIndex > 2)
                            throw new InvalidDataException("vertex order");
                        ParseVertex(line, facet, vertexIndex);
                        vertexIndex++;
                    }
                }
            }
        }

        void ParseASCIIHeader(string line)
        {
            if (!string.IsNullOrEmpty(line) && line.StartsWith("solid "))
                Model.Name = line.Substring(6);
        }

        void ParseFacet(string line, Facet facet)
        {
            string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 5)
                throw new InvalidDataException("facet");
            facet.Normal.X = Convert.ToSingle(parts[2], CultureInfo.InvariantCulture);
            facet.Normal.Y = Convert.ToSingle(parts[3], CultureInfo.InvariantCulture);
            facet.Normal.Z = Convert.ToSingle(parts[4], CultureInfo.InvariantCulture);
        }

        void ParseVertex(string line, Facet facet, int vertexIndex)
        {
            string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 4)
                throw new InvalidDataException("vertex");
            if (vertexIndex == 0)
            {
                facet.Vx1.X = Convert.ToSingle(parts[1], CultureInfo.InvariantCulture);
                facet.Vx1.Y = Convert.ToSingle(parts[2], CultureInfo.InvariantCulture);
                facet.Vx1.Z = Convert.ToSingle(parts[3], CultureInfo.InvariantCulture);
            }
            else if (vertexIndex == 1)
            {
                facet.Vx2.X = Convert.ToSingle(parts[1], CultureInfo.InvariantCulture);
                facet.Vx2.Y = Convert.ToSingle(parts[2], CultureInfo.InvariantCulture);
                facet.Vx2.Z = Convert.ToSingle(parts[3], CultureInfo.InvariantCulture);
            }
            else
            {
                facet.Vx3.X = Convert.ToSingle(parts[1], CultureInfo.InvariantCulture);
                facet.Vx3.Y = Convert.ToSingle(parts[2], CultureInfo.InvariantCulture);
                facet.Vx3.Z = Convert.ToSingle(parts[3], CultureInfo.InvariantCulture);
            }
        }

        // https://ru.wikipedia.org/wiki/STL_(формат_файла)#Двоичный_формат
        void ReadBinary(Stream stream)
        {
            using (BinaryReader reader = new BinaryReader(stream, Encoding.Default, true))
            {
                reader.ReadBytes(80); // skip header
                UInt32 count = reader.ReadUInt32();
                for (UInt32 i = 0; i < count; i++)
                {
                    Facet facet = new Facet();
                    facet.Normal.X = reader.ReadSingle();
                    facet.Normal.Y = reader.ReadSingle();
                    facet.Normal.Z = reader.ReadSingle();
                    facet.Vx1.X = reader.ReadSingle();
                    facet.Vx1.Y = reader.ReadSingle();
                    facet.Vx1.Z = reader.ReadSingle();
                    facet.Vx2.X = reader.ReadSingle();
                    facet.Vx2.Y = reader.ReadSingle();
                    facet.Vx2.Z = reader.ReadSingle();
                    facet.Vx3.X = reader.ReadSingle();
                    facet.Vx3.Y = reader.ReadSingle();
                    facet.Vx3.Z = reader.ReadSingle();
                    reader.ReadUInt16(); // skip attributes
                    Model.Facets.Add(facet);
                }
            }
        }
    }
}
