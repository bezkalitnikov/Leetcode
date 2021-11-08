using System;

namespace Leetcode
{
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            var local_max = 0;
            var global_max = int.MinValue;

            for(var i = 0; i < nums.Length; ++i)
            {
                local_max = Math.Max(nums[i], local_max + nums[i]);

                if (global_max < local_max)
                {
                    global_max = local_max;
                }
            }

            return global_max;
        }
    }
}