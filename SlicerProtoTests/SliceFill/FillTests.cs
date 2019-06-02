using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK;
using SlicerProto.Utils;

namespace SlicerProto.SliceFill.Tests
{
    [TestClass]
    public class FillTests
    {
        Fill fill;

        [TestInitialize]
        public void Initialize()
        {
            fill = new Fill();
        }

        [TestCleanup]
        public void Cleanup()
        {
            fill = null;
        }

        [TestMethod]
        public void Defaults()
        {
            Assert.IsNotNull(fill.Parts);
            Assert.AreEqual(0, fill.Parts.Count);
        }

        [TestMethod]
        public void TransformTest()
        {
            FillPart part = new FillPart();
            part.Points.Add(Vector3.UnitX);
            part.Points.Add(Vector3.UnitY);
            fill.Parts.Add(part);

            Matrix3 matrix = Matrix3.CreateRotationZ((float)(-90 * Math.PI / 180));
            fill.Transform(matrix);

            Assert.IsTrue(part.Points[0].Near(new Vector3(0f, -1f, 0f)));
            Assert.IsTrue(part.Points[1].Near(Vector3.UnitX));
        }
    }
}
