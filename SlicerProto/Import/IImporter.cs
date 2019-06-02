using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlicerProto.ObjectModel;

namespace SlicerProto.Import
{
    internal interface IImporter
    {
        void Import(string fileName);
        void Import(Stream stream);
    }
}
