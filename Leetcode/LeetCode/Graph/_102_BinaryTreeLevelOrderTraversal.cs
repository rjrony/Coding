using System;
using System.Collections.Generic;
using System.Text;
using static LeetCode.Algo.BinaryTree;

namespace Leetcode.Graph
{
    //alternative solutions:
    //1. c# No Recursion, Simple Queue Solution:
    //https://leetcode.com/problems/binary-tree-level-order-traversal/discuss/1595287/c-No-Recursion-Simple-Queue-Solution
    //2. C#, Dictionary (HashSet), BFS, O(n)
    //https://leetcode.com/problems/binary-tree-level-order-traversal/discuss/1420050/C-Dictionary-(HashSet)-BFS-O(n)
    public class _102_BinaryTreeLevelOrderTraversal
	{
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> levels = new List<IList<int>>();
            LevelOrder(root, levels, 0);
            return levels;
        }

        public void LevelOrder(TreeNode root, IList<IList<int>> levels, int level)
        {
            if (root == null) return;
            if (levels.Count < level + 1) levels.Add(new List<int>());

            levels[level].Add(root.val);
            LevelOrder(root.left, levels, level + 1);
            LevelOrder(root.right, levels, level + 1);

        }

        public void Test()
        {
            //Console.WriteLine(KthFactor(12, 6)); //12
        }
    }
}
