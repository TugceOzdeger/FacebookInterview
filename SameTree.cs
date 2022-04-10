namespace FacebookInterview
{
    public class SameTree
    {
        public TreeNode p { get; set; }
        public TreeNode q { get; set; }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
         }

        public bool IsSameTree()
        {
            //Check first if they have same height
            if (FindHeight(p) != FindHeight(q) || FindHeight(p, true) != FindHeight(q, true))
                return false;
            else
            {

                //Iterate each level
                if (p.val == q.val)
                {
                    if (p.left.val == q.left.val)
                    {
                        if (p.right.val == q.right.val)
                        {
                            return true;
                        }
                        return false;
                    }
                    return false;
                }
                return false;
            }
        }

        private int FindHeight(TreeNode node, bool isLeft = false)
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
    }
}
