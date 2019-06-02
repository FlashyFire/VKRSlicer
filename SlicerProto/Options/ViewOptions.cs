using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using OpenTK.Graphics;

namespace SlicerProto.Options
{
    [Serializable]
    public class ViewOptions : BaseOptions
    {
        private Color4 buildAreaLineColor = Color4.Gray;
        private Color4 majorGridlineColor = Color4.Black;
        private Color4 minorGridlineColor = Color4.DarkGray;
        private Color4 axisColor = Color4.Red;
        private bool showBuildArea = true;
        private bool showAxes = true;
        private int majorGridlineFactor = 5;
        private Color4 sliceLineColor = Color4.Yellow;
        private float sliceLineWidth = 3f;
        private Color4 fillLineColor = Color4.Yellow;
        private float fillLineWidth = 1f;
        private Color4 modelColor = Color4.CornflowerBlue;

        public Color4 BuildAreaLineColor {
            get => buildAreaLineColor;
            set {
                if (buildAreaLineColor != value)
                {
                    buildAreaLineColor = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Color4 MajorGridlineColor {
            get => majorGridlineColor;
            set {
                if (majorGridlineColor != value)
                {
                    majorGridlineColor = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Color4 MinorGridlineColor {
            get => minorGridlineColor;
            set {
                if (minorGridlineColor != value)
                {
                    minorGridlineColor = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Color4 AxisColor {
            get => axisColor;
            set {
                if (axisColor != value)
                {
                    axisColor = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool ShowBuildArea {
            get => showBuildArea;
            set {
                if (showBuildArea != value)
                {
                    showBuildArea = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool ShowAxes {
            get => showAxes;
            set {
                if (showAxes != value)
                {
                    showAxes = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int MajorGridlineFactor {
            get => majorGridlineFactor;
            set {
                if (majorGridlineFactor != value)
                {
                    majorGridlineFactor = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Color4 SliceLineColor {
            get => sliceLineColor;
            set {
                if (sliceLineColor != value)
                {
                    sliceLineColor = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public float SliceLineWidth {
            get => sliceLineWidth;
            set {
                if (sliceLineWidth != value)
                {
                    sliceLineWidth = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Color4 FillLineColor {
            get => fillLineColor;
            set {
                if (fillLineColor != value)
                {
                    fillLineColor = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public float FillLineWidth {
            get => fillLineWidth;
            set {
                if (fillLineWidth != value)
                {
                    fillLineWidth = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Color4 ModelColor {
            get => modelColor;
            set {
                if (modelColor != value)
                {
                    modelColor = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ViewOptions Clone()
        {
            ViewOptions result = new ViewOptions();
            result.CopyFrom(this);
            return result;
        }

        public void CopyFrom(ViewOptions other)
        {
            if (other == null)
                throw new ArgumentNullException("other");
            BuildAreaLineColor = other.BuildAreaLineColor;
            MajorGridlineColor = other.MajorGridlineColor;
            MinorGridlineColor = other.MinorGridlineColor;
            AxisColor = other.AxisColor;
            ShowBuildArea = other.ShowBuildArea;
            ShowAxes = other.ShowAxes;
            MajorGridlineFactor = other.MajorGridlineFactor;
            SliceLineColor = other.SliceLineColor;
            SliceLineWidth = other.SliceLineWidth;
            FillLineColor = other.FillLineColor;
            FillLineWidth = other.FillLineWidth;
            ModelColor = other.ModelColor;
        }

        public void Reset()
        {
            BuildAreaLineColor = Color4.Gray;
            MajorGridlineColor = Color4.Black;
            MinorGridlineColor = Color4.DarkGray;
            AxisColor = Color4.Red;
            ShowBuildArea = true;
            ShowAxes = true;
            MajorGridlineFactor = 5;
            SliceLineColor = Color4.Yellow;
            SliceLineWidth = 3f;
            FillLineColor = Color4.Yellow;
            FillLineWidth = 1f;
            ModelColor = Color4.CornflowerBlue;
        }
    }
}
