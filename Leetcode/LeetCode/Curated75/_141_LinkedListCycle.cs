using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Curated75
{
	public class _141_LinkedListCycle
	{
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

		//with 2 runners
		public bool HasCycle2(ListNode head)
		{
			if (head == null || head.next == null) return false;

			var fast = head.next.next;
			var slow = head.next;
			while (fast != null && fast.next != null)
			{
				if (fast.next == slow) return true;
				fast = fast.next.next;
				slow = slow.next;
			}

			return false;
		}

		//using hashSet
		public bool HasCycle(ListNode head)
		{
			if (head == null) return false;

			HashSet<ListNode> set = new HashSet<ListNode>();

			for (ListNode i = head; i != null; i = i.next)
			{
				if (set.Contains(i)) return true;	
				else set.Add(i);
			}

			return false;
		}

		public void PrintNodes(ListNode node)
		{
			var i = 0;
			while (node != null && i++<10)
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
			node.next.next.next.next = node.next;

			Console.WriteLine(HasCycle(node));

			//PrintNodes(node);
		}
	}
}
