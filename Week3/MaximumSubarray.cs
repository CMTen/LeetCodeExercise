using System;

namespace MaximumSubarray
{
    // 53. (Easy)
    public class Solution
    {
        // Given an integer array nums, find the contiguous subarray (containing at least one number) 
        // which has the largest sum and return its sum.

        // Input: nums = [-2,1,-3,4,-1,2,1,-5,4], Output: 6, Explanation: [4,-1,2,1] has the largest sum = 6.
        // Input: nums = [5,4,-1,7,8], Output: 23

        public int MaxSubArray(int[] nums)
        {
            int max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] + nums[i] > nums[i])
                {
                    nums[i] += nums[i - 1];
                }

                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }

            return max;
        }
    }
}
