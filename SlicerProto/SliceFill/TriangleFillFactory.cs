using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlicerProto.SliceModel;

namespace SlicerProto.SliceFill
{
    public class TriangleFillFactory : HatchFillFactory
    {
        public override Fill CreateFill(Slice slice, float angle, float step)
        {
            if (LayerByLayer)
            {
                if (slice.Index % 3 == 1)
                    angle += (float)(120 * Math.PI / 180);
                if (slice.Index % 3 == 2)
                    angle += (float)(240 * Math.PI / 180);
                return base.CreateFill(slice, angle, step);
            }
            Fill fill = base.CreateFill(slice, angle, step);
            Fill crossFill = base.CreateFill(slice, (float)(angle + 120 * Math.PI / 180), step);
            fill.Parts.AddRange(crossFill.Parts);
            crossFill = base.CreateFill(slice, (float)(angle + 240 * Math.PI / 180), step);
            fill.Parts.AddRange(crossFill.Parts);
            return fill;
        }
    }
}
