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
    public class FillPartTests
    {
        FillPart part;

        [TestInitialize]
        public void Initialize()
        {
            part = new FillPart();
        }

        [TestCleanup]
        public void Cleanup()
        {
            part = null;
        }

        [TestMethod]
        public void Defaults()
        {
            Assert.IsNotNull(part.Points);
            Assert.AreEqual(0, part.Points.Count);
        }

        [TestMethod]
        public void TransformTest()
        {
            part.Points.Add(Vector3.UnitX);
            part.Points.Add(Vector3.UnitY);

            Matrix3 matrix = Matrix3.CreateRotationZ((float)(-90 * Math.PI / 180));
            part.Transform(matrix);

            Assert.IsTrue(part.Points[0].Near(new Vector3(0f, -1f, 0f)));
            Assert.IsTrue(part.Points[1].Near(Vector3.UnitX));
        }
    }
}
