using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
    }

    public class _2_AddTwoNumbers
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode resultNode = null;
            ListNode currentNode = null;
            int carry = 0;

            while (l1 != null || l2 != null)
            {
                int sum = 0;
                if (l1 != null) { sum += l1.val; l1 = l1.next; }
                if (l2 != null) { sum += l2.val; l2 = l2.next; }

                sum += carry;

                if (sum >= 10) carry = 1;
                else carry = 0;

                var node = new ListNode(sum % 10);
                if (resultNode == null) { resultNode = node; currentNode = node; }
                else { currentNode.next = node; currentNode = node; }
            }


            if (carry == 1)
            {
                var node = new ListNode(carry);
                currentNode.next = node; currentNode = node;
            }

            return resultNode;
        }

        public static void Solution()
        {
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(5);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(2);
            l2.next.next = new ListNode(4);


            var output = AddTwoNumbers(l1, l2);
            Console.WriteLine(output);
            
        }
    }
}
