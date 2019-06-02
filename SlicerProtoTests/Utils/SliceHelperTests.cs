using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SlicerProto.ObjectModel;
using SlicerProto.Utils;
using OpenTK;

namespace SlicerProto.Utils.Tests
{
    [TestClass]
    public class SliceHelperTests
    {
        [TestMethod]
        public void GetPlanePositionTest()
        {
            Facet facet = new Facet()
            {
                Vx1 = new Vector3(0f, 0f, 0f),
                Vx2 = new Vector3(1f, -1f, 1f),
                Vx3 = new Vector3(-1f, 1f, -1f)
            };

            Assert.AreEqual(PlanePosition.Above, facet.GetPlanePosition(-2f));
            Assert.AreEqual(PlanePosition.Intersect, facet.GetPlanePosition(-1f));
            Assert.AreEqual(PlanePosition.Intersect, facet.GetPlanePosition(0f));
            Assert.AreEqual(PlanePosition.Below, facet.GetPlanePosition(1f));
            Assert.AreEqual(PlanePosition.Below, facet.GetPlanePosition(2f));
        }

        [TestMethod]
        public void GetSectionsTest()
        {
            Facet facet = new Facet()
            {
                Normal = Vector3.UnitX,
                Vx1 = new Vector3(0f, 1f, 0f),
                Vx2 = new Vector3(0f, -1f, 0f),
                Vx3 = new Vector3(0f, 0f, 1f)
            };

            List<Facet> sections = facet.GetSections(0.5f).ToList();

            Assert.AreEqual(2, sections.Count);

            Assert.AreEqual(Vector3.UnitX, sections[0].Normal);
            Assert.AreEqual(new Vector3(0f, 1f, 0f), sections[0].Vx1);
            Assert.AreEqual(new Vector3(0f, -1f, 0f), sections[0].Vx2);
            Assert.AreEqual(new Vector3(0f, -0.5f, 0.5f), sections[0].Vx3);

            Assert.AreEqual(Vector3.UnitX, sections[1].Normal);
            Assert.AreEqual(new Vector3(0f, 1f, 0f), sections[1].Vx1);
            Assert.AreEqual(new Vector3(0f, -0.5f, 0.5f), sections[1].Vx2);
            Assert.AreEqual(new Vector3(0f, 0.5f, 0.5f), sections[1].Vx3);

            facet = new Facet()
            {
                Normal = Vector3.UnitX,
                Vx1 = new Vector3(0f, 1f, 1f),
                Vx2 = new Vector3(0f, -1f, 1f),
                Vx3 = new Vector3(0f, 0f, 0f)
            };

            sections = facet.GetSections(0.5f).ToList();

            Assert.AreEqual(1, sections.Count);

            Assert.AreEqual(Vector3.UnitX, sections[0].Normal);
            Assert.AreEqual(new Vector3(0f, -0.5f, 0.5f), sections[0].Vx1);
            Assert.AreEqual(new Vector3(0f, 0f, 0f), sections[0].Vx2);
            Assert.AreEqual(new Vector3(0f, 0.5f, 0.5f), sections[0].Vx3);
        }

        [TestMethod]
        public void GetDistanceToLine()
        {
            float distance = Vector3.Zero.GetDistanceToLine(Vector3.Zero, Vector3.Zero);
            Assert.AreEqual(0f, distance, 1e-5);

            distance = Vector3.Zero.GetDistanceToLine(Vector3.Zero, Vector3.UnitX);
            Assert.AreEqual(0f, distance, 1e-5);

            distance = Vector3.UnitX.GetDistanceToLine(Vector3.Zero, Vector3.UnitX);
            Assert.AreEqual(0f, distance, 1e-5);

            distance = Vector3.UnitX.GetDistanceToLine(Vector3.Zero, Vector3.UnitX * 2);
            Assert.AreEqual(0f, distance, 1e-5);

            distance = Vector3.UnitX.GetDistanceToLine(Vector3.Zero, Vector3.Zero);
            Assert.IsTrue(float.IsNaN(distance));

            distance = Vector3.UnitY.GetDistanceToLine(Vector3.Zero, Vector3.UnitX);
            Assert.AreEqual(1f, distance, 1e-5);
        }
    }
}