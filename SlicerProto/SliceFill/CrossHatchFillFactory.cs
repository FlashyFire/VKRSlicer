using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlicerProto.SliceModel;

namespace SlicerProto.SliceFill
{
    public class CrossHatchFillFactory : HatchFillFactory
    {
        public float CrossAngle { get; set; } = (float)(90f * Math.PI / 180);

        public override Fill CreateFill(Slice slice, float angle, float step)
        {
            if (LayerByLayer)
            {
                if (slice.Index % 2 != 0)
                    angle += CrossAngle;
                return base.CreateFill(slice, angle, step);
            }
            Fill fill = base.CreateFill(slice, angle, step);
            Fill crossFill = base.CreateFill(slice, angle + CrossAngle, step);
            fill.Parts.AddRange(crossFill.Parts);
            return fill;
        }
    }
}
