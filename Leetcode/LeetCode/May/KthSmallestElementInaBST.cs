using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.May
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
    public class KthSmallestElementInaBST
    {
        public int KthSmallest(TreeNode root, int k)
        {
            int count = 0;
            var node = Inorder(root, k, ref count);
            return node == null ? -1 : node.val;
        }

        private TreeNode Inorder(TreeNode node, int k, ref int count)
        {
            if (node != null)
            {
                var left = Inorder(node.left, k, ref count);
                if (left != null)
                {
                    return left;
                }

                count++;
                if (count == k)
                {
                    return node;
                }

                var right = Inorder(node.right, k, ref count);
                if (right != null)
                {
                    return right;
                }
            }
            return null;
        }

        //public int KthSmallest(TreeNode root, int k)
        //{
        //    return helper(root, ref k);
        //}

        //int helper(TreeNode root, ref int k)
        //{
        //    if (root == null) return -1;
        //    int x = helper(root.left, ref k);
        //    if (k == 0) return x;
        //    if (--k == 0) return root.val;
        //    return helper(root.right, ref k);
        //}

        //public int KthSmallest(TreeNode root, int k)
        //{
        //    //var node = FindBottomLeft(root);
        //    int result = FindKSmallestVal(root, ref k);
        //    return result;
        //}

        //private int FindKSmallestVal(TreeNode node, ref int k)
        //{
        //    if (node.left == null)
        //    {
        //        return 0;
        //    }
        //    else return FindKSmallestVal(node.left, ref k);
        //    Console.WriteLine(node.val);
        //    if (node.right != null) return FindKSmallestVal(node.right, ref k);
        //}

        private TreeNode FindBottomLeft(TreeNode root)
        {
            if (root.left == null) return root;
            return FindBottomLeft(root.left);
        }

        public void PrintInOrder(TreeNode node)
        {
            if (node.left != null) PrintInOrder(node.left);
            Console.WriteLine(node.val);
            if (node.right != null) PrintInOrder(node.right);
            //return;
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
            var node2 = new TreeNode(5);
            node2.left = new TreeNode(3);
            node2.right = new TreeNode(6);
            node2.left.left = new TreeNode(2);
            node2.left.right = new TreeNode(4);
            node2.left.left.left = new TreeNode(1);
            Console.WriteLine(KthSmallest(node2, 3));
        }
	}
}
