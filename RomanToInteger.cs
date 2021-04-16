using System;

namespace RomanToInteger
{
    public class Solution
    {
        // Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
        // For example, 2 is written as II in Roman numeral. 12 is written as XII, which is simply X + II. 
        // The number 27 is written as XXVII, which is XX + V + II.

        /*
        var romanKeys = new Dictionary<string, int> 
        {
            { "M", 1000 },
            { "D",  500 },
            { "C",  100 },
            { "L",   50 },
            { "X",   10 },
            { "V",    5 },
            { "I",    1 }
        };
        */

        public int RomanToInt(string s)
        {
            int temp = 0;

            for (int i = 0; i < s.Length; i++)
            {

                switch (s[i])
                {
                    case "I":
                        temp += 1;
                        if (i + 1 < s.Length)
                        {
                            if (s[i + 1] == "V")
                            {
                                temp += 3;
                                i++;
                            }
                            else if (s[i + 1] == "X")
                            {
                                temp += 8;
                                i++;
                            }
                        }
                        break;

                    case "V":
                        temp += 5;
                        break;

                    case "X":
                        temp += 10;
                        if (i + 1 < s.Length)
                        {
                            if (s[i + 1] == "L")
                            {
                                temp += 30;
                                i++;
                            }
                            else if (s[i + 1] == "C")
                            {
                                temp += 80;
                                i++;
                            }
                        }
                        break;

                    case "L":
                        temp += 50;
                        break;

                    case "C":
                        temp += 100;
                        if (i + 1 < s.Length)
                        {
                            if (s[i + 1] == "D")
                            {
                                temp += 300;
                                i++;
                            }
                            else if (s[i + 1] == "M")
                            {
                                temp += 800;
                                i++;
                            };
                        }
                        break;

                    case "D":
                        temp += 500;
                        break;

                    case "M":
                        temp += 1000;
                        break;

                    default:
                        break;
                }
            }

            return temp;
        }
    }
}
