using System;

namespace FactorialTrailingZeroes_172
{
    // 172. (Easy)
    public class Solution
    {
        // Given an integer n, return the number of trailing zeroes in n!.
        // Follow up: Could you write a solution that works in logarithmic time complexity?

        // Input: n = 3, Output: 0
        // Explanation: 3! = 6, no trailing zero.
        // Input: n = 5, Output: 1
        // Explanation: 5! = 120, one trailing zero.

        public int TrailingZeroes(int n)
        {
            return n > 0 ? n / 5 + TrailingZeroes(n / 5) : 0;
        }
    }
}
