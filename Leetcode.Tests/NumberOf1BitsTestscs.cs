using System;
using System.Collections;
using NUnit.Framework;

namespace Leetcode.Tests
{
    public class NumberOf1BitsTests
    {
        [TestCaseSource(typeof(NumberOf1BitsTestsData), nameof(NumberOf1BitsTestsData.TestCases))]
        public int Test1(string s)
        {
            // Arrange
            var numberOf1Bits = new NumberOf1Bits();
            var num = Convert.ToUInt32(s, 2);

            // Act
            var result = numberOf1Bits.HammingWeight(num);

            // Assert
            return result;
        }
    }

    public class NumberOf1BitsTestsData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("00000000000000000000000000001011").Returns(3);
                yield return new TestCaseData("00000000000000000000000010000000").Returns(1);
                yield return new TestCaseData("11111111111111111111111111111101").Returns(31);
            }
        }
    }
}