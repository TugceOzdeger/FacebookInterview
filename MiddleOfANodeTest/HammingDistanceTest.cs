using FacebookInterview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NodeBinaryTreeTest
{
    [TestClass]
    public class HammingDistanceTest
    {
        [TestMethod]
        public void Test_HammingDistance_2Difference()
        {
            var test = new HammingDistance();
            var sut = test.FindDistance(4,1);

            Assert.AreEqual(sut, 2);
        }

        [TestMethod]
        public void Test_HammingDistance_NoDifference()
        {
            var test = new HammingDistance();
            var sut = test.FindDistance(4,4);

            Assert.AreEqual(sut, 0);
        }

        [TestMethod]
        public void Test_HammingDistance_3Difference()
        {
            var test = new HammingDistance();
            var sut = test.FindDistance(15,1);

            Assert.AreEqual(sut, 3);
        }
    }
}
