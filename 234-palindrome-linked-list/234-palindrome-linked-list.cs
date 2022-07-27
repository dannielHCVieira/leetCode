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
    public bool IsPalindrome(ListNode head) {
        Stack<int> stackedList = new Stack<int>();
        
        ListNode current = head;
        while(current != null){
            stackedList.Push(current.val);
            current = current.next;
        }
        
        current = head;
        bool result = true;
        foreach(int i in stackedList){
            if(i != current.val){
                result = false;
            }
            current = current.next;
        }
        return result;
    }
}