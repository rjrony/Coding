using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algo
{
	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int x) { val = x; }
	}

	public class LinkedList
	{
		public void DeleteNode(ListNode node)
		{
			node.val = node.next.val;
			node.next = node.next.next;
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
			//4,5,1,9
			ListNode node = new ListNode(4);
			node.next = new ListNode(5);
			node.next.next = new ListNode(1);
			node.next.next.next = new ListNode(9);

			PrintNodes(node);
			DeleteNode(node.next.next);
			PrintNodes(node);
		}
	}
}
