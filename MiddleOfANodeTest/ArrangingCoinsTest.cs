using FacebookInterview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NodeBinaryTreeTest
{
    [TestClass]
    public class ArrangingCoinsTest
    {
        [TestMethod]
        public void Test_Arrange_8_Coins()
        {
            var test = new ArrangingCoins();
            var sut = test.ArrangeCoins(8);
            Assert.AreEqual(sut, 3);
        }

        [TestMethod]
        public void Test_Arrange_5_Coins()
        {
            var test = new ArrangingCoins();
            var sut = test.ArrangeCoins(5);
            Assert.AreEqual(sut, 2);
        }

    }
}
