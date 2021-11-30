using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Leetcode.Tests
{
    public class ThreeSumTests
    {
        [TestCaseSource(typeof(ThreeSumTestsData), nameof(ThreeSumTestsData.TestCases))]
        public IList<IList<int>> Test1(int[] nums)
        {
            // Arrange

            // Act
            var result = ThreeSumContainer.ThreeSum(nums);

            // Assert
            return result;
        }
    }

    public class ThreeSumTestsData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new[] {-1, 0, 1, 2, -1, -4}).Returns(new List<IList<int>>
                { 
                    new List<int> {-1, -1, 2},
                    new List<int> {-1, 0, 1}
                });
                yield return new TestCaseData(Array.Empty<int>()).Returns(new List<IList<int>>{});
                yield return new TestCaseData(new[] {0}).Returns(new List<IList<int>>{});
                yield return new TestCaseData(new[] {1, 1, -2}).Returns(new List<IList<int>>
                { 
                    new List<int> {-2, 1, 1}
                });
                yield return new TestCaseData(new[] {3, 0, -2, -1, 1, 2}).Returns(new List<IList<int>>
                { 
                    new List<int> {-2, -1, 3},
                    new List<int> {-2, 0, 2},
                    new List<int> {-1, 0, 1},
                });
                yield return new TestCaseData(new[] {-3, 1, -5, -1, 0, -1, 3, -4, 1, 2, -1, -1, -4, -4}).Returns(new List<IList<int>>
                { 
                    new List<int> {-5, 2, 3},
                    new List<int> {-4, 1, 3},
                    new List<int> {-3, 0, 3},
                    new List<int> {-3, 1, 2},
                    new List<int> {-1, -1, 2},
                    new List<int> {-1, 0, 1}
                });
                yield return new TestCaseData(new[] {0, 0, 0}).Returns(new List<IList<int>>
                { 
                    new List<int> {0, 0, 0}
                });
            }
        }
    }
}