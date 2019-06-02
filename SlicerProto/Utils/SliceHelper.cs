using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using SlicerProto.ObjectModel;
using SlicerProto.Options;
using SlicerProto.SliceModel;

namespace SlicerProto.Utils
{
    public static class SliceHelper
    {
        public static PlanePosition GetPlanePosition(this Facet facet, float z)
        {
            if (facet.Vx1.Z > z && facet.Vx2.Z > z && facet.Vx3.Z > z)
                return PlanePosition.Above;
            if (facet.Vx1.Z <= z && facet.Vx2.Z <= z && facet.Vx3.Z <= z)
                return PlanePosition.Below;
            return PlanePosition.Intersect;
        }

        public static IEnumerable<Facet> GetSections(this Facet facet, float z)
        {
            List<Vector3> points = new List<Vector3>();

            bool below = facet.Vx1.Z <= z;
            if (below)
                points.Add(facet.Vx1);
            bool prev_below = below;

            below = facet.Vx2.Z <= z;

            if (prev_below != below)
            {
                Vector3 point = GetIntersectionPoint(facet.Vx1, facet.Vx2, z);
                points.Add(point);
            }

            if (below)
                points.Add(facet.Vx2);

            prev_below = below;
            below = facet.Vx3.Z <= z;
            if (prev_below != below)
            {
                Vector3 point = GetIntersectionPoint(facet.Vx2, facet.Vx3, z);
                points.Add(point);
            }

            if (below)
                points.Add(facet.Vx3);

            prev_below = below;
            below = facet.Vx1.Z <= z;
            if (prev_below != below)
            {
                Vector3 point = GetIntersectionPoint(facet.Vx3, facet.Vx1, z);
                points.Add(point);
            }

            List<Facet> result = new List<Facet>
            {
                new Facet()
                {
                    Normal = facet.Normal,
                    Vx1 = points[0],
                    Vx2 = points[1],
                    Vx3 = points[2]
                }
            };
            if (points.Count > 3)
            {
                result.Add(new Facet()
                {
                    Normal = facet.Normal,
                    Vx1 = points[0],
                    Vx2 = points[2],
                    Vx3 = points[3]
                });
            }
            return result;
        }

        private static Vector3 GetIntersectionPoint(Vector3 p1, Vector3 p2, float z)
        {
            Vector3 d = p2 - p1;
            float k = (z - p1.Z) / d.Z;
            return new Vector3(p1.X + k * d.X, p1.Y + k * d.Y, z);
        }

        public static IEnumerable<Facet> GetFacetsBelowPlane(this Model model, float z)
        {
            foreach (Facet facet in model.Facets)
            {
                PlanePosition position = facet.GetPlanePosition(z);
                if (position == PlanePosition.Below)
                {
                    yield return facet;
                }
                else if (position == PlanePosition.Intersect)
                {
                    foreach (Facet item in facet.GetSections(z))
                        yield return item;
                }
            }
        }

        public static Slice GetSlice(this Model model, float z, SlicerOptions options)
        {
            Slice slice = new Slice();
            foreach (Facet facet in model.Facets)
            {
                PlanePosition position = facet.GetPlanePosition(z);
                if (position == PlanePosition.Intersect)
                {
                    List<Vector3> points = facet.GetSection(z);
                    if (points.Count == 2)
                    {
                        slice.AddSection(points[0], points[1], facet.Normal);
                    }
                }
            }
            slice.Join();
            slice.Simplify(options.Slice.SimplifyDistance);
            if (options.Slice.Flatten)
                slice.Flatten(options.Slice.FlattenTolerance);
            return slice;
        }

