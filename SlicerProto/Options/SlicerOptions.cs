using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlicerProto.Options
{
    [Serializable]
    public class SlicerOptions
    {
        private PrinterOptions printer = new PrinterOptions();
        private SliceOptions slice = new SliceOptions();
        private FillOptions fill = new FillOptions();
        private SkirtOptions skirt = new SkirtOptions();
        private ViewOptions view = new ViewOptions();

        public PrinterOptions Printer {
            get => printer;
            set => printer = value ?? new PrinterOptions();
        }

        public SliceOptions Slice {
            get => slice;
            set => slice = value ?? new SliceOptions();
        }

        public FillOptions Fill {
            get => fill;
            set => fill = value ?? new FillOptions();
        }

        public SkirtOptions Skirt {
            get => skirt;
            set => skirt = value ?? new SkirtOptions();
        }

        public ViewOptions View {
            get => view;
            set => view = value ?? new ViewOptions();
        }

        public SlicerOptions Clone()
        {
            SlicerOptions result = new SlicerOptions();
            result.CopyFrom(this);
            return result;
        }

        public void CopyFrom(SlicerOptions other)
        {
            if (other == null)
                throw new ArgumentNullException("other");
            Printer.CopyFrom(other.Printer);
            Slice.CopyFrom(other.Slice);
            Fill.CopyFrom(other.Fill);
            Skirt.CopyFrom(other.Skirt);
            View.CopyFrom(other.View);
        }

        public void Reset()
        {
            Printer.Reset();
            Slice.Reset();
            Fill.Reset();
            Skirt.Reset();
            View.Reset();
        }
    }
}
