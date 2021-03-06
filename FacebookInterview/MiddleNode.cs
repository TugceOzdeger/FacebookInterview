using System;
using System.Collections.Generic;
using System.Linq;

namespace FacebookInterview
{
    public class MiddleNode
    {
        /*Input: [1,2,3,4,5]
        Output: Node 3 from this list (Serialization: [3,4,5])
        The returned node has value 3.  (The judge's serialization of this node is [3,4,5]).
        Note that we returned a ListNode object ans, such that:
        ans.val = 3, ans.next.val = 4, ans.next.next.val = 5, and ans.next.next.next = NULL.*/

        /*Input: [1,2,3,4,5,6]
        Output: Node 4 from this list (Serialization: [4,5,6])
        Since the list has two middle nodes with values 3 and 4, we return the second one.*/

        static LinkedListNode<int> myList = new LinkedListNode<int>(3);
        static LinkedList<int> myLinkedList = new LinkedList<int>();

        public int FindMiddle()
        {
            SetData();
            var result = FindIndexAndMiddleOfANode(myList);
            Console.WriteLine(result);
            Console.WriteLine();
            return result;
        }

        private void SetData()
        {
            myLinkedList.AddLast(myList);
            myLinkedList.AddFirst(1);
            myLinkedList.AddLast(2);
            myLinkedList.AddFirst(4);
            myLinkedList.AddLast(5);
        }

        private int FindIndexAndMiddleOfANode(LinkedListNode<int> linkedListNode)
        {
            var index = linkedListNode.List.Count % 2 == 0 ? linkedListNode.List.Count / 2
                                                           : (linkedListNode.List.Count - 1) / 2;
           
            return linkedListNode.List.ToArray()[index];
        }
    }
}
