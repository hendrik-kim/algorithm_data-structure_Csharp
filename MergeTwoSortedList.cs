using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_DataStructure_Csharp
{
    //class ListNode
    //{
    //    public int val;
    //    public ListNode next;
    //    public ListNode(int val = 0, ListNode next = null)
    //    {
    //        this.val = val;
    //        this.next = next;
    //    }
    //}

    public class MergeTwoSortedList
    {
        public ListNode mergeTowLists(ListNode l1, ListNode l2)
        {
            var prehead = new ListNode(-1);
            var prev = prehead;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    prev.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    prev.next = l2;
                    l2 = l2.next;
                }
                prev = prev.next;
            }

            prev.next = l1 == null ? l2 : l1;

            return prehead.next;
        }
        static void Main(string[] args)
        {
            var list_1 = new ListNode(2, new ListNode(4, new ListNode(3, new ListNode(9, new ListNode(11, new ListNode(14, null))))));
            var list_2 = new ListNode(5, new ListNode(6, new ListNode(7, null)));

            var mergeTwoList = new MergeTwoSortedList().mergeTowLists(list_1, list_2);

            Console.WriteLine(mergeTwoList);
        }
    }
}
