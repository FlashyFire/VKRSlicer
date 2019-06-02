using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlicerProto.ObjectModel;

namespace SlicerProto.Import
{
    internal static class ImporterFactory
    {
        public static IImporter CreateImporter(Model model, string fileName)
        {
            if (string.Equals(Path.GetExtension(fileName), ".OBJ", StringComparison.CurrentCultureIgnoreCase))
                return new OBJImporter(model);
            return new STLImporter(model);
        }
    }
}
