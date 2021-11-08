using NUnit.Framework;

namespace Leetcode.Tests
{
    public class HousRobberTests
    {
        [TestCase(new int[] {1, 2, 3, 1}, ExpectedResult = 4)]
        [TestCase(new int[] {2, 7, 9, 3, 1}, ExpectedResult = 12)]
        [TestCase(new int[] {2, 1, 1, 2}, ExpectedResult = 4)]
        public int Test1(int[] nums)
        {
            // Arrange
            var robCalc = new HouseRobber();

            // Act
            var result = robCalc.Rob(nums);

            // Assert
            return result;
        }
    }
}