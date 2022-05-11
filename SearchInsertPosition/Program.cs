using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace SearchInsertPosition
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new[] { 1, 3, 5, 6 };
            //var objSearch = new SearchInsertPosition();
            //int val = objSearch.SearchInsert(nums, 2);
            //Console.WriteLine(val);
            //Console.Read();


            //int[][] val = new int[3][];
            //val[0] = new[] { 0, 0, 0 };
            //val[1] = new[] { 0, 1, 0 };
            //val[2] = new[] { 1, 1, 1 };
            //string str = "       test";
            //str = str.Trim();
            //int[] nums1 = new[] {1, 3};
            //int[] nums2 = new[] {2};
            TreeNode node4 = new TreeNode(3, null, null);
            TreeNode node3 = new TreeNode(4, null, null);
            TreeNode node2 = new TreeNode(2, node3, node4);
            TreeNode node1 = new TreeNode(2, node4, node3);
            TreeNode root = new TreeNode(1, node1, node2);
            Solution s = new Solution();
            var i = s.IsSymmetric(root);
            
            Console.Read();
        }
    }

    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return root;
            DFS(root);
            return root;
        }

        public void DFS(TreeNode node)
        {
            if (node.left == null && node.right == null)
                return;
            var temp = node.left;
            node.left = node.right;
            node.right = temp;
            DFS(node.left);
            DFS(node.right);
        }
    }

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
}
