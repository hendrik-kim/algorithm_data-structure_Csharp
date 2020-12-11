using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_DataStructure_Csharp
{
    class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class MergeTwoSortedList
    {
        public ListNode mergeTowLists(ListNode l1, ListNode l2)
        {
            var prehead = new ListNode(-1);
            var prev = prehead;

            while(l1 != null && l2 != null)
            {
                if(l1.val <= l2.val)
                {
                    prev.next = l1;
                    l1 = l1.next;
                }else
                {
                    prev.next = l2;
                    l2 = l2.next;
                }
                prev = prev.next;
            }

            prev.next = l1 == null ? l2 : l1;

            return prehead.next;
        }
    }

    static void Main(string[] args)
    {

    }
}
