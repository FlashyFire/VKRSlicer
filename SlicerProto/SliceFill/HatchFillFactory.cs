using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using SlicerProto.SliceModel;
using SlicerProto.Utils;

namespace SlicerProto.SliceFill
{
    public class HatchFillFactory : FillFactory
    {
        protected override void GenerateFill(Fill fill, Slice slice, float step)
        {
            ObjectDimensions dimensions = slice.GetDimensions();
            int minIndex = (int)Math.Truncate(dimensions.MinPoint.X / step);
            int maxIndex = (int)Math.Truncate(dimensions.MaxPoint.X / step);
            if ((minIndex * step) <= dimensions.MinPoint.X)
                minIndex++;
            if ((maxIndex * step) >= dimensions.MaxPoint.X)
                maxIndex--;
            for (int i = minIndex; i <= maxIndex; i++)
            {
                GenerateParts(fill, slice, i * step, i % 2 != 0);
            }
        }

        protected void GenerateParts(Fill fill, Slice slice, float x, bool reverse)
        {
            List<Vector3> points = GetIntersectionPoints(slice, x);
            if (points.Count == 0)
                return;
            if (reverse)
                points.Sort((p1, p2) => p2.Y.CompareTo(p1.Y));
            else
                points.Sort((p1, p2) => p1.Y.CompareTo(p2.Y));
            for (int i = 0; i < points.Count / 2; i++)
            {
                FillPart part = new FillPart();
                part.Points.Add(points[i * 2]);
                part.Points.Add(points[i * 2 + 1]);
                fill.Parts.Add(part);
            }
        }
    }
}
