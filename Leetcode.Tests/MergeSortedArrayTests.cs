using System.Collections.Generic;
using NUnit.Framework;
using System;

namespace Leetcode.Tests
{
    public class MergeSortedArrayTests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            var nums1 = new[] {1, 2, 3, 0, 0, 0};
            var m = 3;
            var nums2 = new[] {2, 5, 6};
            var n = 3;
            var expected = new[] {1, 2, 2, 3, 5, 6};
            var merger = new MergeSortedArray();

            // Act
            merger.Merge(nums1, m, nums2, n);

            // Assert
            CollectionAssert.AreEqual(expected, nums1);
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var nums1 = new[] {1};
            var m = 1;
            var nums2 = Array.Empty<int>();
            var n = 0;
            var expected = new[] {1};
            var merger = new MergeSortedArray();

            // Act
            merger.Merge(nums1, m, nums2, n);

            // Assert
            CollectionAssert.AreEqual(expected, nums1);
        }

        [Test]
        public void Test3()
        {
            // Arrange
            var nums1 = new[] {0};
            var m = 0;
            var nums2 = new[] {1};
            var n = 1;
            var expected = new[] {1};
            var merger = new MergeSortedArray();

            // Act
            merger.Merge(nums1, m, nums2, n);

            // Assert
            CollectionAssert.AreEqual(expected, nums1);
        }

        [Test]
        public void Test4()
        {
            // Arrange
            var nums1 = new[] {1, 2, 4, 5, 6, 0};
            var m = 5;
            var nums2 = new[] {3};
            var n = 1;
            var expected = new[] {1, 2, 3, 4, 5, 6};
            var merger = new MergeSortedArray();

            // Act
            merger.Merge(nums1, m, nums2, n);

            // Assert
            CollectionAssert.AreEqual(expected, nums1);
        }
    }
}