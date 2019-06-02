using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SlicerProto.ObjectModel;
using OpenTK;

namespace SlicerProto.ObjectModel.Tests
{
    [TestClass]
    public class FacetTests
    {
        Facet facet;

        [TestInitialize]
        public void Initialize()
        {
            facet = new Facet();
        }

        [TestCleanup]
        public void Cleanup()
        {
            facet = null;
        }

        [TestMethod]
        public void Defaults()
        {
            Assert.AreEqual(Vector3.Zero, facet.Normal);
            Assert.AreEqual(Vector3.Zero, facet.Vx1);
            Assert.AreEqual(Vector3.Zero, facet.Vx2);
            Assert.AreEqual(Vector3.Zero, facet.Vx3);

            Assert.AreEqual(Vector3.Zero, facet.MinPoint);
            Assert.AreEqual(Vector3.Zero, facet.MaxPoint);
        }

        [TestMethod]
        public void DimensionsVx1()
        {
            facet.Vx1.X = 1f;
            facet.Vx1.Y = 2f;
            facet.Vx1.Z = 3f;

            Assert.AreEqual(Vector3.Zero, facet.MinPoint);
            Assert.AreEqual(new Vector3(1f, 2f, 3f), facet.MaxPoint);

            facet.Vx1.X = -1f;
            facet.Vx1.Y = -2f;
            facet.Vx1.Z = -3f;

            Assert.AreEqual(new Vector3(-1f, -2f, -3f), facet.MinPoint);
            Assert.AreEqual(Vector3.Zero, facet.MaxPoint);
        }

        [TestMethod]
        public void DimensionsVx2()
        {
            facet.Vx2.X = 1f;
            facet.Vx2.Y = 2f;
            facet.Vx2.Z = 3f;

            Assert.AreEqual(Vector3.Zero, facet.MinPoint);
            Assert.AreEqual(new Vector3(1f, 2f, 3f), facet.MaxPoint);

            facet.Vx2.X = -1f;
            facet.Vx2.Y = -2f;
            facet.Vx2.Z = -3f;

            Assert.AreEqual(new Vector3(-1f, -2f, -3f), facet.MinPoint);
            Assert.AreEqual(Vector3.Zero, facet.MaxPoint);
        }

        [TestMethod]
        public void DimensionsVx3()
        {
            facet.Vx3.X = 1f;
            facet.Vx3.Y = 2f;
            facet.Vx3.Z = 3f;

            Assert.AreEqual(Vector3.Zero, facet.MinPoint);
            Assert.AreEqual(new Vector3(1f, 2f, 3f), facet.MaxPoint);

            facet.Vx3.X = -1f;
            facet.Vx3.Y = -2f;
            facet.Vx3.Z = -3f;

            Assert.AreEqual(new Vector3(-1f, -2f, -3f), facet.MinPoint);
            Assert.AreEqual(Vector3.Zero, facet.MaxPoint);
        }

        [TestMethod]
        public void TransformRotationX()
        {
            facet.Vx1 = Vector3.Zero;
            facet.Vx2 = Vector3.UnitX;
            facet.Vx3 = Vector3.UnitY;
            facet.Normal = Vector3.UnitZ;

            Matrix3 matrix = Matrix3.CreateRotationX((float)(90 * Math.PI / 180));
            facet.Transform(matrix);

            Assert.AreEqual(Vector3.Zero, facet.Vx1);
            Assert.AreEqual(Vector3.UnitX, facet.Vx2);
            Assert.IsTrue(Vector3.Distance(Vector3.UnitZ, facet.Vx3) < 1e-5);
            Assert.IsTrue(Vector3.Distance(new Vector3(0f, -1f, 0f), facet.Normal) < 1e-5);
        }

        [TestMethod]
        public void TransformRotationY()
        {
            facet.Vx1 = Vector3.Zero;
            facet.Vx2 = Vector3.UnitX;
            facet.Vx3 = Vector3.UnitY;
            facet.Normal = Vector3.UnitZ;

            Matrix3 matrix = Matrix3.CreateRotationY((float)(90 * Math.PI / 180));
            facet.Transform(matrix);

            Assert.AreEqual(Vector3.Zero, facet.Vx1);
            Assert.IsTrue(Vector3.Distance(new Vector3(0f, 0f, -1f), facet.Vx2) < 1e-5);
            Assert.AreEqual(Vector3.UnitY, facet.Vx3);
            Assert.IsTrue(Vector3.Distance(new Vector3(1f, 0f, 0f), facet.Normal) < 1e-5);
        }

        [TestMethod]
        public void TransformRotationZ()
        {
            facet.Vx1 = Vector3.UnitY;
            facet.Vx2 = Vector3.Zero;
            facet.Vx3 = Vector3.UnitX;
            facet.Normal = Vector3.UnitZ;

            Matrix3 matrix = Matrix3.CreateRotationZ((float)(90 * Math.PI / 180));
            facet.Transform(matrix);

            Assert.IsTrue(Vector3.Distance(new Vector3(-1f, 0f, 0f), facet.Vx1) < 1e-5);
            Assert.AreEqual(Vector3.Zero, facet.Vx2);
            Assert.IsTrue(Vector3.Distance(Vector3.UnitY, facet.Vx3) < 1e-5);
            Assert.AreEqual(Vector3.UnitZ, facet.Normal);
        }
    }
}
