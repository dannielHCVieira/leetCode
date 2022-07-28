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
    public ListNode MiddleNode(ListNode head) {
        ListNode pointer = head;
        int size = ListNodeSize(head),
            i = 0;
        while(i != size/2){
            pointer = pointer.next;
            i++;
        }
        
        return pointer;
    }
    
    public int ListNodeSize(ListNode head) {
        ListNode pointer = head;
        int size = 0;
        while(pointer != null){
            pointer = pointer.next;
            size++;
        }
        return size;
    }
    
}