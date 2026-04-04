/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {    
    public ListNode MergeKLists(ListNode[] lists) {
        /*  
            if list.count == 1 return,
            else:
            break list in half,
            call MergeKLists on each half and store in two lists,
            insertion sort on both lists.
        */ 

        if(lists.Length == 0) {
            return null;
        } else if(lists.Length == 1) {
            return lists[0];
        }

        int mid = (lists.Length / 2);
        List<ListNode> lists1 = new List<ListNode>();
        List<ListNode> lists2 = new List<ListNode>();

        int cursor = 0;
        while (cursor < mid){
            lists1.Add(lists[cursor]);
            cursor++;
        }
        while (cursor < lists.Length){
            lists2.Add(lists[cursor]);
            cursor++;
        }

        ListNode curr1 = MergeKLists(lists1.ToArray());
        ListNode curr2 = MergeKLists(lists2.ToArray());
        ListNode sortedlist = new ListNode();
        ListNode sortedhead = sortedlist;

        while(curr1 != null && curr2 != null) {
            if(curr1.val < curr2.val) {
                sortedlist.next = new ListNode(curr1.val);
                if(curr1.next != null) {
                    curr1 = curr1.next;
                } else {
                    curr1 = null;
                }
            } else {
                sortedlist.next = new ListNode(curr2.val);
                if(curr2.next != null) {
                    curr2 = curr2.next;
                } else {
                    curr2 = null;
                }
            }
            sortedlist = sortedlist.next;
        }

        while(curr1 != null) {
            sortedlist.next = new ListNode(curr1.val);
            sortedlist = sortedlist.next;
            if(curr1.next != null) {
                curr1 = curr1.next;
            } else {
                break;
            }
        }

        while(curr2 != null){
            sortedlist.next = new ListNode(curr2.val);
            sortedlist = sortedlist.next;
            if(curr2.next != null) {
                curr2 = curr2.next;
            } else {
                break;
            }
        }

        return sortedhead.next;
    }
}
