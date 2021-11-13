using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Leetcode.Tests
{
    public class CountPrimesTests
    {
        [TestCaseSource(typeof(CountPrimesTestsData), nameof(CountPrimesTestsData.TestCases))]
        public int Test1(int n)
        {
            // Arrange
            var countPrimes = new CountPrimesContainer();

            // Act
            var result = countPrimes.CountPrimes(n);

            // Assert
            return result;
        }
    }

    public class CountPrimesTestsData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(0).Returns(0);
                yield return new TestCaseData(1).Returns(0);
                yield return new TestCaseData(10).Returns(4);
            }
        }
    }
}