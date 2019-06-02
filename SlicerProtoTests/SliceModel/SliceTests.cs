using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SlicerProto.SliceModel;
using SlicerProto.Utils;
using OpenTK;

namespace SlicerProto.SliceModel.Tests
{
    [TestClass]
    public class SliceTests
    {
        Slice slice;

        [TestInitialize]
        public void Initialize()
        {
            slice = new Slice();
        }

        [TestCleanup]
        public void Cleanup()
        {
            slice = null;
        }

        [TestMethod]
        public void Defaults()
        {
            Assert.IsNotNull(slice.Parts);
            Assert.AreEqual(0, slice.Parts.Count);
        }

        [TestMethod]
        public void AddSection()
        {
            slice.AddSection(Vector3.Zero, Vector3.UnitX, Vector3.UnitY);

            Assert.AreEqual(1, slice.Parts.Count);
            Assert.AreEqual(2, slice.Parts[0].Points.Count);
            Assert.AreEqual(2, slice.Parts[0].Normals.Count);
        }

        [TestMethod]
        public void AddNextSection()
        {
            slice.AddSection(Vector3.Zero, Vector3.UnitX, Vector3.UnitY);
            slice.AddSection(Vector3.UnitX, Vector3.UnitY, Vector3.One);

            Assert.AreEqual(1, slice.Parts.Count);
            Assert.AreEqual(3, slice.Parts[0].Points.Count);
            Assert.AreEqual(3, slice.Parts[0].Normals.Count);
        }

        [TestMethod]
        public void AddNotConnectedSection()
        {
            slice.AddSection(Vector3.Zero, Vector3.UnitX);
            slice.AddSection(Vector3.UnitY, Vector3.UnitY + Vector3.UnitY);

            Assert.AreEqual(2, slice.Parts.Count);
            Assert.AreEqual(2, slice.Parts[0].Points.Count);
            Assert.AreEqual(2, slice.Parts[0].Normals.Count);
            Assert.AreEqual(2, slice.Parts[1].Points.Count);
            Assert.AreEqual(2, slice.Parts[1].Normals.Count);
        }

        [TestMethod]
        public void JoinNotClose()
        {
            slice.AddSection(Vector3.Zero, Vector3.UnitX);
            slice.AddSection(Vector3.UnitY + Vector3.UnitX, Vector3.UnitY);
            slice.AddSection(Vector3.UnitY, Vector3.Zero);

            Assert.AreEqual(2, slice.Parts.Count);
            Assert.AreEqual(3, slice.Parts[0].Points.Count);
            Assert.AreEqual(2, slice.Parts[1].Points.Count);

            slice.Join();
            Assert.AreEqual(1, slice.Parts.Count);
            Assert.AreEqual(4, slice.Parts[0].Points.Count);
            Assert.IsFalse(slice.Parts[0].Closed);
        }

        [TestMethod]
        public void JoinClose()
        {
            slice.AddSection(Vector3.Zero, Vector3.UnitX);
            slice.AddSection(Vector3.UnitY + Vector3.UnitX, Vector3.UnitY);
            slice.AddSection(Vector3.UnitY, Vector3.Zero);
            slice.AddSection(Vector3.UnitX, Vector3.UnitY + Vector3.UnitX);

            Assert.AreEqual(2, slice.Parts.Count);
            Assert.AreEqual(4, slice.Parts[0].Points.Count);
            Assert.AreEqual(2, slice.Parts[1].Points.Count);

            slice.Join();
            Assert.AreEqual(1, slice.Parts.Count);
            Assert.AreEqual(4, slice.Parts[0].Points.Count);
            Assert.IsTrue(slice.Parts[0].Closed);
        }

        [TestMethod]
        public void Simplify()
        {
            slice.AddSection(Vector3.Zero, Vector3.UnitX);
            slice.AddSection(Vector3.UnitX, Vector3.UnitX * 2);
            slice.AddSection(Vector3.UnitX * 2, Vector3.UnitY);
            slice.AddSection(Vector3.UnitY, Vector3.Zero);

            slice.AddSection(Vector3.Zero, Vector3.UnitX);
            slice.AddSection(Vector3.UnitX, Vector3.UnitX * 2);
            slice.AddSection(Vector3.UnitX * 2, Vector3.UnitY);

            Assert.AreEqual(2, slice.Parts.Count);
            Assert.AreEqual(4, slice.Parts[0].Points.Count);
            Assert.AreEqual(4, slice.Parts[1].Points.Count);

            slice.Simplify(1e-4f);

            Assert.AreEqual(2, slice.Parts.Count);
            Assert.AreEqual(3, slice.Parts[0].Points.Count);
            Assert.AreEqual(3, slice.Parts[1].Points.Count);
        }

        [TestMethod]
        public void GetDimensionsTest()
        {
            slice.AddSection(Vector3.UnitX * -1, Vector3.UnitX);
            slice.AddSection(Vector3.UnitX, Vector3.UnitY);
            slice.AddSection(Vector3.UnitY, Vector3.UnitX * -1);

            slice.AddSection(Vector3.Zero, Vector3.UnitX);
            slice.AddSection(Vector3.UnitX * 2, Vector3.UnitY * 3);

            ObjectDimensions dimensions = slice.GetDimensions();

            Assert.IsNotNull(dimensions);
            Assert.AreEqual(new Vector3(-1f, 0f, 0f), dimensions.MinPoint);
            Assert.AreEqual(new Vector3(2f, 3f, 0f), dimensions.MaxPoint);
        }


        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void GetDimensionsEmptyTest()
        {
            slice.GetDimensions();
        }
    }
}
