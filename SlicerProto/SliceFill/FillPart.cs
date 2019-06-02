using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace SlicerProto.SliceFill
{
    public class FillPart
    {
        public List<Vector3> Points { get; } = new List<Vector3>();

        public void Transform(Matrix3 matrix)
        {
            for (int i = 0; i < Points.Count; i++)
                Points[i] = Vector3.Transform(Points[i], matrix);
        }
    }
}