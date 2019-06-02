using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SlicerProto.Options
{
    [Serializable]
    public class SliceOptions : BaseOptions
    {
        private float simplifyDistance = 1e-3f;
        private bool flatten = true;
        private float flattenTolerance = 1e-2f;
        private float step = 0.2f;
        private float offset = 0f;

        public float SimplifyDistance {
            get => simplifyDistance;
            set {
                if (simplifyDistance != value)
                {
                    simplifyDistance = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool Flatten {
            get => flatten;
            set {
                if (flatten != value)
                {
                    flatten = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public float FlattenTolerance {
            get => flattenTolerance;
            set {
                if (flattenTolerance != value)
                {
                    flattenTolerance = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public float Step {
            get => step;
            set {
                if (step != value)
                {
                    step = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public float Offset {
            get => offset;
            set {
                if (offset != value)
                {
                    offset = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public SliceOptions Clone()
        {
            SliceOptions result = new SliceOptions();
            result.CopyFrom(this);
            return result;
        }

        public void CopyFrom(SliceOptions other)
        {
            if (other == null)
                throw new ArgumentNullException("other");
            SimplifyDistance = other.SimplifyDistance;
            Flatten = other.Flatten;
            FlattenTolerance = other.FlattenTolerance;
            Step = other.Step;
            Offset = other.Offset;
        }

        public void Reset()
        {
            SimplifyDistance = 1e-3f;
            Flatten = true;
            FlattenTolerance = 1e-2f;
            Step = 0.2f;
            Offset = 0f;
        }
    }
}
