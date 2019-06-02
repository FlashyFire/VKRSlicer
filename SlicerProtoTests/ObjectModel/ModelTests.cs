using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK;
using SlicerProto.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlicerProto.ObjectModel.Tests
{
    [TestClass]
    public class ModelTests
    {
        Model model;

        [TestInitialize]
        public void Initialize()
        {
            model = new Model();
        }

        [TestCleanup]
        public void Cleanup()
        {
            model = null;
        }

        [TestMethod]
        public void Defaults()
        {
            Assert.IsTrue(string.IsNullOrEmpty(model.Name));
            Assert.AreEqual(0, model.Facets.Count);
        }

        [TestMethod]
        public void ClearTest()
        {
            model.Name = "test";
            model.Facets.Add(new Facet());
            model.Clear();

            Assert.IsTrue(string.IsNullOrEmpty(model.Name));
            Assert.AreEqual(0, model.Facets.Count);
        }

        [TestMethod]
        public void Transform()
        {
            Facet facet = new Facet();
            facet.Vx1 = Vector3.Zero;
            facet.Vx2 = Vector3.UnitX;
            facet.Vx3 = Vector3.UnitY;
            facet.Normal = Vector3.UnitZ;
            model.Facets.Add(facet);

            Matrix3 matrix = Matrix3.CreateRotationX((float)(90 * Math.PI / 180));
            model.Transform(matrix);

            Assert.AreEqual(Vector3.Zero, facet.Vx1);
            Assert.AreEqual(Vector3.UnitX, facet.Vx2);
            Assert.IsTrue(Vector3.Distance(Vector3.UnitZ, facet.Vx3) < 1e-5);
            Assert.IsTrue(Vector3.Distance(new Vector3(0f, -1f, 0f), facet.Normal) < 1e-5);
        }
    }
}