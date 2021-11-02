using NUnit.Framework;

namespace Leetcode.Tests
{
    public class ClimbingStairsTests
    {
        [TestCase(2, ExpectedResult=2)]
        [TestCase(3, ExpectedResult=3)]
        public int Test1(int n)
        {
            // Arrange
            var climbCalc = new ClimbingStairs();

            // Act
            var result = climbCalc.ClimbStairs(n);

            // Assert
            return result;
        }
    }
}