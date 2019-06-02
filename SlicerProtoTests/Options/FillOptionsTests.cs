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
    public class FillOptionsTests
    {
        [TestMethod]
        public void Defaults()
        {
            FillOptions options = new FillOptions();
            Assert.AreEqual(FillType.CrossHatch, options.FillType);
            Assert.AreEqual(true, options.LayerByLayer);
            Assert.AreEqual(20, options.Percentage);
            Assert.AreEqual(45f, options.AngleInDegrees);
            Assert.AreEqual(90f, options.CrossAngleInDegrees);
            Assert.AreEqual(FillLocation.InsideInnerPerimeter, options.FillLocation);
            Assert.AreEqual(2, options.SolidLayerCount);
        }

        [TestMethod]
        public void CopyFrom()
        {
            FillOptions other = new FillOptions() {
                FillType = FillType.Triangle,
                LayerByLayer = false,
                Percentage = 55,
                AngleInDegrees = 30f,
                CrossAngleInDegrees = 60f,
                FillLocation = FillLocation.OuterPerimeter,
                SolidLayerCount = 3
            };

            FillOptions options = new FillOptions();
            options.CopyFrom(other);

            Assert.AreEqual(FillType.Triangle, options.FillType);
            Assert.AreEqual(false, options.LayerByLayer);
            Assert.AreEqual(55, options.Percentage);
            Assert.AreEqual(30f, options.AngleInDegrees);
            Assert.AreEqual(60f, options.CrossAngleInDegrees);
            Assert.AreEqual(FillLocation.OuterPerimeter, options.FillLocation);
            Assert.AreEqual(3, options.SolidLayerCount);
        }

        [TestMethod]
        public void Reset()
        {
            FillOptions options = new FillOptions()
            {
                FillType = FillType.Triangle,
                LayerByLayer = false,
                Percentage = 55,
                AngleInDegrees = 30f,
                CrossAngleInDegrees = 60f,
                FillLocation = FillLocation.OuterPerimeter,
                SolidLayerCount = 3
            };

            options.Reset();

            Assert.AreEqual(FillType.CrossHatch, options.FillType);
            Assert.AreEqual(true, options.LayerByLayer);
            Assert.AreEqual(20, options.Percentage);
            Assert.AreEqual(45f, options.AngleInDegrees);
            Assert.AreEqual(90f, options.CrossAngleInDegrees);
            Assert.AreEqual(FillLocation.InsideInnerPerimeter, options.FillLocation);
            Assert.AreEqual(2, options.SolidLayerCount);
        }
    }
}
