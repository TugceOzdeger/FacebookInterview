using System.Collections.Generic;
using System.Linq;

namespace FacebookInterview
{
    public class MultilevelDoublyLinkedList
    {
        /*Input: head = [1,2,3,4,5,6,null,null,null,7,8,9,10,null,null,11,12]
           Output: [1,2,3,7,8,11,12,9,10,4,5,6]*/

        List<int> list = new List<int>();
        List<Node> nodeList = new List<Node>();

        public class Node
        {
            public int val;
            public Node prev;
            public Node next;
            public Node child;
        }

        public List<int> Flatten()
        {
            CreateNode();
            for(var item = 0; item < nodeList.Count; item++)
            {
                var node = nodeList.ElementAt(item);
                list.Add(node.val);
                if (node.child != null)
                {
                    list.Add(node.child.val);
                }
            }
            return list;
        }

        public void CreateNode()
        {
            list = new List<int>{1, 2, 3, 4, 5, 6, 0, 0, 0, 7, 8, 9, 10, 0, 0, 11, 12};

            for (var item = 0; item < list.Count; item++)
            {
                var node = new Node();
                
                if (item != 0)
                {
                    node.val = list.ElementAt(item);                  
                    node.next = new Node
                    {
                        val = list.ElementAt(item + 1)
                    };
                    if (item > 0)
                    node.prev = new Node
                    {
                        val = list.ElementAt(item - 1)
                    };                   
                }
                else
                {
                    node.child = new Node
                    {
                        val = list.ElementAt(item)
                    };
                }
            }

       
        }
    }
}
