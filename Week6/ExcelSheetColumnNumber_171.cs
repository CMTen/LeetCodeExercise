using System;

namespace ExcelSheetColumnNumber_171
{
    // 171. (Easy)
    public class Solution
    {
        // Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.
        // For example:
        // A -> 1, B -> 2, C -> 3 ... Z -> 26, AA -> 27, AB -> 28 ...

        // Input: columnNumber = "A", Output: 1
        // Input: columnNumber = "AB", Output: 28
        // Input: columnNumber = "ZY", Output: 701

        public int TitleToNumber(string s)
        {
            if (s == null || s.Length == 0)
            {
                return 0;
            }

            int res = 0;

            foreach (char c in s)
            {
                res = 26 * res + c - "A" + 1;
            }

            return res;
        }
    }
}