using System;

namespace MergeTwoSortedLists
{
    // 21. (Easy)
    public class Solution
    {
        // Merge two sorted linked lists and return it as a sorted list. 
        // The list should be made by splicing together the nodes of the first two lists.

        // Input: l1 = [1,2,4], l2 = [1,3,4], Output: [1,1,2,3,4,4]
        // Input: l1 = [], l2 = [0], Output: [0]

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode newList = new ListNode(-1);
            ListNode temp = newList;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    temp.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    temp.next = l2;
                    l2 = l2.next;
                }
                temp = temp.next;
            }

            temp.next = (l1 != null) ? l1 : l2;
            return newList.next;
        }
    }
}

