using NUnit.Framework;
using System;

namespace Leetcode.Tests
{
    public class FirstBadVersionTests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            var versions = new[] {false, false, false, true, true};
            var n = 5;
            var expected = 4;
            var searcher = new FirstBadVersionSearcher(versions);

            // Act
            var result = searcher.FirstBadVersion(n);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var versions = new[] {true};
            var n = 1;
            var expected = 1;
            var searcher = new FirstBadVersionSearcher(versions);

            // Act
            var result = searcher.FirstBadVersion(n);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}