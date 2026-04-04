/**
 * Definition for singly-linked list.
 * class ListNode {
 *     constructor(val = 0, next = null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

class Solution {
    /**
     * @param {ListNode} head
     * @return {ListNode}
     */
    prev = null;
    cursor = null;
    reverseList(head) {
        if(head != null) {
            let next = null;
            if(head.next != null){
                next = head.next;
            }
            head.next = this.prev;
            this.prev = head;
            this.cursor = this.reverseList(next);
            return this.cursor;
        } else {
            return this.prev;
        }
    }
}
