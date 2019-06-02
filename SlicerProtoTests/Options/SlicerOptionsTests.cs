using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK;
using SlicerProto.Options;

namespace SlicerProto.Options.Tests
{
    [TestClass]
    public class SlicerOptionsTests
    {
        [TestMethod]
        public void Defaults()
        {
            SlicerOptions options = new SlicerOptions();
            Assert.IsNotNull(options.Printer);
            Assert.IsNotNull(options.Slice);
            Assert.IsNotNull(options.Fill);
            Assert.IsNotNull(options.Skirt);
            Assert.IsNotNull(options.View);
        }
    }
}
