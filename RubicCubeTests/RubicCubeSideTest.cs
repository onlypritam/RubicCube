using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubic3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubic3.Tests
{
    [TestClass()]
    public class RubicCubeSideTest
    {
        [TestMethod()]
        public void RotateRightTest()
        {
            RubicCubeSide RCSide = new RubicCubeSide(1, 2, 3, 4, 5, 6, 7, 8, 9);
            RCSide.RotateRight();

            Assert.AreEqual(RCSide.TopRow[0], 7);
            Assert.AreEqual(RCSide.TopRow[1], 4);
            Assert.AreEqual(RCSide.TopRow[2], 1);

            Assert.AreEqual(RCSide.MiddleRow[0], 8);
            Assert.AreEqual(RCSide.MiddleRow[1], 5);
            Assert.AreEqual(RCSide.MiddleRow[2], 2);

            Assert.AreEqual(RCSide.BottomRow[0], 9);
            Assert.AreEqual(RCSide.BottomRow[1], 6);
            Assert.AreEqual(RCSide.BottomRow[2], 3);
        }

        [TestMethod()]
        public void RotateLeftTest()
        {
            RubicCubeSide RCSide = new RubicCubeSide(1, 2, 3, 4, 5, 6, 7, 8, 9);
            RCSide.RotateLeft();

            Assert.AreEqual(RCSide.TopRow[0], 3);
            Assert.AreEqual(RCSide.TopRow[1], 6);
            Assert.AreEqual(RCSide.TopRow[2], 9);

            Assert.AreEqual(RCSide.MiddleRow[0], 2);
            Assert.AreEqual(RCSide.MiddleRow[1], 5);
            Assert.AreEqual(RCSide.MiddleRow[2], 8);

            Assert.AreEqual(RCSide.BottomRow[0], 1);
            Assert.AreEqual(RCSide.BottomRow[1], 4);
            Assert.AreEqual(RCSide.BottomRow[2], 7);
        }

    }
}
