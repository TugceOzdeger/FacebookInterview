using FacebookInterview;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static FacebookInterview.SameTree;

namespace NodeBinaryTreeTest
{

    [TestClass]
    public class SameTreeTest
    {
        public SameTree SetData_123()
        {
            var tree = new SameTree
            {
                p = new TreeNode
                {
                    val = 1,
                    left = new TreeNode(),
                    right = new TreeNode()
                }
            };
            tree.p.left.val = 2;
            tree.p.right.val = 3;

            tree.q = new TreeNode
            {
                val = 1,
                left = new TreeNode(),
                right = new TreeNode()
            };
            tree.q.left.val = 2;
            tree.q.right.val = 3;

            return tree;
        }

        public SameTree SetData_12()
        {
            var tree = new SameTree
            {
                p = new TreeNode
                {
                    val = 1,
                    left = new TreeNode(),
                    right = new TreeNode()
                }
            };
            tree.p.left.val = 2;

            tree.q = new TreeNode
            {
                val = 1,
                left = new TreeNode(),
                right = new TreeNode()
            };
            tree.q.right.val = 2;

            return tree;
        }

        public SameTree SetData_121()
        {
            var tree = new SameTree
            {
                p = new TreeNode
                {
                    val = 1,
                    left = new TreeNode(),
                    right = new TreeNode()
                }
            };
            tree.p.left.val = 2;
            tree.p.right.val = 1;

            tree.q = new TreeNode
            {
                val = 1,
                left = new TreeNode(),
                right = new TreeNode()
            };
            tree.q.left.val = 1;
            tree.q.right.val = 2;

            return tree;
        }

        [TestMethod]
        public void Test_SameTree()
        {
            var sut = SetData_123();
            Assert.IsTrue(sut.IsSameTree());
            sut = SetData_12();
            Assert.IsFalse(sut.IsSameTree());
            sut = SetData_121();
            Assert.IsFalse(sut.IsSameTree());
        }
    }
}
