using System;
using System.Data.Common;

namespace Leetcode
{
    public class ConvertSortedArrayToBinarySearchTree 
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBST(nums, 0, nums.Length - 1);
        }

        private TreeNode SortedArrayToBST(int[] nums, int left, int right) 
        {
            if (left > right)
            {
                return null;
            }

            int idx;

            if ((left + right) % 2 == 0)
            {
                idx = (left + right) / 2;
            }
            else
            {
                idx = (left + right) / 2 + 1;
            }

            var node = new TreeNode(nums[idx])
            {
                left = SortedArrayToBST(nums, left, idx - 1),
                right = SortedArrayToBST(nums, idx + 1, right)
            };

            return node;
        }
    }
}