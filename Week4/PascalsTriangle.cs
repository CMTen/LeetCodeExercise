using System;

namespace PascalsTriangle
{
    // 118. (Easy)
    public class Solution
    {
        // Given an integer numRows, return the first numRows of Pascal's triangle.
        // In Pascal's triangle, each number is the sum of the two numbers directly above it.

        // Input: numRows = 5, Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
        // Input: numRows = 1, Output: [[1]]

        public IList<IList<int>> Generate(int numRows)
        {
            int[][] answer = new int[numRows][];

            for (int i = 0; i < numRows; i++)
            {
                answer[i] = new int[i + 1];
                answer[i][0] = answer[i][i] = 1;

                for (int j = 1; j < i; j++)
                {
                    answer[i][j] = answer[i - 1][j] + answer[i - 1][j - 1];
                }
            }

            return answer;
        }
    }
}