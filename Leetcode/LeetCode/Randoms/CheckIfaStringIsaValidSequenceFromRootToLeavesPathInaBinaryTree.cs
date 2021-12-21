using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class CheckIfaStringIsaValidSequenceFromRootToLeavesPathInaBinaryTree
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
			{
				this.val = val;
				this.left = left;
				this.right = right;
			}
		}

		public bool IsValidSequence(TreeNode root, int[] arr)
		{
			return IsValid(root, arr, 0);
		}

		private bool IsValid(TreeNode node, int[] arr, int index)
		{
			if (node == null) return false;
			else if (arr.Length - 1 == index)
			{
				if (node.left == null && node.right == null) return node.val == arr[index];
				else return false;
			}
			else if(node.val != arr[index]) return false;

			return IsValid(node.left, arr, index + 1) || IsValid(node.right, arr, index + 1);
		}
	}
}
