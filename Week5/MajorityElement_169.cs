using System;

namespace MajorityElement_169
{
    // 169. (Easy)
    public class Solution
    {
        // Given an array nums of size n, return the majority element.
        // The majority element is the element that appears more than [n / 2] times.You may assume that the majority element always exists in the array.

        // Input: nums = [3,2,3], Output: 3
        // Input: nums = [2,2,1,1,1,2,2], Output: 2

        public int MajorityElement(int[] nums)
        {
            int major = nums[0];
            int count = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    major = nums[i];
                    count++;
                }
                else
                {
                    if (major == nums[i])
                    {
                        count++;
                    }
                    else
                    {
                        count--;
                    }
                }
            }

            return major;
        }
    }
}
