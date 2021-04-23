﻿using System;

namespace SearchInsertPosition
{
    // 35. (Easy)
    public class Solution
    {
        // Given a sorted array of distinct integers and a target value, 
        // return the index if the target is found. 
        // If not, return the index where it would be if it were inserted in order.

        // Input: nums = [1,3,5,6], target = 2, Output: 1
        // Input: nums = [1,3,5,6], target = 7, Output: 4
        // Input: nums = [1,3,5,6], target = 0, Output: 0

        public int SearchInsert(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (target < nums[mid])
                {
                    high = mid - 1;
                }
                else if (target > nums[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    return mid;
                }              
            }

            return low;
        }
    }
}
