using System;

namespace LongestCommonPrefix
{
    // 14. (Easy)
    public class Solution
    {
        // Write a function to find the longest common prefix string amongst an array of strings.
        // If there is no common prefix, return an empty string "".

        // Input: strs = ["flower","flow","flight"], Output: "fl"
        // Input: strs = ["dog","racecar","car"], Output: ""

        public string LongestCommonPrefix(string[] strs)
        {
            string longest = "";
            int index = 0;
            if (strs == null || strs.Length == 0)
            {
                return longest;
            }
            // go through each letter
            for (int i = 0; i < strs[0].Length; i++)
            {
                // go through each element and check for letter
                for (int j = 1; j < strs.Length; j++)
                {
                    // handles out of bounds case and checks if character is same in all elements
                    if (index >= strs[j].Length || strs[0][index] != strs[j][index])
                    {
                        return longest;
                    }
                }
                longest += strs[0][index];
                index++;
            }
            return longest;
        }

        // Second way
        public string LongestCommonPrefix(string[] strs)
        {
            int min = 0;
            while (strs.Length > 0)
            {
                foreach (string s in strs)
                {
                    if (s.Length == min || s[min] != strs[0][min])
                    {
                        return strs[0].Substring(0, min);
                    }
                }
                min++;
            }
            return "";
        }
    }
}
