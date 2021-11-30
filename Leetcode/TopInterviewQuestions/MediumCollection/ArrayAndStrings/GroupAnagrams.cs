using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Leetcode
{
    public class GroupAnagramsContainer
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var groupedAnagrams = new Dictionary<string, IList<string>>();

            foreach(var str in strs)
            {
                var arr = str.ToCharArray();
                Array.Sort(arr);
                var sortedStr = new string(arr);

                if (groupedAnagrams.ContainsKey(sortedStr))
                {
                    groupedAnagrams[sortedStr].Add(str);
                }
                else
                {
                    groupedAnagrams.Add(sortedStr, new List<string> { str });
                }
            }

            return groupedAnagrams.Select(x => x.Value).ToArray();
        }
    }
}
