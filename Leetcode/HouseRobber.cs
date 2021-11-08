using System;

namespace Leetcode
{
    public class HouseRobber
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            var max = new int[nums.Length];
            max[0] = nums[0];
            max[1] = Math.Max(nums[0], nums[1]);

            for (var i = 2; i < nums.Length; ++i)
            {
                max[i] = Math.Max(max[i - 1], nums[i] + max[i - 2]);
            }

            return max[^1];
        }
    }
}