        public static List<Vector3> GetSection(this Facet facet, float z)
        {
            List<Vector3> points = new List<Vector3>();

            bool prev_below = facet.Vx1.Z <= z;
            bool below = facet.Vx2.Z <= z;

            if (prev_below != below)
            {
                Vector3 point = GetIntersectionPoint(facet.Vx1, facet.Vx2, z);
                points.Add(point);
            }
            else if (facet.Vx1.Z == z)
                points.Add(facet.Vx1);

            prev_below = below;
            below = facet.Vx3.Z <= z;
            if (prev_below != below)
            {
                Vector3 point = GetIntersectionPoint(facet.Vx2, facet.Vx3, z);
                points.Add(point);
            }
            else if (facet.Vx2.Z == z)
                points.Add(facet.Vx2);

            if (points.Count < 2)
            {
                prev_below = below;
                below = facet.Vx1.Z <= z;
                if (prev_below != below)
                {
                    Vector3 point = GetIntersectionPoint(facet.Vx3, facet.Vx1, z);
                    points.Add(point);
                }
                else if (facet.Vx3.Z == z)
                    points.Add(facet.Vx1);
            }

            return points;
        }

        public static bool Near(this Vector3 first, Vector3 second)
        {
            return Vector3.Distance(first, second) <= 5e-6;
        }

        public static float GetDistanceToLine(this Vector3 p0, Vector3 p1, Vector3 p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            double length = Math.Sqrt(dy * dy + dx * dx);
            if (double.IsNaN(length) || double.IsInfinity(length))
                return float.PositiveInfinity;
            if (length == 0f && p0 == p1)
                return 0f;
            return (float)Math.Abs((dy * p0.X - dx * p0.Y + p2.X * p1.Y - p2.Y * p1.X) / length);
        }

        public static Slice GetSkirt(this Model model, float scale, SlicerOptions options)
        {
            Slice slice = new Slice();
            SlicePart part = new SlicePart();
            ObjectDimensions dimensions = model.Dimensions;
            Vector3 minPoint = dimensions.MinPoint;
            Vector3 maxPoint = dimensions.MaxPoint;
            float skirtDistance = options.Skirt.Distance / scale;
            float skirtZ = dimensions.MinPoint.Z + options.Printer.ExtruderDiameter / 2;

            part.Points.Add(new Vector3(minPoint.X - skirtDistance / 2, minPoint.Y - skirtDistance, skirtZ)); // 0
            part.Normals.Add(-Vector3.UnitY);

            part.Points.Add(new Vector3(maxPoint.X + skirtDistance / 2, minPoint.Y - skirtDistance, skirtZ)); // 1
            part.Normals.Add((Vector3.UnitX - Vector3.UnitY).Normalized());

            part.Points.Add(new Vector3(maxPoint.X + skirtDistance, minPoint.Y - skirtDistance / 2, skirtZ)); // 2
            part.Normals.Add(Vector3.UnitX);

            part.Points.Add(new Vector3(maxPoint.X + skirtDistance, maxPoint.Y + skirtDistance / 2, skirtZ)); // 3
            part.Normals.Add((Vector3.UnitX + Vector3.UnitY).Normalized());

            part.Points.Add(new Vector3(maxPoint.X + skirtDistance / 2, maxPoint.Y + skirtDistance, skirtZ)); // 4
            part.Normals.Add(Vector3.UnitY);

            part.Points.Add(new Vector3(minPoint.X - skirtDistance / 2, maxPoint.Y + skirtDistance, skirtZ)); // 5
            part.Normals.Add((-Vector3.UnitX + Vector3.UnitY).Normalized());

            part.Points.Add(new Vector3(minPoint.X - skirtDistance, maxPoint.Y + skirtDistance / 2, skirtZ)); // 6
            part.Normals.Add(-Vector3.UnitX);

            part.Points.Add(new Vector3(minPoint.X - skirtDistance, minPoint.Y - skirtDistance / 2, skirtZ)); // 7
            part.Normals.Add((-Vector3.UnitX - Vector3.UnitY).Normalized());

            part.Closed = true;
            slice.Parts.Add(part);
            return slice;
        }
    }
}
