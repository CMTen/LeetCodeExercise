using System;

namespace SingleNumber
{
    // 136. (Easy)
    public class Solution
    {
        // Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
        // You must implement a solution with a linear runtime complexity and use only constant extra space.

        // Input: nums = [2,2,1], Output: 1
        // Input: nums = [4,1,2,1,2], Output: 4

        public int SingleNumber(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }

            return result;
        }
    }
}