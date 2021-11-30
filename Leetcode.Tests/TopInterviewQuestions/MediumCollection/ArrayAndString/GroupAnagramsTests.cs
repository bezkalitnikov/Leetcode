using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Leetcode.Tests
{
    public class GroupAnagramTests
    {
        [TestCaseSource(typeof(GroupAnagramTestsData), nameof(GroupAnagramTestsData.TestCases))]
        public IList<IList<string>> Test1(string[] strs)
        {
            // Arrange

            // Act
            var result = GroupAnagramsContainer.GroupAnagrams(strs);

            // Assert
            return result;
        }
    }

    public class GroupAnagramTestsData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData((object)new []
                {
                    "eat","tea","tan","ate","nat","bat"
                }).Returns(new List<IList<string>>
                {
                    new List<string> {"eat","tea", "ate"},
                    new List<string> {"tan", "nat"},
                    new List<string> {"bat"}
                });
                yield return new TestCaseData((object)new []
                {
                    string.Empty
                }).Returns(new List<IList<string>>
                {
                    new List<string> {string.Empty},
                });
                yield return new TestCaseData((object)new []
                {
                    "a"
                }).Returns(new List<IList<string>>
                {
                    new List<string> {"a"},
                });
            }
        }
    }
}
