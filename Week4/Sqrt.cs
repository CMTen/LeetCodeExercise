using System;

namespace Sqrt
{
    // 69. (Easy)
    public class Solution
    {
        // Given a non-negative integer x, compute and return the square root of x.
        // Since the return type is an integer, the decimal digits are truncated, 
        // and only the integer part of the result is returned.

        // Input: x = 4, Output: 2
        // Input: x = 8, Output: 2
        // Explanation: The square root of 8 is 2.82842..., and since the decimal part is truncated, 2 is returned.

        public int MySqrt(int x)
        {
            int i = 1;

            while (i < x / i)
            {
                i++;
            }

            if (i > x / i) return i - 1;

            return i;
        }
    }
}
