using System.Collections.Generic;
using System.Linq;
using Leetcode;
using Leetcode.Tests;

namespace Leetcode.Tests
{
    public static class TreeNodeExtensions
    {
        public static List<int?> ToList(this TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            var flatten = new List<List<int?>>();
            root.ToList(flatten, 0);

            return flatten.SelectMany(x => x).ToList();
        }

        private static void ToList(this TreeNode root, List<List<int?>> flatten, int level)
        {
            if (flatten.Count == level)
            {
                flatten.Add(new List<int?>());
            }

            if (root.left == null && root.right == null)
            {
                flatten[level].Add(root.val);
                return;
            }

            flatten[level].Add(root.val);
            flatten.Add(new List<int?>());

            if (root.left == null)
            {
                flatten[level + 1].Add(null);
            }
            else
            {
                root.left.ToList(flatten, level + 1);
            }

            if (root.right == null)
            {
                flatten[level + 1].Add(null);
            }
            else
            {
                root.right.ToList(flatten, level + 1);
            }
        }
    }
}