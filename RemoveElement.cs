using System;

namespace RemoveElement
{
    // 27. (Easy)
    public class Solution
    {
        // Given an array nums and a value val, 
        // remove all instances of that value in-place and return the new length.

        // Input: nums = [3,2,2,3], val = 3, Output: 2, nums = [2,2]
        // Input: nums = [0,1,2,2,3,0,4,2], val = 2, Output: 5, nums = [0,1,4,0,3]

        public int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            foreach (int num in nums)
            {
                if (num != val) 
                { 
                    nums[i++] = num; 
                }                    
            }
            return i;
        }
    }
}
