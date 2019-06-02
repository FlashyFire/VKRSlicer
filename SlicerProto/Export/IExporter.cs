using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlicerProto.Export
{
    public interface IExporter
    {
        void Export(string fileName);
        void Export(Stream stream);

        TimeSpan EstimatedTime { get; }

        event EventHandler<ExportProgressEventArgs> OnProgress;
    }
}
