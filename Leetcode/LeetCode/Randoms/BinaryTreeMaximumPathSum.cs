using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class BinaryTreeMaximumPathSum
    {
        private int Helper2(ref int res, TreeNode node)
        {
            if (node == null) return 0;

            int value = node.val;
            int left = Helper(ref res, node.left);
            int right = Helper(ref res, node.right);

            int subTreeSum = value;
            subTreeSum = Math.Max(subTreeSum, value + left);
            subTreeSum = Math.Max(subTreeSum, value + right);

            res = Math.Max(res, subTreeSum);
            res = Math.Max(res, value + left + right);
            return subTreeSum;
        }

        private int Helper(ref int res, TreeNode node)
        {
            if (node == null) return 0;

            int value = node.val;
            int left = Helper(ref res, node.left);
            int right = Helper(ref res, node.right);

            var subTreeSum = Math.Max(value, Math.Max(value + left, value + right));

            res = Math.Max(res, subTreeSum);
            res = Math.Max(res, value + left + right);
            return subTreeSum;
        }

        public int MaxPathSum(TreeNode root)
        {
            int res = int.MinValue;
            Helper(ref res, root);
            return res;
        }
    }
}
