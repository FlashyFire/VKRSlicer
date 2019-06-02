using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlicerProto.ObjectModel;
using OpenTK;

namespace SlicerProto.Utils
{
    public static class ScaleHelper
    {
        public static float AutoScale(this ObjectDimensions dimensions, float maxSize)
        {
            float scale = 0f;
            Vector3 size = dimensions.Size;
            scale = GetScaleByComponent(scale, size.X, maxSize);
            scale = GetScaleByComponent(scale, size.Y, maxSize);
            scale = GetScaleByComponent(scale, size.Z, maxSize);
            if (scale == 0f)
                scale = 1f;
            return scale;
        }

        private static float GetScaleByComponent(float scale, float componentSize, float maxSize)
        {
            if (componentSize == 0f)
                return scale;
            if (scale == 0f)
                return maxSize / componentSize;
            return Math.Min(scale, maxSize / componentSize);
        }
    }
}
