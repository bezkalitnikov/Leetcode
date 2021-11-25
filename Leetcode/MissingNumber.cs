using System;

namespace Leetcode
{
    public class MissingNumberContainer
    {
        public int MissingNumber(int[] nums) 
        {
            Array.Sort(nums);

            for(var i = 0; i < nums.Length; ++i)
            {
                if (nums[i] != i)
                {
                    return i;
                }
            }

            return nums.Length;
        }
    }
}