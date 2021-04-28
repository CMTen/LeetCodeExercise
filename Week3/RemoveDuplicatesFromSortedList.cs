using System;

namespace RemoveDuplicatesFromSortedList
{
    // 83. (Easy)
    public class Solution
    {
        // Given the head of a sorted linked list, delete all duplicates such that each element appears only once. 
        // Return the linked list sorted as well.

        // Input: head = [1,1,2], Output: [1,2]
        // Input: head = [1,1,2,3,3], Output: [1,2,3]

        public ListNode DeleteDuplicates(ListNode head)
        {
            var temp = head;

            while (head != null && head.next != null)
            {
                if (head.val == head.next.val)
                {
                    head.next = head.next.next;
                }
                else
                {
                    head = head.next;
                }
            }

            return temp;
        }
    }
}
