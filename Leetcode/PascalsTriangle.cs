using System.Collections.Generic;

namespace Leetcode
{
    public class PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows) 
        {
            var result = new List<IList<int>>
            {
                new List<int> { 1 }
            };

            for (var i = 1; i < numRows; ++i)
            {
                var prevRow = result[i - 1];
                var currRow = new List<int> { 1 };

                for (var j = 1; j < prevRow.Count; ++j)
                {
                    var sum = prevRow[j] + prevRow[j -1];
                    currRow.Add(sum);
                }

                currRow.Add(1);
                result.Add(currRow);
            }

            return result;
        }
    }
}