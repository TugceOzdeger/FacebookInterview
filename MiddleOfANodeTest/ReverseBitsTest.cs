using FacebookInterview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NodeBinaryTreeTest
{
    [TestClass]
    public class ReverseBitsTest
    {
        [TestMethod]
        public void Test_ReverseBits_ReverseBinaryStrings()
        {
            var test = new ReverseBits();
            var sut = test.ReverseBinaryStrings();

            Assert.AreEqual(sut, "00111001011110000010100101000000");
        }

        [TestMethod]
        public void Test_ReverseBits_ReverseBinaryToInteger()
        {
            var test = new ReverseBits();
            var sut = test.ReverseBinaryToInteger();

            Assert.AreEqual(sut, 69516234);
        }

        [TestMethod]
        public void Test_IsDuplicate()
        {
            var test = new ReverseBits();
            var sut = test.IsDuplicate(5);

            Assert.IsTrue(sut);
        }
    }
}
