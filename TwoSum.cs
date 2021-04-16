using System;

namespace TwoSum
{
	public class Solution
	{
        // Given an array of integers nums and an integer target,
        // return indices of the two numbers such that they add up to target.

        // Input: nums = [2,7,11,15], target = 9, Output: [0,1]
        // Input: nums = [3,2,4], target = 6, Output: [1,2]

        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    return new int[] { dict[target - nums[i]], i };
                }
                else
                {
                    dict[nums[i]] = i;
                }
            }
            return null;
        }
    }
}

