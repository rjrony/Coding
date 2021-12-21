using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Curated75
{
    public class _206_ReverseLinkedList
    {

        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

		//with another memory
		public ListNode ReverseList3(ListNode head)
		{
			ListNode node = new ListNode(head.val, null);
			while (head.next != null)
			{
				head = head.next;
				node = new ListNode(head.val, node);
			}
			return node;
		}

		//without another memory
		public ListNode ReverseList2(ListNode head)
		{
			ListNode next = null;
			
			while (head != null)
			{
				var temp = head;
				head = head.next;
				temp.next = next;
				next = temp;
			}
			return next;
		}

		//recursive
		public ListNode ReverseList(ListNode head)
		{
			if (head == null || head.next == null)
				return head;

			ListNode newHead = ReverseList(head.next);
			head.next.next = head;
			head.next = null;

			return newHead;
		}

		public void PrintNodes(ListNode node)
		{
			while (node != null)
			{
				Console.Write(node.val + " ");
				node = node.next;
			}
			Console.WriteLine();
		}

		public void Test()
		{
			//1,3,5,9
			ListNode node = new ListNode(1);
			node.next = new ListNode(3);
			node.next.next = new ListNode(5);
			node.next.next.next = new ListNode(9);

			PrintNodes(node);
			var reversedList = ReverseList(node);
			PrintNodes(reversedList);
		}
	}
}
