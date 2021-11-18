using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Leetcode.Tests
{
    public class PascalsTriangleTests
    {
        [TestCaseSource(typeof(PascalsTriangleTestsData), nameof(PascalsTriangleTestsData.TestCases))]
        public IList<IList<int>> Test1(int x)
        {
            // Arrange
            var pascalsTriangle = new PascalsTriangle();

            // Act
            var result = pascalsTriangle.Generate(x);

            // Assert
            return result;
        }
    }

    public class PascalsTriangleTestsData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(5).Returns(new List<IList<int>>
                { 
                    new List<int> {1},
                    new List<int> {1, 1},
                    new List<int> {1, 2, 1},
                    new List<int> {1, 3, 3, 1},
                    new List<int> {1, 4, 6, 4, 1}
                });
                yield return new TestCaseData(1).Returns(new List<IList<int>>
                { 
                    new List<int> {1}
                });
            }
        }
    }
}