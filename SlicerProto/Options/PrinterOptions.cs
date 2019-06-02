using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using OpenTK;

namespace SlicerProto.Options
{
    [Serializable]
    public class PrinterOptions : BaseOptions
    {
        private float buildAreaWidth = 200f;
        private float buildAreaDepth = 200f;
        private float buildAreaHeight = 200f;
        private float homePositionX = 0f;
        private float homePositionY = 0f;
        private float extruderDiameter = 0.4f;
        private float extruderTemperature = 200f;
        private bool tableHeating = true;
        private float tableTemperature = 100f;
        private bool useFan = true;
        private int fanSpeed = 100;
        private float filamentRate = 0.01f;
        private float retractDistance = 5.7f;
        private int speedXYFast = 7200;
        private int speedXYSlow = 1134;
        private int speedZ = 1002;
        private int speedE = 4800;

        public float BuildAreaWidth {
            get => buildAreaWidth;
            set {
                if (buildAreaWidth != value)
                {
                    buildAreaWidth = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public float BuildAreaDepth {
            get => buildAreaDepth;
            set {
                if (buildAreaDepth != value)
                {
                    buildAreaDepth = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public float BuildAreaHeight {
            get => buildAreaHeight;
            set {
                if (buildAreaHeight != value)
                {
                    buildAreaHeight = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public float HomePositionX {
            get => homePositionX;
            set {
                if (homePositionX != value)
                {
                    homePositionX = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public float HomePositionY {
            get => homePositionY;
            set {
                if (homePositionY != value)
                {
                    homePositionY = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public float ExtruderDiameter {
            get => extruderDiameter;
            set {
                if (extruderDiameter != value)
                {
                    extruderDiameter = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public float ExtruderTemperature {
            get => extruderTemperature;
            set {
                if (extruderTemperature != value)
                {
                    extruderTemperature = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool TableHeating {
            get => tableHeating;
            set {
                if (tableHeating != value)
                {
                    tableHeating = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public float TableTemperature {
            get => tableTemperature;
            set {
                if (tableTemperature != value)
                {
                    tableTemperature = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool UseFan {
            get => useFan;
            set {
                if (useFan != value)
                {
                    useFan = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int FanSpeed {
            get => fanSpeed;
            set {
                if (fanSpeed != value)
                {
                    fanSpeed = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public float FilamentRate {
            get => filamentRate;
            set {
                if (filamentRate != value)
                {
                    filamentRate = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public float RetractDistance {
            get => retractDistance;
            set {
                if (retractDistance != value)
                {
                    retractDistance = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int SpeedXYFast {
            get => speedXYFast;
            set {
                if (speedXYFast != value)
                {
                    speedXYFast = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int SpeedXYSlow {
            get => speedXYSlow;
            set {
                if (speedXYSlow != value)
                {
                    speedXYSlow = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int SpeedZ {
            get => speedZ;
            set {
                if (speedZ != value)
                {
                    speedZ = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int SpeedE {
            get => speedE;
            set {
                if (speedE != value)
                {
                    speedE = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Vector3 GetBuildAreaSize() => new Vector3(BuildAreaWidth, BuildAreaDepth, BuildAreaHeight);
        public Vector3 GetHomePosition() => new Vector3(HomePositionX, HomePositionY, 0f);

        public PrinterOptions Clone()
        {
            PrinterOptions result = new PrinterOptions();
            result.CopyFrom(this);
            return result;
        }

        public void CopyFrom(PrinterOptions other)
        {
            if (other == null)
                throw new ArgumentNullException("other");
            BuildAreaWidth = other.BuildAreaWidth;
            BuildAreaDepth = other.BuildAreaDepth;
            BuildAreaHeight = other.BuildAreaHeight;
            HomePositionX = other.HomePositionX;
            HomePositionY = other.HomePositionY;
            ExtruderDiameter = other.ExtruderDiameter;
            ExtruderTemperature = other.ExtruderTemperature;
            TableHeating = other.TableHeating;
            TableTemperature = other.TableTemperature;
            UseFan = other.UseFan;
            FanSpeed = other.FanSpeed;
            FilamentRate = other.FilamentRate;
            RetractDistance = other.RetractDistance;
            SpeedXYFast = other.SpeedXYFast;
            SpeedXYSlow = other.SpeedXYSlow;
            SpeedZ = other.SpeedZ;
            SpeedE = other.SpeedE;
        }

        public void Reset()
        {
            BuildAreaWidth = 200f;
            BuildAreaDepth = 200f;
            BuildAreaHeight = 200f;
            HomePositionX = 0f;
            HomePositionY = 0f;
            ExtruderDiameter = 0.4f;
            ExtruderTemperature = 200f;
            TableHeating = true;
            TableTemperature = 100f;
            UseFan = true;
            FanSpeed = 100;
            FilamentRate = 0.01f;
            RetractDistance = 5.7f;
            SpeedXYFast = 7200;
            SpeedXYSlow = 1134;
            SpeedZ = 1002;
            SpeedE = 4800;
        }
    }
}
