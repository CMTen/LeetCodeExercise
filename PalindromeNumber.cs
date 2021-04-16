using System;

namespace PalindromeNumber
{
    public class Solution
    {
        // Given an integer x, return true if x is palindrome integer.

        // An integer is a palindrome when it reads the same backward as forward.
        // For example, 121 is palindrome while 123 is not.

        public bool IsPalindrome(int x)
        {
            //all negetive integer are not palindrome
            if (x < 0)
            {
                return false;
            }
            else
            {
                int result = 0;
                int temp = x;
                while (temp != 0)
                {
                    result = result * 10 + temp % 10;
                    temp = temp / 10;
                }
                if (result == x)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
