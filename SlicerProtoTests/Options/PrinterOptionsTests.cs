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
    public class PrinterOptionsTests
    {
        [TestMethod]
        public void Defaults()
        {
            PrinterOptions options = new PrinterOptions();
            Assert.AreEqual(new Vector3(200f, 200f, 200f), options.GetBuildAreaSize());
            Assert.AreEqual(Vector3.Zero, options.GetHomePosition());
            Assert.AreEqual(0.4f, options.ExtruderDiameter);
            Assert.AreEqual(200f, options.ExtruderTemperature);
            Assert.AreEqual(true, options.TableHeating);
            Assert.AreEqual(100f, options.TableTemperature);
            Assert.AreEqual(0.01f, options.FilamentRate);
            Assert.AreEqual(5.7f, options.RetractDistance);
            Assert.AreEqual(7200, options.SpeedXYFast);
            Assert.AreEqual(1134, options.SpeedXYSlow);
            Assert.AreEqual(1002, options.SpeedZ);
            Assert.AreEqual(4800, options.SpeedE);
        }

        [TestMethod]
        public void CopyFrom()
        {
            PrinterOptions other = new PrinterOptions() {
                BuildAreaWidth = 450f,
                BuildAreaDepth = 350f,
                BuildAreaHeight = 500f,
                HomePositionX = 100f,
                HomePositionY = 50f,
                ExtruderDiameter = 0.2f,
                ExtruderTemperature = 180f,
                TableHeating = false,
                TableTemperature = 55f,
                FilamentRate = 0.5f,
                RetractDistance = 3f,
                SpeedXYFast = 6400,
                SpeedXYSlow = 2400,
                SpeedE = 3600,
                SpeedZ = 1500
            };

            PrinterOptions options = new PrinterOptions();
            options.CopyFrom(other);

            Assert.AreEqual(new Vector3(450f, 350f, 500f), options.GetBuildAreaSize());
            Assert.AreEqual(new Vector3(100f, 50f, 0f), options.GetHomePosition());
            Assert.AreEqual(0.2f, options.ExtruderDiameter);
            Assert.AreEqual(180f, options.ExtruderTemperature);
            Assert.AreEqual(false, options.TableHeating);
            Assert.AreEqual(55f, options.TableTemperature);
            Assert.AreEqual(0.5f, options.FilamentRate);
            Assert.AreEqual(3f, options.RetractDistance);
            Assert.AreEqual(6400, options.SpeedXYFast);
            Assert.AreEqual(2400, options.SpeedXYSlow);
            Assert.AreEqual(1500, options.SpeedZ);
            Assert.AreEqual(3600, options.SpeedE);
        }

        [TestMethod]
        public void Reset()
        {
            PrinterOptions options = new PrinterOptions()
            {
                BuildAreaWidth = 450f,
                BuildAreaDepth = 350f,
                BuildAreaHeight = 500f,
                HomePositionX = 100f,
                HomePositionY = 50f,
                ExtruderDiameter = 0.2f,
                ExtruderTemperature = 180f,
                TableHeating = false,
                TableTemperature = 55f,
                FilamentRate = 0.5f,
                RetractDistance = 3f,
                SpeedXYFast = 6400,
                SpeedXYSlow = 2400,
                SpeedE = 3600,
                SpeedZ = 1500
            };

            options.Reset();

            Assert.AreEqual(new Vector3(200f, 200f, 200f), options.GetBuildAreaSize());
            Assert.AreEqual(Vector3.Zero, options.GetHomePosition());
            Assert.AreEqual(0.4f, options.ExtruderDiameter);
            Assert.AreEqual(200f, options.ExtruderTemperature);
            Assert.AreEqual(true, options.TableHeating);
            Assert.AreEqual(100f, options.TableTemperature);
            Assert.AreEqual(0.01f, options.FilamentRate);
            Assert.AreEqual(5.7f, options.RetractDistance);
            Assert.AreEqual(7200, options.SpeedXYFast);
            Assert.AreEqual(1134, options.SpeedXYSlow);
            Assert.AreEqual(1002, options.SpeedZ);
            Assert.AreEqual(4800, options.SpeedE);
        }
    }
}
