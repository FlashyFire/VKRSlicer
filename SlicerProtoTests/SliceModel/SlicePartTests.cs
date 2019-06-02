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
    public class SlicePartTests
    {
        SlicePart part;

        [TestInitialize]
        public void Initialize()
        {
            part = new SlicePart();
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
            Assert.AreEqual(0, part.Normals.Count);
            Assert.IsFalse(part.Closed);
        }

        [TestMethod]
        public void AddFirstSection()
        {
            Assert.IsTrue(part.AddSection(Vector3.Zero, Vector3.UnitX, Vector3.UnitY));
            Assert.AreEqual(2, part.Points.Count);
            Assert.AreEqual(2, part.Normals.Count);
            Assert.AreEqual(Vector3.Zero, part.Points[0]);
            Assert.AreEqual(Vector3.UnitX, part.Points[1]);
            Assert.AreEqual(Vector3.UnitY, part.Normals[0]);
            Assert.AreEqual(Vector3.UnitY, part.Normals[1]);
            Assert.IsFalse(part.Closed);
        }

        [TestMethod]
        public void AddNextSectionToStart()
        {
            Assert.IsTrue(part.AddSection(Vector3.Zero, Vector3.UnitX, Vector3.UnitY));
            Assert.IsTrue(part.AddSection(Vector3.UnitY, Vector3.Zero, Vector3.One));
            Assert.AreEqual(3, part.Points.Count);
            Assert.AreEqual(3, part.Normals.Count);
            Assert.AreEqual(Vector3.UnitY, part.Points[0]);
            Assert.AreEqual(Vector3.Zero, part.Points[1]);
            Assert.AreEqual(Vector3.UnitX, part.Points[2]);
            Assert.AreEqual(Vector3.One, part.Normals[0]);
            Assert.AreEqual(Vector3.UnitY, part.Normals[1]);
            Assert.AreEqual(Vector3.UnitY, part.Normals[2]);
            Assert.IsFalse(part.Closed);
        }

        [TestMethod]
        public void AddNextSectionToEnd()
        {
            Assert.IsTrue(part.AddSection(Vector3.Zero, Vector3.UnitX, Vector3.UnitY));
            Assert.IsTrue(part.AddSection(Vector3.UnitX, Vector3.UnitY, Vector3.One));
            Assert.AreEqual(3, part.Points.Count);
            Assert.AreEqual(3, part.Normals.Count);
            Assert.AreEqual(Vector3.Zero, part.Points[0]);
            Assert.AreEqual(Vector3.UnitX, part.Points[1]);
            Assert.AreEqual(Vector3.UnitY, part.Points[2]);
            Assert.AreEqual(Vector3.UnitY, part.Normals[0]);
            Assert.AreEqual(Vector3.One, part.Normals[1]);
            Assert.AreEqual(Vector3.One, part.Normals[2]);
            Assert.IsFalse(part.Closed);
        }

        [TestMethod]
        public void AddSectionToStartAndClose()
        {
            Assert.IsTrue(part.AddSection(Vector3.Zero, Vector3.UnitX));
            Assert.IsTrue(part.AddSection(Vector3.UnitY, Vector3.Zero));
            Assert.IsTrue(part.AddSection(Vector3.UnitX, Vector3.UnitY));
            Assert.AreEqual(3, part.Points.Count);
            Assert.AreEqual(Vector3.UnitY, part.Points[0]);
            Assert.AreEqual(Vector3.Zero, part.Points[1]);
            Assert.AreEqual(Vector3.UnitX, part.Points[2]);
            Assert.IsTrue(part.Closed);
        }

        [TestMethod]
        public void AddSectionToEndAndClose()
        {
            Assert.IsTrue(part.AddSection(Vector3.Zero, Vector3.UnitX));
            Assert.IsTrue(part.AddSection(Vector3.UnitX, Vector3.UnitY));
            Assert.IsTrue(part.AddSection(Vector3.UnitY, Vector3.Zero));
            Assert.AreEqual(3, part.Points.Count);
            Assert.AreEqual(Vector3.Zero, part.Points[0]);
            Assert.AreEqual(Vector3.UnitX, part.Points[1]);
            Assert.AreEqual(Vector3.UnitY, part.Points[2]);
            Assert.IsTrue(part.Closed);
        }

        [TestMethod]
        public void TryAddSectionToClosed()
        {
            Assert.IsTrue(part.AddSection(Vector3.Zero, Vector3.UnitX));
            Assert.IsTrue(part.AddSection(Vector3.UnitX, Vector3.UnitY));
            Assert.IsTrue(part.AddSection(Vector3.UnitY, Vector3.Zero));
            Assert.IsTrue(part.Closed);

            Assert.IsFalse(part.AddSection(Vector3.Zero, Vector3.UnitY));
        }

        [TestMethod]
        public void TryAddNotConnectedSection()
        {
            Assert.IsTrue(part.AddSection(Vector3.Zero, Vector3.UnitX));
            Assert.IsFalse(part.AddSection(Vector3.UnitZ, Vector3.UnitY));
        }

        [TestMethod]
        public void TryAddSectionInnerPoint()
        {
            Assert.IsTrue(part.AddSection(Vector3.Zero, Vector3.UnitX));
            Assert.IsTrue(part.AddSection(Vector3.UnitX, Vector3.UnitY));
            Assert.IsFalse(part.AddSection(Vector3.UnitX, Vector3.UnitZ));
        }

        [TestMethod]
        public void JoinToStartNotClose()
        {
            part.AddSection(Vector3.Zero, Vector3.UnitX);
            part.AddSection(Vector3.UnitX, Vector3.UnitY);

            SlicePart other = new SlicePart();
            other.AddSection(Vector3.UnitY * 2, Vector3.Zero);

            Assert.IsTrue(part.Join(other));

            Assert.AreEqual(4, part.Points.Count);
            Assert.AreEqual(Vector3.UnitY * 2, part.Points[0]);
            Assert.AreEqual(Vector3.Zero, part.Points[1]);
            Assert.AreEqual(Vector3.UnitX, part.Points[2]);
            Assert.AreEqual(Vector3.UnitY, part.Points[3]);
            Assert.IsFalse(part.Closed);
        }

        [TestMethod]
        public void JoinToEndNotClose()
        {
            part.AddSection(Vector3.Zero, Vector3.UnitX, Vector3.UnitY);
            part.AddSection(Vector3.UnitX, Vector3.UnitY, Vector3.UnitZ);

            SlicePart other = new SlicePart();
            other.AddSection(Vector3.UnitY, Vector3.UnitY * 2, Vector3.One);

            Assert.IsTrue(part.Join(other));

            Assert.AreEqual(4, part.Points.Count);
            Assert.AreEqual(Vector3.Zero, part.Points[0]);
            Assert.AreEqual(Vector3.UnitX, part.Points[1]);
            Assert.AreEqual(Vector3.UnitY, part.Points[2]);
            Assert.AreEqual(Vector3.UnitY * 2, part.Points[3]);
            Assert.AreEqual(4, part.Normals.Count);
            Assert.AreEqual(Vector3.UnitY, part.Normals[0]);
            Assert.AreEqual(Vector3.UnitZ, part.Normals[1]);
            Assert.AreEqual(Vector3.One, part.Normals[2]);
            Assert.AreEqual(Vector3.One, part.Normals[3]);
            Assert.IsFalse(part.Closed);
        }

        [TestMethod]
        public void JoinAndClose()
        {
            part.AddSection(Vector3.Zero, Vector3.UnitX, Vector3.UnitY);
            part.AddSection(Vector3.UnitX, Vector3.UnitY, Vector3.UnitZ);

            SlicePart other = new SlicePart();
            other.AddSection(Vector3.UnitY, Vector3.Zero, Vector3.One);

            Assert.IsTrue(part.Join(other));

            Assert.AreEqual(3, part.Points.Count);
            Assert.AreEqual(Vector3.Zero, part.Points[0]);
            Assert.AreEqual(Vector3.UnitX, part.Points[1]);
            Assert.AreEqual(Vector3.UnitY, part.Points[2]);
            Assert.AreEqual(3, part.Normals.Count);
            Assert.AreEqual(Vector3.UnitY, part.Normals[0]);
            Assert.AreEqual(Vector3.UnitZ, part.Normals[1]);
            Assert.AreEqual(Vector3.One, part.Normals[2]);
            Assert.IsTrue(part.Closed);
        }

        [TestMethod]
        public void TryJoinWithClosed()
        {
            part.AddSection(Vector3.Zero, Vector3.UnitX);
            part.AddSection(Vector3.UnitX, Vector3.UnitY);
            part.AddSection(Vector3.UnitY, Vector3.Zero);

            SlicePart other = new SlicePart();
            other.AddSection(Vector3.Zero, Vector3.UnitX * 2);

            Assert.IsFalse(part.Join(other));
        }

        [TestMethod]
        public void TryJoinNotConnected()
        {
            part.AddSection(Vector3.Zero, Vector3.UnitX);
            part.AddSection(Vector3.UnitX, Vector3.UnitY);

            SlicePart other = new SlicePart();
            other.AddSection(Vector3.UnitX * 2, Vector3.UnitX * 3);

            Assert.IsFalse(part.Join(other));
        }

        [TestMethod]
        public void TryJoinToMidPoint()
        {
            part.AddSection(Vector3.Zero, Vector3.UnitX);
            part.AddSection(Vector3.UnitX, Vector3.UnitY);

            SlicePart other = new SlicePart();
            other.AddSection(Vector3.UnitX, Vector3.UnitX * 3);

            Assert.IsFalse(part.Join(other));
        }

        [TestMethod]
        public void SimplifyNotClosed()
        {
            part.AddSection(Vector3.Zero, Vector3.UnitX);
            part.AddSection(Vector3.UnitX, Vector3.UnitX * 2);
            part.AddSection(Vector3.UnitX * 2, Vector3.UnitY);

            Assert.AreEqual(4, part.Points.Count);
            Assert.IsFalse(part.Closed);

            part.Simplify(1e-4f);

            Assert.AreEqual(3, part.Points.Count);
            Assert.AreEqual(Vector3.Zero, part.Points[0]);
            Assert.AreEqual(Vector3.UnitX * 2, part.Points[1]);
            Assert.AreEqual(Vector3.UnitY, part.Points[2]);
            Assert.IsFalse(part.Closed);
        }

        [TestMethod]
        public void SimplifyClosed()
        {
            part.AddSection(Vector3.Zero, Vector3.UnitX);
            part.AddSection(Vector3.UnitX, Vector3.UnitX * 2);
            part.AddSection(Vector3.UnitX * 2, Vector3.UnitY);
            part.AddSection(Vector3.UnitY, Vector3.Zero);

            Assert.AreEqual(4, part.Points.Count);
            Assert.IsTrue(part.Closed);

            part.Simplify(1e-4f);

            Assert.AreEqual(3, part.Points.Count);
            Assert.AreEqual(Vector3.Zero, part.Points[0]);
            Assert.AreEqual(Vector3.UnitX * 2, part.Points[1]);
            Assert.AreEqual(Vector3.UnitY, part.Points[2]);
            Assert.IsTrue(part.Closed);
        }

        [TestMethod]
        public void SimplifyNotClosedMinPointsCount()
        {
            part.AddSection(Vector3.Zero, Vector3.UnitX);
            Assert.AreEqual(2, part.Points.Count);
            Assert.IsFalse(part.Closed);

            part.Simplify(1e-4f);
            Assert.AreEqual(2, part.Points.Count);
            Assert.IsFalse(part.Closed);
        }

        [TestMethod]
        public void SimplifyClosedMinPointsCount()
        {
            part.AddSection(Vector3.Zero, Vector3.UnitX);
            part.AddSection(Vector3.UnitX, Vector3.UnitY);
            part.AddSection(Vector3.UnitY, Vector3.Zero);

            Assert.AreEqual(3, part.Points.Count);
            Assert.IsTrue(part.Closed);

            part.Simplify(1e-4f);

            Assert.AreEqual(3, part.Points.Count);
            Assert.IsTrue(part.Closed);
        }

        [TestMethod]
        public void GetDimensionsTest()
        {
            part.AddSection(Vector3.Zero, Vector3.UnitX);
            part.AddSection(Vector3.UnitX, Vector3.UnitY);
            part.AddSection(Vector3.UnitY, Vector3.Zero);

            ObjectDimensions dimensions = part.GetDimensions();

            Assert.IsNotNull(dimensions);
            Assert.AreEqual(Vector3.Zero, dimensions.MinPoint);
            Assert.AreEqual(new Vector3(1f, 1f, 0f), dimensions.MaxPoint);
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void GetDimensionsEmptyTest()
        {
            part.GetDimensions();
        }
    }
}
