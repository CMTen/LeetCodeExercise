using System;

namespace MinStack_155
{
    // 155. (Easy)
    public class Solution
    {
        // Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
        // Implement the MinStack class:
        // ● MinStack() initializes the stack object.
        // ● void push(val) pushes the element val onto the stack.
        // ● void pop() removes the element on the top of the stack.
        // ● int top() gets the top element of the stack.
        // ● int getMin() retrieves the minimum element in the stack.

        // Input
        // ["MinStack","push","push","push","getMin","pop","top","getMin"]
        // [[],[-2],[0],[-3],[],[],[],[]]

        // Output
        // [null, null, null, null, -3, null, 0, -2]

        // List solution
        public class MinStack
        {
            private List<int> list;

            /** initialize your data structure here. */
            public MinStack()
            {
                list = new List<int>();
            }

            public void Push(int x)
            {
                list.Add(x);
            }

            public void Pop()
            {
                list.RemoveAt(list.Count - 1);
            }

            public int Top()
            {
                return list[list.Count - 1];
            }

            public int GetMin()
            {
                return list.Min();
            }
        }

        // One-stack solution
        public class MinStack
        {
            private Stack<(int, int)> stack;

            /** initialize your data structure here. */
            public MinStack()
            {
                stack = new Stack<(int, int)>();
            }

            public void Push(int x)
            {
                if (stack.Count == 0)
                    stack.Push((x, x));
                else
                    stack.Push((x, Math.Min(x, stack.Peek().Item2)));
            }

            public void Pop()
            {
                stack.Pop();
            }

            public int Top()
            {
                return stack.Peek().Item1;
            }

            public int GetMin()
            {
                return stack.Peek().Item2;
            }
        }
    }
}
