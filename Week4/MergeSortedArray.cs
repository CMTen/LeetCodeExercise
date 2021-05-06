using System;

namespace MergeSortedArray
{
    // 88. (Easy)
    public class Solution
    {
        // Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
        // The number of elements initialized in nums1 and nums2 are m and n respectively.
        // You may assume that nums1 has a size equal to m + n such that it has enough space to hold additional elements from nums2.

        // Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3, Output: [1,2,2,3,5,6]
        // Input: nums1 = [1], m = 1, nums2 = [], n = 0, Output: [1]

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1, j = n - 1, index = m + n - 1;

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[index] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[index] = nums2[j];
                    j--;
                }

                index--;
            }

            // No need to handle i >= 0 case. If it's the case, the remaining numbers are already in nums1.
            while (j >= 0)
            {
                nums1[index] = nums2[j];
                index--;
                j--;
            }
        }
    }
}
