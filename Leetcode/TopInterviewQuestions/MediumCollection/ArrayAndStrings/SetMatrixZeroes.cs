using System;
using System.Reflection;

namespace Leetcode
{
    public class SetMatrixZeroes
    {
        public static void SetZeroes(int[][] matrix)
        {
            var setFirstRowZeroes = false;

            for (var i = 0; i < matrix[0].Length; ++i)
            {
                if (matrix[0][i] == 0)
                {
                    setFirstRowZeroes = true;
                }
            }

            for (var i = 1; i < matrix.Length; ++i)
            {
                for (var j = 0; j < matrix[i].Length; ++j)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

            for (var i = 1; i < matrix.Length; ++i)
            {
                if (matrix[i][0] == 0)
                {
                    for (var j = 1; j < matrix[i].Length; ++j)
                    {
                        matrix[i][j] = 0;
                    }
                }
                else
                {
                    for (var j = 0; j < matrix[i].Length; ++j)
                    {
                        if (matrix[0][j] == 0)
                        {
                            matrix[i][j] = 0;
                        }
                    }
                }
            }

            if (setFirstRowZeroes)
            {
                for (var i = 0; i < matrix[0].Length; ++i)
                {
                    matrix[0][i] = 0;
                }
            }
        }
    }
}