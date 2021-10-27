using NUnit.Framework;

namespace Leetcode.Tests
{
    public class ConvertSortedArrayToBinarySearchTreeTests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            var array = new[] { -10, -3, 0, 5, 9 };
            var converter = new ConvertSortedArrayToBinarySearchTree();
            var expected = new TreeNode(0, new TreeNode(-3, new TreeNode(-10)), new TreeNode(9, new TreeNode(5)));

            // Act
            var result = converter.SortedArrayToBST(array);

            // Assert
            CollectionAssert.AreEqual(expected.ToList(), result.ToList());
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var array = new[] { 1, 3 };
            var converter = new ConvertSortedArrayToBinarySearchTree();
            var expected = new TreeNode(3, new TreeNode(1));

            // Act
            var result = converter.SortedArrayToBST(array);

            // Assert
            CollectionAssert.AreEqual(expected.ToList(), result.ToList());
        }
    }
}