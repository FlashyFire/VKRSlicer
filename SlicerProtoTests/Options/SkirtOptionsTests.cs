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
    public class SkirtOptionsTests
    {
        [TestMethod]
        public void Defaults()
        {
            SkirtOptions options = new SkirtOptions();
            Assert.AreEqual(true, options.Enabled);
            Assert.AreEqual(10f, options.Distance);
            Assert.AreEqual(1f, options.Step);
            Assert.AreEqual(3, options.Count);
        }

        [TestMethod]
        public void CopyFrom()
        {
            SkirtOptions other = new SkirtOptions()
            {
                Enabled = false,
                Distance = 20f,
                Step = 2f,
                Count = 5
            };

            SkirtOptions options = new SkirtOptions();
            options.CopyFrom(other);

            Assert.AreEqual(false, options.Enabled);
            Assert.AreEqual(20f, options.Distance);
            Assert.AreEqual(2f, options.Step);
            Assert.AreEqual(5, options.Count);
        }

        [TestMethod]
        public void Reset()
        {
            SkirtOptions options = new SkirtOptions()
            {
                Enabled = false,
                Distance = 20f,
                Step = 2f,
                Count = 5
            };

            options.Reset();

            Assert.AreEqual(true, options.Enabled);
            Assert.AreEqual(10f, options.Distance);
            Assert.AreEqual(1f, options.Step);
            Assert.AreEqual(3, options.Count);
        }
    }
}
