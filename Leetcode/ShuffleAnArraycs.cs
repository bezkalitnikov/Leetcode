using System;

namespace Leetcode
{
    public class ShuffleAnArray
    {
        private readonly int[] _nums;

        private readonly int[] _shuffled;

        private int _index = 0;

        private readonly Random _random = new();

        public ShuffleAnArray(int[] nums) 
        {
            _nums = nums;
            _shuffled = new int[nums.Length];
        }
        
        public int[] Reset() 
        {
            return _nums;
        }
        
        public int[] Shuffle() 
        {
            _index = 0;
            Shuffle(0, _nums.Length - 1);

            return _shuffled;
        }

        public void Shuffle(int left, int right)
        {
            if (left > right)
            {
                return;
            }

            var partitionIndex = _random.Next(left, right + 1);
            _shuffled[_index++] = _nums[partitionIndex];
            Shuffle(left, partitionIndex - 1);
            Shuffle(partitionIndex + 1, right);
        }
    }
}