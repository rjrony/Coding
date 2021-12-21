using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{

	//Definition for singly-linked list.
	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int x) { val = x; }
	}

	public class MiddleOfTheLinkedList
	{
        public ListNode MiddleNode_1Loop(ListNode head)
        {
            if (head == null)
            {
                return head;
            }

            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }

        public ListNode MiddleNode_2Loop(ListNode head)
		{
            int totalCount = 0;
            ListNode current = head;

            while (current != null)
            {
                totalCount++;
                current = current.next;
            }

            // reset current
            current = head;

            // for 10 nodes -> we want 5th node
            // for 11 nodes -> we want 6th node -> Math.Ceil()
            int middle = 0;

            if (totalCount % 2 == 0)
            {
                middle = (totalCount / 2) + 1;
            }
            else
            {
                middle = (int)Math.Ceiling(totalCount / 2.0);
            }

            int currentCount = 0;
            while (current != null)
            {
                currentCount++;
                if (currentCount == middle)
                {
                    return current;
                }

                current = current.next;
            }

            return null;
        }
	}
}
