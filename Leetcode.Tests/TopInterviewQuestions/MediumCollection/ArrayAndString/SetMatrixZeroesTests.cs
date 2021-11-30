using System.Collections;
using NUnit.Framework;

namespace Leetcode.Tests
{
    public class SetMatrixZeroesTests
    {
        [TestCaseSource(typeof(SetMatrixZeroesTestsData), nameof(SetMatrixZeroesTestsData.TestCases))]
        public int[][] Test1(int[][] matrix)
        {
            // Arrange

            // Act
            SetMatrixZeroes.SetZeroes(matrix);

            // Assert
            return matrix;
        }
    }

    public class SetMatrixZeroesTestsData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData((object)new int[][]
                {
                    new[] {1, 1, 1},
                    new[] {1, 0, 1},
                    new[] {1, 1, 1}
                }).Returns(new int[][] 
                {
                    new[] {1, 0, 1},
                    new[] {0, 0, 0},
                    new[] {1, 0, 1}
                });
                yield return new TestCaseData((object)new int[][]
                {
                    new[] {0, 1, 2, 0},
                    new[] {3, 4, 5, 2},
                    new[] {1, 3, 1, 5}
                }).Returns(new int[][] 
                {
                    new[] {0, 0, 0, 0},
                    new[] {0, 4, 5, 0},
                    new[] {0, 3, 1, 0}
                });
                yield return new TestCaseData((object)new int[][]
                {
                    new[] {1, 2, 3, 4},
                    new[] {5, 0, 7, 8},
                    new[] {0, 10, 11, 12},
                    new[] {13, 14, 15, 0}
                }).Returns(new int[][] 
                {
                    new[] {0, 0, 3, 0},
                    new[] {0, 0, 0, 0},
                    new[] {0, 0, 0, 0},
                    new[] {0, 0, 0, 0}
                });
                yield return new TestCaseData((object)new int[][]
                {
                    new[] {1, 0, 3}
                }).Returns(new int[][] 
                {
                    new[] {0, 0, 0}
                });
                yield return new TestCaseData((object)new int[][]
                {
                    new[] {-4, -2147483648, 6, -7, 0},
                    new[] {-8, 6, -8, -6, 0},
                    new[] {2147483647, 2, -9, -6, -10}
                }).Returns(new int[][] 
                {
                    new[] {0, 0, 0, 0, 0},
                    new[] {0, 0, 0, 0, 0},
                    new[] {2147483647, 2, -9, -6, 0}
                });
            }
        }
    }
}
