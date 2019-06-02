using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace SlicerProto.SliceFill
{
    public class Fill
    {
        public List<FillPart> Parts { get; } = new List<FillPart>();

        public void Transform(Matrix3 matrix)
        {
            foreach (FillPart part in Parts)
                part.Transform(matrix);
        }
    }
}
