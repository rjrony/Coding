using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algo
{
	public class BinaryTree
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}

		public void Test()
		{
			////[3,1,4,null,2]
			//var node = new TreeNode(3);
			//node.left = new TreeNode(1);
			//node.right= new TreeNode(4);
			//node.left.right = new TreeNode(2);
			////PrintInOrder(node);
			//Console.WriteLine(KthSmallest(node, 2));
			//[5,3,6,2,4,null,null,1]
			//var node2 = new TreeNode(5);
			//node2.left = new TreeNode(3);
			//node2.right = new TreeNode(6);
			//node2.left.left = new TreeNode(2);
			//node2.left.right = new TreeNode(4);
			//node2.left.left.left = new TreeNode(1);
			//Console.WriteLine(KthSmallest(node2, 3));
			//     4
			//   /   \
			//  2     7
			// / \   / \
			//1   3 6   9
			//[4,2,7,1,3,6,9]

			var node = new TreeNode(4);
			node.left = new TreeNode(2);
			node.right = new TreeNode(7);
			node.left.left = new TreeNode(1);
			node.left.right = new TreeNode(3);
			node.right.left = new TreeNode(6);
			node.right.right = new TreeNode(9);
			DisplayTree_InOrder(node);
			Console.WriteLine();
			//DisplayTree_PreOrder(node);
			//Console.WriteLine();
			//DisplayTree_PreOrder(node);
			InvertTree(node);
			DisplayTree_InOrder(node);
		}

		public TreeNode InvertTree(TreeNode root)
		{
			if (root == null) return null;
			var temp = root.left;
			root.left = root.right;
			root.right = temp;
			InvertTree(root.left);
			InvertTree(root.right);
			return root;
		}

		public void DisplayTree_InOrder(TreeNode root)
		{
			if (root == null) return;

			DisplayTree_InOrder(root.left);
			System.Console.Write(root.val + " ");
			DisplayTree_InOrder(root.right);
		}

		public void DisplayTree_PreOrder(TreeNode root)
		{
			if (root == null) return;
			System.Console.Write(root.val + " ");
			DisplayTree_PreOrder(root.left);
			DisplayTree_PreOrder(root.right);
		}

		public void DisplayTree_PostOrder(TreeNode root)
		{
			if (root == null) return;
			DisplayTree_PostOrder(root.left);
			DisplayTree_PostOrder(root.right);
			System.Console.Write(root.val + " ");
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
