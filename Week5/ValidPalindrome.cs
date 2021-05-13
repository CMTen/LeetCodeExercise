using System;

namespace ValidPalindrome
{
    // 125. (Easy)
    public class Solution
    {
        // Given a string s, determine if it is a palindrome, 
        // considering only alphanumeric characters and ignoring cases.

        // Input: s = "A man, a plan, a canal: Panama", Output: true
        // Explanation: "amanaplanacanalpanama" is a palindrome.
        // Input: s = "race a car", Output: false
        // Explanation: "raceacar" is not a palindrome.

        public bool IsPalindrome(string s)
        {
            var left = 0;
            var right = s.Length - 1;

            while (left < right)
            {
                if (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                else if (!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }
                else
                {
                    if (char.ToLower(s[left]) != char.ToLower(s[right]))
                    {
                        return false;
                    }
                    left++;
                    right--;
                }
            }
            return true;
        }
    }
}
