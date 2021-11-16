using System.Collections;
using NUnit.Framework;

namespace Leetcode.Tests
{
    public class PowertOfThreeTests
    {
        [TestCaseSource(typeof(PowertOfThreeTestsData), nameof(PowertOfThreeTestsData.TestCases))]
        public bool Test1(int n)
        {
            // Arrange
            var powerOfThree = new PowerOfThree();

            // Act
            var result = powerOfThree.IsPowerOfThree(n);

            // Assert
            return result;
        }
    }

    public class PowertOfThreeTestsData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(27).Returns(true);
                yield return new TestCaseData(0).Returns(false);
                yield return new TestCaseData(9).Returns(true);
                yield return new TestCaseData(45).Returns(false);
            }
        }
    }
}