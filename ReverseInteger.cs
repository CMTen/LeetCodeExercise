using System;

namespace ReverseInteger
{
    // 7. (Easy)
    public class Solution
    {
        // Given a signed 32-bit integer x, return x with its digits reversed. 
        // If reversing x causes the value to go outside the signed 32-bit integer range, then return 0.

        // Input: x = 123, Output: 321
        // Input: x = -123, Output: -321
        // Input: x = 120, Output: 21

        public int Reverse(int x)
        {
            if (x <= Int32.MinValue || x >= Int32.MaxValue) 
            { 
                return 0; 
            }

            var negative = x < 0;
            if (negative)
            {
                x = -x;
            }

            int result = 0;
            while (x > 0)
            {
                result = 10 * result + x % 10;
                x = x / 10;
            };

            if (negative)
            {
                result = -result;
            }           

            return result;
        }
    }
}