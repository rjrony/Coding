using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.October
{
	public class _99_RecoverBinarySearchTree
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}


		TreeNode first = null;
		TreeNode second = null;
		public void RecoverTree(TreeNode root)
		{
			TreeNode prev = null;
			InOrder(root, ref prev);

			var temp = first.val;
			first.val = second.val;
			second.val = temp;
		}

        public void InOrder(TreeNode root, ref TreeNode prev)
        {
            if (root == null)
            {
                return;
            }

            InOrder(root.left, ref prev);

            if (prev != null && prev.val > root.val)
            {
                if (first == null)
                {
                    first = prev;
                    second = root;
                }
                else
                {
                    second = root;
                }
            }

            prev = root;

            InOrder(root.right, ref prev);
        }

		public void Test()
		{
			//Console.WriteLine(FindNumberOfLIS(new int[] { 1, 0, 0, 0, 1, 0, 1 }));

		}
	}
}
