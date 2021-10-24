using System.Collections.Generic;
using NUnit.Framework;

namespace Leetcode.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            var root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            var traverse = new BinaryTreeLevelOrderTraversal();
            var expected = new List<List<int>>
            {
                new List<int> { 3 },
                new List<int> { 9, 20 },
                new List<int> { 15, 7 }
            };

            // Act
            var result = traverse.LevelOrder(root);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var root = new TreeNode(1);
            var traverse = new BinaryTreeLevelOrderTraversal();
            var expected = new List<List<int>>
            {
                new List<int> { 1 }
            };

            // Act
            var result = traverse.LevelOrder(root);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Test3()
        {
            // Arrange
            TreeNode root = null;
            var traverse = new BinaryTreeLevelOrderTraversal();
            IList<IList<int>> expected = new List<IList<int>>();

            // Act
            var result = traverse.LevelOrder(root);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Test4()
        {
            // Arrange
            var  root = new TreeNode(1, new TreeNode(2, new TreeNode(4)), new TreeNode(3, null, new TreeNode(5)));
            var traverse = new BinaryTreeLevelOrderTraversal();
            IList<IList<int>> expected = new List<IList<int>>
            {
                new List<int> { 1 },
                new List<int> { 2, 3},
                new List<int> { 4, 5 }
            };

            // Act
            var result = traverse.LevelOrder(root);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }
    }
}