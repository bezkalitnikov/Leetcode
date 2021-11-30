using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class ThreeSumContainer
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            if (nums.Length < 3)
            {
                return Array.Empty<IList<int>>();
            }

            Array.Sort(nums);

            if (nums[0] > 0)
            {
                return Array.Empty<IList<int>>();
            }

            if (nums[^1] < 0)
            {
                return Array.Empty<IList<int>>();
            }

            var result = new List<IList<int>>();

            for (var i = 0; i < nums.Length; ++i)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                if (nums[i] > 0)
                {
                    break;
                }

                for (var j = i + 1; j < nums.Length; ++j)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }

                    var remainder = -(nums[i] + nums[j]);

                    if (remainder < 0)
                    {
                        break;
                    }

                    for (var k = nums.Length - 1; k > j; --k)
                    {
                        if (nums[k] < remainder)
                        {
                            break;
                        }
                        
                        if (nums[k] == remainder)
                        {
                            result.Add(new[] {nums[i], nums[j], remainder});
                            break;
                        }
                    }
                }
            }

            return result;
        }
    }
}