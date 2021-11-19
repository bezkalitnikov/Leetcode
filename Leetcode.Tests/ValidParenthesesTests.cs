using System.Collections;
using NUnit.Framework;

namespace Leetcode.Tests
{
    public class ValidParenthesesTests
    {
        [TestCaseSource(typeof(ValidParenthesesTestsData), nameof(ValidParenthesesTestsData.TestCases))]
        public bool Test1(string s)
        {
            // Arrange
            var validParentheses = new ValidParentheses();

            // Act
            var result = validParentheses.IsValid(s);

            // Assert
            return result;
        }
    }

    public class ValidParenthesesTestsData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("()").Returns(true);
                yield return new TestCaseData("()[]{}").Returns(true);
                yield return new TestCaseData("(]").Returns(false);
                yield return new TestCaseData("([)]").Returns(false);
                yield return new TestCaseData("{[]}").Returns(true);
                yield return new TestCaseData("[").Returns(false);
                yield return new TestCaseData("((").Returns(false);
            }
        }
    }
}