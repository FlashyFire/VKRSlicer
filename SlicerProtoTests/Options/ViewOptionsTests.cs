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
    public class ViewOptionsTests
    {
        [TestMethod]
        public void Defaults()
        {
            ViewOptions options = new ViewOptions();
            Assert.AreEqual(Color4.Gray, options.BuildAreaLineColor);
            Assert.AreEqual(Color4.Black, options.MajorGridlineColor);
            Assert.AreEqual(Color4.DarkGray, options.MinorGridlineColor);
            Assert.AreEqual(Color4.Red, options.AxisColor);
            Assert.AreEqual(true, options.ShowBuildArea);
            Assert.AreEqual(true, options.ShowAxes);
            Assert.AreEqual(5, options.MajorGridlineFactor);
            Assert.AreEqual(Color4.Yellow, options.SliceLineColor);
            Assert.AreEqual(3f, options.SliceLineWidth);
            Assert.AreEqual(Color4.Yellow, options.FillLineColor);
            Assert.AreEqual(1f, options.FillLineWidth);
            Assert.AreEqual(Color4.CornflowerBlue, options.ModelColor);
        }

        [TestMethod]
        public void CopyFrom()
        {
            ViewOptions other = new ViewOptions()
            {
                BuildAreaLineColor = Color4.Chocolate,
                MajorGridlineColor = Color4.Coral,
                MinorGridlineColor = Color4.Cornsilk,
                AxisColor = Color4.Cyan,
                ShowBuildArea = false,
                ShowAxes = false,
                MajorGridlineFactor = 10,
                SliceLineColor = Color4.DarkBlue,
                SliceLineWidth = 5f,
                FillLineColor = Color4.DarkCyan,
                FillLineWidth = 2f,
                ModelColor = Color4.DarkGreen
            };

            ViewOptions options = new ViewOptions();
            options.CopyFrom(other);

            Assert.AreEqual(Color4.Chocolate, options.BuildAreaLineColor);
            Assert.AreEqual(Color4.Coral, options.MajorGridlineColor);
            Assert.AreEqual(Color4.Cornsilk, options.MinorGridlineColor);
            Assert.AreEqual(Color4.Cyan, options.AxisColor);
            Assert.AreEqual(false, options.ShowBuildArea);
            Assert.AreEqual(false, options.ShowAxes);
            Assert.AreEqual(10, options.MajorGridlineFactor);
            Assert.AreEqual(Color4.DarkBlue, options.SliceLineColor);
            Assert.AreEqual(5f, options.SliceLineWidth);
            Assert.AreEqual(Color4.DarkCyan, options.FillLineColor);
            Assert.AreEqual(2f, options.FillLineWidth);
            Assert.AreEqual(Color4.DarkGreen, options.ModelColor);
        }

        [TestMethod]
        public void Reset()
        {
            ViewOptions options = new ViewOptions()
            {
                BuildAreaLineColor = Color4.Chocolate,
                MajorGridlineColor = Color4.Coral,
                MinorGridlineColor = Color4.Cornsilk,
                AxisColor = Color4.Cyan,
                ShowBuildArea = false,
                ShowAxes = false,
                MajorGridlineFactor = 10,
                SliceLineColor = Color4.DarkBlue,
                SliceLineWidth = 5f,
                FillLineColor = Color4.DarkCyan,
                FillLineWidth = 2f,
                ModelColor = Color4.DarkGreen
            };

            options.Reset();

            Assert.AreEqual(Color4.Gray, options.BuildAreaLineColor);
            Assert.AreEqual(Color4.Black, options.MajorGridlineColor);
            Assert.AreEqual(Color4.DarkGray, options.MinorGridlineColor);
            Assert.AreEqual(Color4.Red, options.AxisColor);
            Assert.AreEqual(true, options.ShowBuildArea);
            Assert.AreEqual(true, options.ShowAxes);
            Assert.AreEqual(5, options.MajorGridlineFactor);
            Assert.AreEqual(Color4.Yellow, options.SliceLineColor);
            Assert.AreEqual(3f, options.SliceLineWidth);
            Assert.AreEqual(Color4.Yellow, options.FillLineColor);
            Assert.AreEqual(1f, options.FillLineWidth);
            Assert.AreEqual(Color4.CornflowerBlue, options.ModelColor);
        }
    }
}
