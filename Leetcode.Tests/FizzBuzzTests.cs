using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Leetcode.Tests
{
    public class FizzBuzzTests
    {
        [TestCaseSource(typeof(FizzBuzzTestsData), nameof(FizzBuzzTestsData.TestCases))]
        public IList<string> Test1(int n)
        {
            // Arrange
            var fizzBuzz = new FizzBuzzContainer();

            // Act
            var result = fizzBuzz.FizzBuzz(n);

            // Assert
            return result;
        }
    }

    public class FizzBuzzTestsData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(3).Returns(new List<string> {"1", "2", "Fizz"});
                yield return new TestCaseData(5).Returns(new List<string> {"1", "2", "Fizz", "4", "Buzz"});
                yield return new TestCaseData(15).Returns(new List<string> {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"});
            }
        }
    }
}