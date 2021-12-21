using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class ConstructBinarySearchTreeFromPreorderTraversal
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}


		public TreeNode BstFromPreorder(int[] preorder)
		{
			TreeNode root = new TreeNode(preorder[0]);
			
			for (int i = 1; i < preorder.Length; i++)
			{
				InsertNode(root, new TreeNode(preorder[i]));
			}

			return root;
		}

		private void InsertNode(TreeNode root, TreeNode newNode)
		{
			if (root == null) root = newNode;

			if (newNode.val < root.val)
			{
				if (root.left == null) root.left = newNode;
				else InsertNode(root.left, newNode);
			}
			else
			{
				if (root.right == null) root.right = newNode;
				else InsertNode(root.right, newNode);
			}
		}

		public void DisplayTree(TreeNode root)
		{
			if (root == null) return;

			DisplayTree(root.left);
			System.Console.Write(root.val + " ");
			DisplayTree(root.right);
		}

		public IList<int> InorderTraversal(TreeNode root)
		{
			return InorderTraversal(root, new List<int>());
		}
		public IList<int> InorderTraversal(TreeNode root, IList<int> list)
		{
			if (root == null) return list; 

			InorderTraversal(root.left, list);
			list.Add(root.val);
			InorderTraversal(root.right, list);

			return list;
		}

	}
}
