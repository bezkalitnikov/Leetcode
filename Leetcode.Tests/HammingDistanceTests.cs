using System;
using System.Collections;
using NUnit.Framework;

namespace Leetcode.Tests
{
    public class HammingDistanceTests
    {
        [TestCaseSource(typeof(HammingDistanceTestsData), nameof(HammingDistanceTestsData.TestCases))]
        public int Test1(int x, int y)
        {
            // Arrange
            var hammingDistance = new HammingDistanceContainer();

            // Act
            var result = hammingDistance.HammingDistance(x, y);

            // Assert
            return result;
        }
    }

    public class HammingDistanceTestsData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(1, 4).Returns(2);
                yield return new TestCaseData(1, 3).Returns(1);
            }
        }
    }
}