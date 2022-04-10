using FacebookInterview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiddleOfANodeTest
{
    [TestClass]
    public class BinaryTreeTest
    {
        [TestMethod]
        public void Test_MiddleOfANode()
        {
            var test = new MiddleNode();
            
            Assert.AreEqual(test.FindMiddle(), 3);
        }

        [TestMethod]
        public void Test_BinaryTree()
        {
            var test = new BinaryTree();
            var sut = test.LevelOrderBottom();

            Assert.AreEqual(sut.Count, 4);
        }
    }
}
