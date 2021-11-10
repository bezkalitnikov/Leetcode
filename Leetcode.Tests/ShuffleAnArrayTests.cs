using NUnit.Framework;

namespace Leetcode.Tests
{
    public class ShuffleAnArrayTests
    {
        [TestCase(new int[] {1, 2, 3})]
        public void Test1(int[] nums)
        {
            // Arrange
            var shuffle = new ShuffleAnArray(nums);

            // Act
            var initShuffle = shuffle.Shuffle();
            var reset = shuffle.Reset();
            var nextShuffle = shuffle.Shuffle();

            // Assert
            CollectionAssert.AreEquivalent(nums, initShuffle);
            CollectionAssert.AreEqual(nums, reset);
            CollectionAssert.AreEquivalent(nums, nextShuffle);
        }
    }
}