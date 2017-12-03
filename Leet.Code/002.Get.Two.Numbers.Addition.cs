using System.Collections.Generic;

namespace Leet.Code
{

    public class _002GetTwoNumbersAddition
    {

        public class ListNode 
        {
          public int Data;
          public ListNode Next;
          public ListNode(int x) { Data = x; }
        }

        public static void Answer()
        {
            var l1 = new ListNode(2) {Next = new ListNode(4) {Next = new ListNode(3)}};
            var l2 = new ListNode(5) {Next = new ListNode(6) {Next = new ListNode(4)}};

            l1 = new ListNode(1);
            l2 = new ListNode(9) { Next = new ListNode(9) };

            var output = GetTwoNumbersAddition(l1, l2);
        }

        public static ListNode InsertListNode(ListNode head, int data)
        {
            if (head == null) return new ListNode(data);
            var curr = head;
            var temp = new ListNode(data);
            while (curr.Next != null)
                curr = curr.Next;
            curr.Next = temp;
            return head;
        }

        private static ListNode GetTwoNumbersAddition(ListNode l1, ListNode l2 )
        {
            var isUpper = false;
            var output = (ListNode) null;
            while (l1 != null && l2 != null)
            {
                var temp = l1.Data + l2.Data + (isUpper ? 1 : 0);
                if (temp >= 10)
                {
                    temp -= 10;
                    isUpper = true;
                }
                else isUpper = false;
                output = InsertListNode(output, temp);
                l1 = l1.Next;
                l2 = l2.Next;
            }
            while (l1 != null)
            {
                var temp = l1.Data + (isUpper ? 1 : 0);
                if (temp >= 10)
                {
                    temp -= 10;
                    isUpper = true;
                }
                else isUpper = false;
                output = InsertListNode(output, temp);
                l1 = l1.Next;
            }
            while (l2 != null)
            {
                var temp = l2.Data + (isUpper ? 1 : 0);
                if (temp >= 10)
                {
                    temp -= 10;
                    isUpper = true;
                }
                else isUpper = false;
                output = InsertListNode(output, temp);
                l2 = l2.Next;
            }
            if (isUpper) output = InsertListNode(output, 1);
            return output;
        }

    }

}
