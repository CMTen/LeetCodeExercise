using System;

namespace TwoSum2_InputArrayIsSorted_167
{
    // 167. (Easy)
    public class Solution
    {
        // Given an array of integers numbers that is already sorted in ascending order, 
        // find two numbers such that they add up to a specific target number.
        // Return the indices of the two numbers(1-indexed) as an integer array answer of size 2, 
        // where 1 <= answer[0] < answer[1] <= numbers.length.
        // You may assume that each input would have exactly one solution and you may not use the same element twice.

        // Input: numbers = [2,7,11,15], target = 9, Output: [1,2]
        // Input: numbers = [-1,0], target = -1, Output: [1,2]

        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0, right = numbers.Length - 1;

            while (left < right)
            {
                if (numbers[left] + numbers[right] == target)
                {
                    return new int[2] { left + 1, right + 1 };
                }

                if (numbers[left] + numbers[right] > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            throw new Exception();
        }
    }
}
