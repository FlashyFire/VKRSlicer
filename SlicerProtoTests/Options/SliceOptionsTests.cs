using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Graphics;
using SlicerProto.Options;

namespace SlicerProto.Options.Tests
{
    [TestClass]
    public class SliceOptionsTests
    {
        [TestMethod]
        public void Defaults()
        {
            SliceOptions options = new SliceOptions();
            Assert.AreEqual(1e-3f, options.SimplifyDistance);
            Assert.AreEqual(true, options.Flatten);
            Assert.AreEqual(1e-2f, options.FlattenTolerance);
            Assert.AreEqual(0.2f, options.Step);
            Assert.AreEqual(0f, options.Offset);
        }

        [TestMethod]
        public void CopyFrom()
        {
            SliceOptions other = new SliceOptions() {
                SimplifyDistance = 2e-3f,
                Flatten = false,
                FlattenTolerance = 5e-3f,
                Step = 0.4f,
                Offset = -0.1f
            };

            SliceOptions options = new SliceOptions();
            options.CopyFrom(other);

            Assert.AreEqual(2e-3f, options.SimplifyDistance);
            Assert.AreEqual(false, options.Flatten);
            Assert.AreEqual(5e-3f, options.FlattenTolerance);
            Assert.AreEqual(0.4f, options.Step);
            Assert.AreEqual(-0.1f, options.Offset);
        }

        [TestMethod]
        public void Reset()
        {
            SliceOptions options = new SliceOptions()
            {
                SimplifyDistance = 2e-3f,
                Flatten = false,
                FlattenTolerance = 5e-3f,
                Step = 0.4f,
                Offset = 1f
            };

            options.Reset();

            Assert.AreEqual(1e-3f, options.SimplifyDistance);
            Assert.AreEqual(true, options.Flatten);
            Assert.AreEqual(1e-2f, options.FlattenTolerance);
            Assert.AreEqual(0.2f, options.Step);
            Assert.AreEqual(0f, options.Offset);
        }
    }
}
