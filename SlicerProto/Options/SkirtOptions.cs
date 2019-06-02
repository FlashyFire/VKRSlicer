using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SlicerProto.Options
{
    [Serializable]
    public class SkirtOptions : BaseOptions
    {
        private bool enabled = true;
        private float distance = 10f;
        private float step = 1f;
        private int count = 3;

        public bool Enabled {
            get => enabled;
            set {
                if (enabled != value)
                {
                    enabled = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public float Distance {
            get => distance;
            set {
                if (distance != value)
                {
                    distance = value;
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

        public int Count {
            get => count;
            set {
                if (count != value)
                {
                    count = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public SkirtOptions Clone()
        {
            SkirtOptions result = new SkirtOptions();
            result.CopyFrom(this);
            return result;
        }

        public void CopyFrom(SkirtOptions other)
        {
            if (other == null)
                throw new ArgumentNullException("other");
            Enabled = other.Enabled;
            Distance = other.Distance;
            Step = other.Step;
            Count = other.Count;
        }

        public void Reset()
        {
            Enabled = true;
            Distance = 10f;
            Step = 1f;
            Count = 3;
        }
    }
}
