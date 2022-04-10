using FacebookInterview;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NodeBinaryTreeTest
{
    [TestClass]
    public class PrisonCellTest
    {
        [TestMethod]
        public void Test_PrisonCells()
        {
            var test = new PrisonCell();
            var sut = test.PrisonAfterNDays();

            Assert.AreEqual(sut[0], 0);
            Assert.AreEqual(sut[1], 1);
            Assert.AreEqual(sut[2], 1);
            Assert.AreEqual(sut[3], 0);
            Assert.AreEqual(sut[4], 0);
            Assert.AreEqual(sut[5], 0);
            Assert.AreEqual(sut[6], 0);
            Assert.AreEqual(sut[7], 0);
        }

        [TestMethod]
        public void Test_Find_Ugly_Numbers()
        {
            var expectedList = new List<int> { 1, 2, 3, 4, 5, 6, 8, 9, 10, 12 };
            var sut = new PrisonCell();
            var list = sut.FindUglyNumber(10);
            CollectionAssert.AreEqual(list, expectedList);
        }
    }
}
