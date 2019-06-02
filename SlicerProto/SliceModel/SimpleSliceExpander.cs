using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace SlicerProto.SliceModel
{
    public class SimpleSliceExpander : ISliceExpander
    {
        public SlicePart Expand(SlicePart part, float distance)
        {
            SlicePart result = new SlicePart();
            result.Closed = part.Closed;
            result.Normals.AddRange(part.Normals);
            for (int i = 0; i < part.Points.Count; i++)
            {
                int prevIndex = i == 0 ? part.Points.Count - 1 : i - 1;
                Vector2 prevNormal = part.Normals[prevIndex].Xy.Normalized();
                Vector2 currentNormal = part.Normals[i].Xy.Normalized();
                Vector3 expandBy = new Vector3((prevNormal + currentNormal) * distance);
                result.Points.Add(part.Points[i] + expandBy);
            }
            return result;
        }
    }
}
