using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlicerProto.SliceModel
{
    public interface ISliceExpander
    {
        SlicePart Expand(SlicePart part, float distance);
    }
}
