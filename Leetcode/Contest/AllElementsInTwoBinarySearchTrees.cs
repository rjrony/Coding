using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest
{
    
 //Definition for a binary tree node.
 public class TreeNode
 {
     public int? val;
     public TreeNode left;
     public TreeNode right;

     public TreeNode(int? x)
     {
         if (x != null) val = x.Value;
     }
 }

 public class AllElementsInTwoBinarySearchTrees
    {
        //public virtual void TraversalLeaves(TreeNode node)
        //{
        //    if (node == null)
        //        return;

        //    TraversalLeaves(node.left);

        //    // Print it if it is a leaf node 
        //    if (node.left == null && node.right == null)
        //    {
        //        //Console.Write(node.data + " ");
        //    }
        //    TraversalLeaves(node.right);
        //}

        static IList<int> list = new List<int>();
        public static void recursiveInorder(TreeNode root)
        {
            if (root.left != null)
            {
                recursiveInorder(root.left);
            }

            if (root.val != null) list.Add(root.val.Value);
            if (root.right != null)
            {
                recursiveInorder(root.right);
            }
        }
        public static IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            list = new List<int>();
            if (root1 != null) recursiveInorder(root1);
            if (root2 != null) recursiveInorder(root2);
            var orderList = list.OrderBy(x => x).ToList();

            return orderList;
        }

        public static void Solution()
        {
            //root1 = [2,1,4], root2 = [1,0,3]
            TreeNode root1 = new TreeNode(2);
            root1.left = new TreeNode(1);
            root1.right = new TreeNode(4);

            //TreeNode root1 = new TreeNode(null);

            TreeNode root2 = new TreeNode(1);
            root2.left = new TreeNode(0);
            root2.right = new TreeNode(3);

            var output = GetAllElements(root1, root2);
            Console.WriteLine(string.Join(", ", output));
        }
    }
}
