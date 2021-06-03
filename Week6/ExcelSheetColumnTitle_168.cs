using System;

namespace ExcelSheetColumnTitle_168
{
    // 168. (Easy)
    public class Solution
    {
        // Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.
        // For example:
        // A -> 1, B -> 2, C -> 3 ... Z -> 26, AA -> 27, AB -> 28 ...

        // Input: columnNumber = 1, Output: "A"
        // Input: columnNumber = 28, Output: "AB"
        // Input: columnNumber = 701, Output: "ZY"

        const string maps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string ConvertToTitle(int n)
        {
            if (n < 27)
            {
                return maps[n - 1].ToString();
            }

            return ConvertToTitle((n - 1) / 26) + maps[(n - 1) % 26].ToString();
        }
    }
}
