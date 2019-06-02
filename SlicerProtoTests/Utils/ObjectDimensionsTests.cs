using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SlicerProto.ObjectModel;
using SlicerProto.Utils;
using OpenTK;

namespace SlicerProto.Utils.Tests
{
    [TestClass]
    public class ObjectDimensionsTests
    {
        ObjectDimensions dimensions;

        [TestInitialize]
        public void Initialize()
        {
            dimensions = new ObjectDimensions();
        }

        [TestCleanup]
        public void Cleanup()
        {
            dimensions = null;
        }

        [TestMethod]
        public void Defaults()
        {
            Assert.AreEqual(Vector3.Zero, dimensions.MinPoint);
            Assert.AreEqual(Vector3.Zero, dimensions.MaxPoint);
            Assert.AreEqual(Vector3.Zero, dimensions.Size);
        }

        [TestMethod]
        public void InitializeTest()
        {
            Facet facet = new Facet();

            facet.Vx1.X = 1f;
            facet.Vx1.Y = 2f;
            facet.Vx1.Z = 3f;

            facet.Vx2.X = -1f;
            facet.Vx2.Y = -2f;
            facet.Vx2.Z = -3f;

            dimensions.Initialize(facet);

            Assert.AreEqual(new Vector3(-1f, -2f, -3f), dimensions.MinPoint);
            Assert.AreEqual(new Vector3(1f, 2f, 3f), dimensions.MaxPoint);
            Assert.AreEqual(new Vector3(2f, 4f, 6f), dimensions.Size);
        }

        [TestMethod]
        public void InitializeVectorTest()
        {
            Vector3 vector = new Vector3(1f, 2f, 3f);

            dimensions.Initialize(vector);

            Assert.AreEqual(new Vector3(1f, 2f, 3f), dimensions.MinPoint);
            Assert.AreEqual(new Vector3(1f, 2f, 3f), dimensions.MaxPoint);
            Assert.AreEqual(Vector3.Zero, dimensions.Size);
        }

        [TestMethod]
        public void AggregateTest()
        {
            Facet facet = new Facet();

            facet.Vx1.X = 1f;
            facet.Vx1.Y = 2f;
            facet.Vx1.Z = 3f;

            facet.Vx2.X = -1f;
            facet.Vx2.Y = -2f;
            facet.Vx2.Z = -3f;

            dimensions.Aggregate(facet);

            Assert.AreEqual(new Vector3(-1f, -2f, -3f), dimensions.MinPoint);
            Assert.AreEqual(new Vector3(1f, 2f, 3f), dimensions.MaxPoint);
            Assert.AreEqual(new Vector3(2f, 4f, 6f), dimensions.Size);
        }

        [TestMethod]
        public void AggregateVectorTest()
        {
            Vector3 vector = new Vector3(1f, 2f, 3f);

            dimensions.Aggregate(vector);

            Assert.AreEqual(Vector3.Zero, dimensions.MinPoint);
            Assert.AreEqual(new Vector3(1f, 2f, 3f), dimensions.MaxPoint);
            Assert.AreEqual(new Vector3(1f, 2f, 3f), dimensions.Size);
        }
    }
}
