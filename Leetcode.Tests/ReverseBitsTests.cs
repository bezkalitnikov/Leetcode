using System;
using System.Collections;
using NUnit.Framework;

namespace Leetcode.Tests
{
    public class ReverseBitsTests
    {
        [TestCaseSource(typeof(ReverseBitsTestsData), nameof(ReverseBitsTestsData.TestCases))]
        public uint Test1(uint x)
        {
            // Arrange
            var reverseBits = new ReverseBitsContainer();

            // Act
            var result = reverseBits.ReverseBits(x);

            // Assert
            return result;
        }
    }

    public class ReverseBitsTestsData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(43261596U).Returns(964176192U);
                yield return new TestCaseData(4294967293U).Returns(3221225471U);
            }
        }
    }
}