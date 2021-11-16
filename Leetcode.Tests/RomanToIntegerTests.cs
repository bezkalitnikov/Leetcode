using System.Collections;
using NUnit.Framework;

namespace Leetcode.Tests
{
    public class RomanToIntegerTests
    {
        [TestCaseSource(typeof(RomanToIntegerTestsData), nameof(RomanToIntegerTestsData.TestCases))]
        public int Test1(string s)
        {
            // Arrange
            var romanToInteger = new RomanToInteger();

            // Act
            var result = romanToInteger.RomanToInt(s);

            // Assert
            return result;
        }
    }

    public class RomanToIntegerTestsData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("III").Returns(3);
                yield return new TestCaseData("IV").Returns(4);
                yield return new TestCaseData("IX").Returns(9);
                yield return new TestCaseData("LVIII").Returns(58);
                yield return new TestCaseData("MCMXCIV").Returns(1994);
            }
        }
    }
}