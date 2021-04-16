using System;
using System.Collections.Generic;

namespace ValidParentheses
{
    // Given a string s containing just the characters "(", ")", "{", "}", "[" and "]",
    // determine if the input string is valid.

    // An input string is valid if:
    // 1. Open brackets must be closed by the same type of brackets.
    // 2. Open brackets must be closed in the correct order.

    // Input: s = "([)]", Output: false
    // Input: s = "{[]}", Output: true

    public class Solution
    {
        public bool IsValid(string s)
        {
            if (s == null || s == string.Empty)
                return true;

            Dictionary<char, char> dict = new Dictionary<char, char>();
            Stack<char> stack = new Stack<char>();

            dict.Add(')', '(');
            dict.Add('}', '{');
            dict.Add(']', '[');

            foreach (var c in s)
                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count > 0 && stack.Peek() == dict[c])
                        stack.Pop();
                    else
                        return false;
                }
                else
                    stack.Push(c);

            return stack.Count == 0;
        }
    }
}
