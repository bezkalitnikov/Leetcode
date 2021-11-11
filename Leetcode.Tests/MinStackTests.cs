using NUnit.Framework;

namespace Leetcode.Tests
{
    public class MinStackTests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            var minStack = new MinStack();

            // Act
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            var min1 = minStack.GetMin(); // return -3
            minStack.Pop();
            var top = minStack.Top();    // return 0
            var min2 = minStack.GetMin(); // return -2

            // Assert
            Assert.AreEqual(-3, min1);
            Assert.AreEqual(0, top);
            Assert.AreEqual(-2, min2);
        }
    }
}