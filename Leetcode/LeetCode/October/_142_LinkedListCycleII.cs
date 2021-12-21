using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.October
{
	public class _142_LinkedListCycleII
	{
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x)
			{
				val = x;
				next = null;
			}
		}

        //https://medium.com/@lenchen/leetcode-142-linked-list-cycle-ii-7dd1dc691797
        //use two pointer
        public ListNode DetectCycle(ListNode head)
		{
            if (head == null || head.next == null) return null;

            ListNode slow = head;
            ListNode fast = head;
            bool isCycle = false;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    isCycle = true;
                    break;
                }      
            }

            if (!isCycle) return null;

            fast = head;

            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }

            return fast;
        }

        //use HashSet
        public ListNode DetectCycle2(ListNode head)
        {
            if (head == null || head.next == null) return null;
            var hashSet = new HashSet<ListNode>();
            while (head != null)
            {
                if (hashSet.Contains(head)) return head;
                else hashSet.Add(head);
                head = head.next;
            }
            return null;
        }
    }
}
