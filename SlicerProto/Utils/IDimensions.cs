using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace SlicerProto.Utils
{
    public interface IDimensions
    {
        Vector3 MinPoint { get; }
        Vector3 MaxPoint { get; }
    }
}
