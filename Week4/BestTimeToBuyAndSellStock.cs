using System;

namespace BestTimeToBuyAndSellStock
{
    // 121. (Easy)
    public class Solution
    {
        // You are given an array prices where prices[i] is the price of a given stock on the ith day.
        // You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
        // Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.

        // Input: prices = [7,1,5,3,6,4], Output: 5, Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        // Input: prices = [7,6,4,3,1], Output: 0

        public int MaxProfit(int[] prices)
        {
            int sum = 0;
            int max = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                sum += (prices[i] - prices[i - 1]);

                if (sum < 0)
                {
                    sum = 0;
                }
                else if (max < sum)
                {
                    max = sum;
                }
            }

            return max;
        }
    }
}
