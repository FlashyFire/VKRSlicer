using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using SlicerProto.Utils;

namespace SlicerProto.SliceModel
{
    public class Slice
    {
        public int Index { get; set; }
        public List<SlicePart> Parts { get; } = new List<SlicePart>();

        public void AddSection(Vector3 first, Vector3 second, Vector3 normal = new Vector3())
        {
            foreach (SlicePart part in Parts)
            {
                if (part.AddSection(first, second, normal))
                    return;
            }
            SlicePart newPart = new SlicePart();
            newPart.AddSection(first, second, normal);
            Parts.Add(newPart);
        }

        public void Join()
        {
            for (int i = Parts.Count - 1; i > 0; i--)
            {
                SlicePart partToJoin = Parts[i];
                if (partToJoin.Closed)
                    continue;
                for (int j = i - 1; j >= 0; j--)
                {
                    SlicePart part = Parts[j];
                    if (part.Join(partToJoin))
                    {
                        Parts.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        public void Simplify(float delta)
        {
            foreach (SlicePart part in Parts)
                part.Simplify(delta);
        }

        public void Flatten(float tolerance)
        {
            foreach (SlicePart part in Parts)
                part.Flatten(tolerance);
        }

        public Slice Transform(Matrix3 matrix)
        {
            Slice result = new Slice();
            result.Index = Index;
            foreach(SlicePart part in Parts)
            {
                result.Parts.Add(part.Transform(matrix));
            }
            return result;
        }

        public ObjectDimensions GetDimensions()
        {
            if (Parts.Count == 0)
                throw new InvalidOperationException("Get dimensions from empty slice.");
            ObjectDimensions result = Parts[0].GetDimensions();
            for (int i = 1; i < Parts.Count; i++)
            {
                result.Aggregate(Parts[i].GetDimensions());
            }
            return result;
        }

        public Slice Expand(ISliceExpander expander, float distance)
        {
            if (expander == null)
                throw new ArgumentNullException("expander");
            Slice result = new Slice();
            result.Index = Index;
            foreach (SlicePart part in Parts)
            {
                result.Parts.Add(expander.Expand(part, distance));
            }
            return result;
        }

        public static Slice Combine(Slice first, Slice second, float z)
        {
            Slice result = new Slice();
            result.Index = first.Index;
            result.Parts.AddRange(first.Parts.Select(x=> x.GetZPlane(z)));
            result.Parts.AddRange(second.Parts.Select(x => x.GetZPlane(z)));
            return result;
        }

        public Slice Clone()
        {
            Slice result = new Slice();
            result.Index = Index;
            foreach (SlicePart part in Parts)
            {
                result.Parts.Add(part.Clone());
            }
            return result;
        }
    }
}
