using System;

namespace LengthOfLastWord
{
    // 58. (Easy)
    public class Solution
    {
		// Given a string s consists of some words separated by spaces, 
		// return the length of the last word in the string. If the last word does not exist, return 0.
		// A word is a maximal substring consisting of non-space characters only.

		// Input: s = "Hello World", Output: 5
		// Input: s = " ", Output: 0

		public int LengthOfLastWord(string s)
		{
			var lastCount = 0;

			foreach (var c in s.Trim())
			{
				if (c == " ")
				{
					lastCount = 0;
				}
				else
				{
					lastCount++;
				}
			}

			return lastCount;
		}

		// Second way
		public int LengthOfLastWord(string s)
		{
			return s.Trim().Split().LastOrDefault().Length;
		}
	}
}
