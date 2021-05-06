using System;

namespace BestTimeToBuyAndSellStockII
{
    // 122. (Easy)
    public class Solution
    {
        // You are given an array prices where prices[i] is the price of a given stock on the ith day.
        // Find the maximum profit you can achieve.
        // You may complete as many transactions as you like(i.e., buy one and sell one share of the stock multiple times).

        // Input: prices = [7,1,5,3,6,4], Output: 7, Explanation: Buy on price = 1, and sell on price = 5, profit = 5-1 = 4.
        // Then buy on price = 3, and sell on price = 6, profit = 6-3 = 3.

        // Input: prices = [1,2,3,4,5], Output: 4

        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0) return 0;

            var max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    max += prices[i] - prices[i - 1];
                }                  
            }

            return max;
        }
    }
}
