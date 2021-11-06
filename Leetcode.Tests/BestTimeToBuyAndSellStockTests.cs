using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Leetcode.Tests
{
    public class BestTimeToBuyAndSellStockTests
    {
        [TestCase(new[] { 7, 1, 5, 3, 6, 4 }, ExpectedResult = 5)]
        [TestCase(new[] { 7, 6, 4, 3, 1 }, ExpectedResult = 0)]
        public int Test1(int[] prices)
        {
            // Arrange
            var profitCalc = new BestTimeToBuyAndSellStock();

            // Act
            var result = profitCalc.MaxProfit(prices);

            // Assert
            return result;
        }
    }
}