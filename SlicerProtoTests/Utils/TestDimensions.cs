using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlicerProto.ObjectModel;
using SlicerProto.Utils;
using OpenTK;

namespace SlicerProto.Utils.Tests
{
    class TestDimensions : IDimensions
    {
        public TestDimensions(float dx, float dy, float dz)
        {
            MinPoint = Vector3.Zero;
            MaxPoint = new Vector3(dx, dy, dz);
        }

        public Vector3 MinPoint { get; }
        public Vector3 MaxPoint { get; }
    }
}
