using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SlicerProto.ObjectModel;
using SlicerProto.Utils;
using OpenTK;

namespace SlicerProto.Utils.Tests
{
    [TestClass]
    public class ScaleHelperTests
    {
        [TestMethod]
        public void ZeroDimensions()
        {
            ObjectDimensions dimensions = new ObjectDimensions();
            float scale = dimensions.AutoScale(10f);

            Assert.AreEqual(1f, scale);
        }

        [TestMethod]
        public void NoScale()
        {
            ObjectDimensions dimensions = new ObjectDimensions();
            dimensions.Initialize(new TestDimensions(10f, 10f, 10f));
            float scale = dimensions.AutoScale(10f);

            Assert.AreEqual(1f, scale);
        }

        [TestMethod]
        public void EqualComponentsScale()
        {
            ObjectDimensions dimensions = new ObjectDimensions();
            dimensions.Initialize(new TestDimensions(10f, 10f, 10f));
            float scale = dimensions.AutoScale(5f);

            Assert.AreEqual(0.5f, scale);
        }

        [TestMethod]
        public void XComponentScale()
        {
            ObjectDimensions dimensions = new ObjectDimensions();
            dimensions.Initialize(new TestDimensions(10f, 1f, 1f));
            float scale = dimensions.AutoScale(5f);

            Assert.AreEqual(0.5f, scale);
        }

        [TestMethod]
        public void YComponentScale()
        {
            ObjectDimensions dimensions = new ObjectDimensions();
            dimensions.Initialize(new TestDimensions(1f, 10f, 1f));
            float scale = dimensions.AutoScale(5f);

            Assert.AreEqual(0.5f, scale);
        }

        [TestMethod]
        public void ZComponentScale()
        {
            ObjectDimensions dimensions = new ObjectDimensions();
            dimensions.Initialize(new TestDimensions(1f, 1f, 10f));
            float scale = dimensions.AutoScale(5f);

            Assert.AreEqual(0.5f, scale);
        }
    }
}
