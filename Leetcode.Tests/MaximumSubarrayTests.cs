using NUnit.Framework;

namespace Leetcode.Tests
{
    public class MaximumSubarrayTests
    {
        [TestCase(new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4}, ExpectedResult = 6)]
        [TestCase(new int[] {1}, ExpectedResult = 1)]
        [TestCase(new int[] {5, 4, -1, 7, 8}, ExpectedResult = 23)]
        public int Test1(int[] nums)
        {
            // Arrange
            var maxCalc = new MaximumSubarray();

            // Act
            var result = maxCalc.MaxSubArray(nums);

            // Assert
            return result;
        }
    }
}