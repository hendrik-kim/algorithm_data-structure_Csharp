namespace Algorithm_DataStructure_Csharp
{

    public class AddTwoNumbers
    {
        public ListNode AddTwoNumbersSln(ListNode l1, ListNode l2)
        {
            ListNode prev = new ListNode(0);
            ListNode p = l1, q = l2, curr = prev;
            int carry = 0;

            while (p != null || q != null)
            {
                int x = (p != null) ? p.val : 0;
                int y = (q != null) ? q.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }

            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }

            return prev.next;
        }

        public static void _Main(string[] args)
        {
            ListNode list_1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
            ListNode list_2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));

            AddTwoNumbers addTwoNumbers = new AddTwoNumbers();
            addTwoNumbers.AddTwoNumbersSln(list_1, list_2);
        }
    }
}