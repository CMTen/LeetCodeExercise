using System;

namespace RemoveDuplicatesFromSortedArray
{
	public class Solution
	{
        // Given a sorted array nums, remove the duplicates in-place such that
        // each element appears only once and returns the new length.

        // Input: nums = [1,1,2], Output: 2, nums = [1,2]
        // Input: nums = [0,0,0,1,2,2,3,3,4], Output: 5, nums = [0,1,2,3,4]

        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            var length = nums.Length;

            int index = 0;
            for (int i = 0; i < length; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    nums[index++] = nums[i];
                }
            }

            return index;
        }
    }
}