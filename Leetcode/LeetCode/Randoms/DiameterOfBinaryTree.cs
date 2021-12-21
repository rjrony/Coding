using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int x) { val = x; }
	}
	public class DiameterOfBinaryTree_
	{
		public int GetHeight(TreeNode node)
		{
			if (node == null) return 0;
			return Math.Max(GetHeight(node.left), GetHeight(node.right)) + 1;
		}
		public int DiameterOfBinaryTree(TreeNode root)
		{
			if (root == null) return 0;
			var diameterOfCurrentNode = GetHeight(root.left) + GetHeight(root.right);
			return Math.Max(diameterOfCurrentNode,
							Math.Max(DiameterOfBinaryTree(root.left), DiameterOfBinaryTree(root.right)));
		}
	}
}
