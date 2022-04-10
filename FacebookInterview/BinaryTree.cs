using System.Collections.Generic;

namespace FacebookInterview
{
    public class BinaryTree
    {
       public int val;
       public BinaryTree left;
       public BinaryTree right;

       public BinaryTree(int val=0, BinaryTree left=null, BinaryTree right=null)
       {
            this.val = val;
            this.left = left;
            this.right = right;
       }

        public IList<IList<int>> LevelOrderBottom()
        {
            var result = new List<IList<int>>();
            var tree = CreateBinaryTree();
            
            result.Add(new List<int> { tree.val } );
            result.Add(new List<int> { tree.left.val, tree.right.val });
         
            var heightLeft = FindHeight(tree.left, true);
            var heightRight = FindHeight(tree.right, false);

            var searchLeft = tree.left.left;
            var searchRight = tree.left.right;

            for (var aa = 0; aa < heightLeft; aa++)
            {
                CreateTree(searchLeft, searchRight, result);
                searchLeft = searchLeft?.left;
                searchRight = searchLeft?.right;
            }

            searchLeft = tree.right.left;
            searchRight = tree.right.right;

            for (var aa = 0; aa < heightRight; aa++)
            {
                CreateTree(searchLeft, searchRight, result);
                searchLeft = searchRight?.left;
                searchRight = searchRight?.right;
            }

            return result;
        }

        private void CreateTree(BinaryTree searchLeft, BinaryTree searchRight, List<IList<int>> result)
        {
            if (searchLeft != null && searchRight != null)
                result.Add(new List<int> { searchLeft.val, searchRight.val });
            else if (searchLeft == null)
                result.Add(new List<int> { searchRight.val });
            else
                result.Add(new List<int> { searchLeft.val });
        }

        private int FindHeight(BinaryTree node, bool isLeft = false)
        {
            var height = 0;

            if (isLeft)
            {
                var result = node?.left;

                while (result != null)
                {
                    height++;
                    result = result?.left ?? result?.right;
                }
            }
            else
            {
                var result = node?.right;

                while (result != null)
                {
                    height++;
                    result = result?.right ?? result?.left;
                }
            }

            return height;
        }

        private BinaryTree CreateBinaryTree()
        {
            /*Given binary tree [3,9,20,null,null,15,7]*/
            return new BinaryTree(3, new BinaryTree(9,null,null), new BinaryTree(20,
                new BinaryTree(15, null, null), new BinaryTree(7,new BinaryTree(6,null,null),null)));
        }
    }
}
