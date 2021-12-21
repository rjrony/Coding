using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static LeetCode.Algo.BinaryTree;

namespace Leetcode.Graph
{
	public class _103_BinaryTreeZigzagLevelOrderTraversal
	{
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> levels = new List<IList<int>>();
            LevelOrder(root, levels, 0);
            int count = levels.Count;
            for (int i = 0; i < count; i++)
            {
                //if (i % 2 == 1) levels[i] = levels[i].Reverse().ToList();
                if (i % 2 == 1) levels[i].Reverse();
            }
            return levels;
        }

        public void LevelOrder(TreeNode root, IList<IList<int>> levels, int level)
        {
            if (root == null) return;
            if (levels.Count() < level + 1) levels.Add(new List<int>());

            levels[level].Add(root.val);
            LevelOrder(root.left, levels, level + 1);
            LevelOrder(root.right, levels, level + 1);

        }
    }
}
