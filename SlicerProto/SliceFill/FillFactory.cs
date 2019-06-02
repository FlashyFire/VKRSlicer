using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using SlicerProto.SliceModel;

namespace SlicerProto.SliceFill
{
    public abstract class FillFactory
    {
        public bool LayerByLayer { get; set; }

        public virtual Fill CreateFill(Slice slice, float angle, float step)
        {
            Matrix3 matrix = Matrix3.CreateRotationZ(angle);
            Slice rotatedSlice = slice.Transform(matrix);
            Fill fill = new Fill();
            GenerateFill(fill, rotatedSlice, step);
            matrix = Matrix3.CreateRotationZ(-angle);
            fill.Transform(matrix);
            return fill;
        }

        protected abstract void GenerateFill(Fill fill, Slice slice, float step);

        protected List<Vector3> GetIntersectionPoints(Slice slice, float x)
        {
            List<Vector3> result = new List<Vector3>();
            foreach (SlicePart part in slice.Parts)
                FindIntersectionPoints(result, part, x);
            return result;
        }

        private void FindIntersectionPoints(List<Vector3> points, SlicePart part, float x)
        {
            if (!part.IsValid)
                return;
            bool closed = part.Closed;
            int count = part.Points.Count;
            int endIndex = closed ? count : count - 1;
            Vector3 prevPoint = part.Points[0];
            bool prev_below = prevPoint.X <= x;
            for (int i = 1; i <= endIndex; i++)
            {
                Vector3 currentPoint = part.Points[i % count];
                bool below = currentPoint.X <= x;

                if (prev_below != below)
                {
                    Vector3 point = GetIntersectionPoint(prevPoint, currentPoint, x);
                    points.Add(point);
                }
                else if (!closed && prevPoint.X == x)
                    points.Add(prevPoint);

                prevPoint = currentPoint;
                prev_below = below;
            }
            if (!closed && prevPoint.X == x)
                points.Add(prevPoint);
        }

        private Vector3 GetIntersectionPoint(Vector3 p1, Vector3 p2, float x)
        {
            Vector3 d = p2 - p1;
            float k = (x - p1.X) / d.X;
            return new Vector3(x, p1.Y + k * d.Y, p1.Z);
        }
    }
}
