using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SlicerProto.Options
{
    public enum FillType
    {
        Hatch,
        CrossHatch,
        Triangle
    }

    public enum FillLocation
    {
        OuterPerimeter,
        InnerPerimeter,
        InsideInnerPerimeter
    }

    [Serializable]
    public class FillOptions : BaseOptions
    {
        private FillType fillType = FillType.CrossHatch;
        private bool layerByLayer = true;
        private int percentage = 20;
        private float angleInDegrees = 45f;
        private float crossAngleInDegrees = 90f;
        private FillLocation fillLocation = FillLocation.InsideInnerPerimeter;
        private int solidLayerCount = 2;

        public FillType FillType {
            get => fillType;
            set {
                if (fillType != value)
                {
                    fillType = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool LayerByLayer {
            get => layerByLayer;
            set {
                if (layerByLayer != value)
                {
                    layerByLayer = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int Percentage {
            get => percentage;
            set {
                if (percentage != value)
                {
                    percentage = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public float AngleInDegrees {
            get => angleInDegrees;
            set {
                if (angleInDegrees != value)
                {
                    angleInDegrees = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public float CrossAngleInDegrees {
            get => crossAngleInDegrees;
            set {
                if (crossAngleInDegrees != value)
                {
                    crossAngleInDegrees = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public FillLocation FillLocation {
            get => fillLocation;
            set {
                if (fillLocation != value)
                {
                    fillLocation = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int SolidLayerCount {
            get => solidLayerCount;
            set {
                if (solidLayerCount != value)
                {
                    solidLayerCount = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public FillOptions Clone()
        {
            FillOptions result = new FillOptions();
            result.CopyFrom(this);
            return result;
        }

        public void CopyFrom(FillOptions other)
        {
            if (other == null)
                throw new ArgumentNullException("other");
            FillType = other.FillType;
            LayerByLayer = other.LayerByLayer;
            Percentage = other.Percentage;
            AngleInDegrees = other.AngleInDegrees;
            CrossAngleInDegrees = other.CrossAngleInDegrees;
            FillLocation = other.FillLocation;
            SolidLayerCount = other.SolidLayerCount;
        }

        public void Reset()
        {
            FillType = FillType.CrossHatch;
            LayerByLayer = true;
            Percentage = 20;
            AngleInDegrees = 45f;
            CrossAngleInDegrees = 90f;
            FillLocation = FillLocation.InsideInnerPerimeter;
            SolidLayerCount = 2;
        }
    }
}
