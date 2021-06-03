using System;

namespace NumberOf1Bits_191
{
    // 191. (Easy)
    public class Solution
    {
        // Write a function that takes an unsigned integer and returns the number of '1' bits it has (also known as the Hamming weight).

        // Input: n = 00000000000000000000000000001011, Output: 3
        // Explanation: The input binary string 00000000000000000000000000001011 has a total of three '1' bits.
        // Input: n = 00000000000000000000000010000000, Output: 1
        // Explanation: The input binary string 00000000000000000000000010000000 has a total of one '1' bit.

        // First solution
        public int HammingWeight(uint n)
        {
            int count = 0;

            while (n > 0)
            {
                uint mode = n % 2;

                if (mode == 1)
                {
                    count++;
                }

                n = n / 2;
            }
            return count;
        }

        // Second solution
        public int HammingWeight(uint n)
        {
            return Convert.ToString(n, 2).Replace("0", "").Length;
        }
    }
}
