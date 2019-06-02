using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using SlicerProto.Utils;

namespace SlicerProto.ObjectModel
{
    public class Facet : IDimensions
    {
        public Vector3 Normal;
        public Vector3 Vx1;
        public Vector3 Vx2;
        public Vector3 Vx3;

        public Vector3 MinPoint => Vector3.ComponentMin(Vx1, Vector3.ComponentMin(Vx2, Vx3));
        public Vector3 MaxPoint => Vector3.ComponentMax(Vx1, Vector3.ComponentMax(Vx2, Vx3));

        public void Transform(Matrix3 matrix)
        {
            Vx1 = Vector3.Transform(Vx1, matrix);
            Vx2 = Vector3.Transform(Vx2, matrix);
            Vx3 = Vector3.Transform(Vx3, matrix);
            Normal = Vector3.Transform(Normal, matrix);
            Normal.Normalize();
        }

        public Facet Clone()
        {
            Facet result = new Facet();
            result.CopyFrom(this);
            return result;
        }

        public void CopyFrom(Facet other)
        {
            if (other == null)
                throw new ArgumentNullException("other");
            Vx1 = other.Vx1;
            Vx2 = other.Vx2;
            Vx3 = other.Vx3;
            Normal = other.Normal;
        }
    }
}
