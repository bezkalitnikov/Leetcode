using System;
using System.Collections.Generic;
using System.Linq;

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

            var leftBound = 0;
            var rightBound = nums.Length - 1;

            if (nums[0] < 0 && nums[1] <= 0)
            {
                var negateMax = nums[0] + nums[1];
                for (var i = nums.Length - 1; i >=0; --i)
                {
                    if (nums[i] > -negateMax)
                    {
                        rightBound = i - 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (nums[^1] > 0 && nums[^2] >= 0)
            {
                var posMax = nums[^1] + nums[^2];
                for (var i = 0; i < nums.Length; ++i)
                {
                    if (nums[i] < -posMax)
                    {
                        leftBound = i + 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            var hash = new Dictionary<int, int>();
            var normalizedNums = new List<int>();

            for (var i = leftBound; i <= rightBound; ++i)
            {
                if (hash.ContainsKey(nums[i]))
                {
                    hash[nums[i]]++;
                    if (nums[i] != 0 && hash[nums[i]] < 3)
                    {
                        normalizedNums.Add(nums[i]);
                    }
                }
                else
                {
                    hash.Add(nums[i], 1);
                    normalizedNums.Add(nums[i]);
                }
            }

            var results = new List<IList<int>>();

            if (hash.ContainsKey(0) && hash[0] >= 3)
            {
                results.Add(new[] {0, 0, 0});
            }

            for (var i = 0; i < normalizedNums.Count; ++i)
            {
                if (i > 0 && normalizedNums[i] == normalizedNums[i - 1])
                {
                    continue;
                }

                if (nums[i] >= 0)
                {
                    break;
                }

                for (var j = i + 1; j < normalizedNums.Count; ++j)
                {
                    if (j > i + 1 && normalizedNums[j] == normalizedNums[j - 1])
                    {
                        continue;
                    }
                    
                    var remainder = -(normalizedNums[i] + normalizedNums[j]);

                    if (remainder < normalizedNums[j])
                    {
                        continue;
                    }

                    if (hash.ContainsKey(remainder))
                    {
                        var count = 1;

                        if (normalizedNums[i] == remainder)
                        {
                            count++;
                        }

                        if (normalizedNums[j] == remainder)
                        {
                            count++;
                        }

                        if (hash[remainder] < count)
                        {
                            continue;
                        }

                        results.Add(new[] {normalizedNums[i], normalizedNums[j], remainder});
                    }
                }
            }

            return results;
        }
    }
}