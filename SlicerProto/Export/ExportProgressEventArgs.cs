using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlicerProto.Export
{
    public class ExportProgressEventArgs : EventArgs
    {
        public ExportProgressEventArgs(int progress)
        {
            Progress = progress;
            Abort = false;
        }

        public int Progress { get; private set; }
        public bool Abort { get; set; }
    }
}
