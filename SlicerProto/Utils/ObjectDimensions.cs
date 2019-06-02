using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace SlicerProto.Utils
{
    public class ObjectDimensions : IDimensions
    {
        public Vector3 MinPoint { get; private set; } = Vector3.Zero;
        public Vector3 MaxPoint { get; private set; } = Vector3.Zero;
        public Vector3 Size => MaxPoint - MinPoint;

        public void Initialize(IDimensions source)
        {
            MinPoint = source.MinPoint;
            MaxPoint = source.MaxPoint;
        }

        public void Initialize(Vector3 source)
        {
            MinPoint = source;
            MaxPoint = source;
        }

        public void Aggregate(IDimensions source)
        {
            MinPoint = Vector3.ComponentMin(MinPoint, source.MinPoint);
            MaxPoint = Vector3.ComponentMax(MaxPoint, source.MaxPoint);
        }

        public void Aggregate(Vector3 source)
        {
            MinPoint = Vector3.ComponentMin(MinPoint, source);
            MaxPoint = Vector3.ComponentMax(MaxPoint, source);
        }
    }
}
