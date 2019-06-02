using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using SlicerProto.Utils;

namespace SlicerProto.SliceModel
{
    public class SlicePart
    {
        public List<Vector3> Points { get; } = new List<Vector3>();
        public List<Vector3> Normals { get; } = new List<Vector3>();
        public bool Closed { get; set; }
        public bool IsValid => Points.Count >= MinPointsCount;

        Vector3 FirstPoint { get { return Points[0]; } }
        Vector3 LastPoint {  get { return Points[Points.Count - 1]; } }
        int MinPointsCount => Closed ? 3 : 2;

        private void Append(Vector3 point, Vector3 normal)
        {
            Points.Add(point);
            Normals.Add(normal);
        }

        private void Insert(int index, Vector3 point, Vector3 normal)
        {
            Points.Insert(index, point);
            Normals.Insert(index, normal);
        }

        private void RemoveAt(int index)
        {
            Points.RemoveAt(index);
            Normals.RemoveAt(index);
        }

        public bool AddSection(Vector3 first, Vector3 second, Vector3 normal = new Vector3())
        {
            if (Closed)
                return false;

            if (Points.Count == 0)
            {
                Append(first, normal);
                Append(second, normal);
                return true;
            }

            int lastIndex = Points.Count - 1;

            if (Points[0].Near(first))
            {
                if (Points[lastIndex] == second)
                    Closed = true;
                else
                    Insert(0, second, normal);
                return true;
            }

            if (Points[0].Near(second))
            {
                if (Points[lastIndex] == first)
                    Closed = true;
                else
                    Insert(0, first, normal);
                return true;
            }

            if (Points[lastIndex].Near(first))
            {
                Normals[lastIndex] = normal;
                Append(second, normal);
                return true;
            }

            if (Points[lastIndex].Near(second))
            {
                Normals[lastIndex] = normal;
                Append(first, normal);
                return true;
            }

            return false;
        }

        public bool Join(SlicePart other)
        {
            if (Closed)
                return false;

            if (LastPoint.Near(other.FirstPoint))
            {
                bool closing = FirstPoint.Near(other.LastPoint);
                int start = 1;
                int count = closing ? other.Points.Count - 1 : other.Points.Count;
                Normals[Normals.Count - 1] = other.Normals[0];
                for (int i = start; i < count; i++)
                {
                    Append(other.Points[i], other.Normals[i]);
                }
                Closed = closing;
                return true;
            }

            if (LastPoint.Near(other.LastPoint))
            {
                bool closing = FirstPoint.Near(other.FirstPoint);
                int end = closing ? 1 : 0;
                Normals[Normals.Count - 1] = other.Normals[other.Normals.Count - 1];
                for (int i = other.Points.Count - 2; i >= end; i--)
                {
                    Append(other.Points[i], other.Normals[i]);
                }
                Closed = closing;
                return true;
            }

            if (FirstPoint.Near(other.LastPoint))
            {
                bool closing = LastPoint.Near(other.FirstPoint);
                int end = closing ? 1 : 0;
                for (int i = other.Points.Count - 2; i >= end; i--)
                {
                    Insert(0, other.Points[i], other.Normals[i]);
                }
                Closed = closing;
                return true;
            }

            if (FirstPoint.Near(other.FirstPoint))
            {
                bool closing = LastPoint.Near(other.LastPoint);
                int start = 1;
                int count = closing ? other.Points.Count - 1 : other.Points.Count;
                for (int i = start; i < count; i++)
                {
                    Insert(0, other.Points[i], other.Normals[i]);
                }
                Closed = closing;
                return true;
            }
            return false;
        }

        public void Simplify(float delta)
        {
            if (Closed)
            {
                if (Points.Count < 4)
                    return;
                for (int i = Points.Count - 1; i >= 0; i--)
                {
                    int predIndex = (i + 1) % Points.Count;
                    int nextIndex = i == 0 ? Points.Count - 1 : i - 1;
                    float distance = Points[i].GetDistanceToLine(Points[predIndex], Points[nextIndex]);
                    if (float.IsNaN(distance) || float.IsInfinity(distance))
                        continue;
                    if (distance <= delta)
                        RemoveAt(i);
                }
            }
            else
            {
                if (Points.Count < 3)
                    return;
                for (int i = Points.Count - 2; i >= 1; i--)
                {
                    float distance = Points[i].GetDistanceToLine(Points[i + 1], Points[i - 1]);
                    if (float.IsNaN(distance) || float.IsInfinity(distance))
                        continue;
                    if (distance <= delta)
                        RemoveAt(i);
                }
            }
        }

        public void Flatten(float tolerance)
        {
            if (Closed)
            {
                if (Points.Count < 4)
                    return;
                for (int i = Points.Count - 1; i >= 1; i--)
                {
                    int predIndex = (i + 1) % Points.Count;
                    float distance = Vector3.Distance(Points[i], Points[i - 1]);
                    if (distance <= tolerance)
                        RemoveAt(i);
                    if (Points.Count < 4)
                        return;
                }
            }
            else
            {
                if (Points.Count < 3)
                    return;
                for (int i = Points.Count - 2; i >= 1; i--)
                {
                    float distance = Vector3.Distance(Points[i], Points[i - 1]);
                    if (distance <= tolerance)
                        RemoveAt(i);
                    if (Points.Count < 3)
                        return;
                }
            }
        }

        public SlicePart Transform(Matrix3 matrix)
        {
            SlicePart result = new SlicePart();
            foreach(Vector3 point in Points)
            {
                result.Points.Add(Vector3.Transform(point, matrix));
            }
            foreach (Vector3 normal in Normals)
            {
                result.Normals.Add(Vector3.Transform(normal, matrix).Normalized());
            }
            result.Closed = Closed;
            return result;
        }

        public ObjectDimensions GetDimensions()
        {
            if (Points.Count == 0)
                throw new InvalidOperationException("Get dimensions from empty slice part.");
            ObjectDimensions result = new ObjectDimensions();
            result.Initialize(Points[0]);
            for (int i = 1; i < Points.Count; i++)
            {
                result.Aggregate(Points[i]);
            }
            return result;
        }

        public SlicePart Clone()
        {
            SlicePart result = new SlicePart();
            result.Points.AddRange(Points);
            result.Normals.AddRange(Normals);
            result.Closed = Closed;
            return result;
        }

        public SlicePart GetZPlane(float z)
        {
            SlicePart result = new SlicePart();
            foreach (Vector3 point in Points)
            {
                result.Points.Add(new Vector3(point.X, point.Y, z));
            }
            result.Normals.AddRange(Normals);
            result.Closed = Closed;
            return result;
        }
    }
}
