using System;

namespace PlusOne
{
	// 66. (Easy)
	public class Solution
	{
        // Given a non-empty array of decimal digits representing a non-negative integer, increment one to the integer.
        // The digits are stored such that the most significant digit is at the head of the list, 
        // and each element in the array contains a single digit.
        // You may assume the integer does not contain any leading zero, except the number 0 itself.

        // Input: digits = [1,2,3], Output: [1,2,4]
        // Input: digits = [9,9], Output: [1,0,0]

        public int[] PlusOne(int[] digits)
        {
            if (digits.Length == 0)
            {
                return digits;
            }

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i] += 1;
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                }
            }

            int[] result = new int[digits.Length + 1];
            result[0] = 1;

            for (int i = 1; i < result.Length; i++)
            {
                result[i] = 0;
            }

            return result;
        }
    }
}
