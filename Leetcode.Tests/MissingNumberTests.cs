using System.Collections;
using NUnit.Framework;

namespace Leetcode.Tests
{
    public class MissingNumberTests
    {
        [TestCaseSource(typeof(MissingNumberTestsData), nameof(MissingNumberTestsData.TestCases))]
        public int Test1(int[] nums)
        {
            // Arrange
            var missingNumber = new MissingNumberContainer();

            // Act
            var result = missingNumber.MissingNumber(nums);

            // Assert
            return result;
        }
    }

    public class MissingNumberTestsData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new[] {3, 0, 1}).Returns(2);
                yield return new TestCaseData(new[] {0, 1}).Returns(2);
                yield return new TestCaseData(new[] {9, 6, 4, 2, 3, 5, 7, 0, 1}).Returns(8);
                yield return new TestCaseData(new[] {0}).Returns(1);
            }
        }
    }
}