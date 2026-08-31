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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int carry= 0;
        ListNode totalSum = new ListNode();
        ListNode temp = totalSum;
        int sum = 0;
        while(l1 is not null && l2 is not null)
        {
            sum = 0;
            sum = l1.val + l2.val+carry;
            carry = 0;
            if(sum >= 10){
                carry = sum/10;//The extra 10-1 to push the number to the next integers.
                sum = sum %10 ;
            }
            Console.WriteLine($"sum:{sum}  carry:{carry}");
            temp.val = sum;
            l1 = l1.next ;
            l2 = l2.next ;
            sum = 0;
            if(l1 is not null && l2 is not null)
            {
            temp.next = new ListNode();
            temp=temp.next;
            }
        }
        while(l1 is not null)
        {
            sum = 0;
            sum = l1.val + carry;
            carry = 0;
            if(sum >= 10){
                carry = sum/10;//The extra 10-1 to push the number to the next integers.
                sum = sum%10 ;
            }
            temp.next = new ListNode(){
                val = sum
            };
            temp = temp.next;
            l1 = l1.next;
        }

        while(l2 is not null)
        {
            sum =0;
            sum = l2.val + carry;
            carry = 0;
            if(sum >= 10){
                carry = sum/10;//The extra 10-1 to push the number to the next integers.
                sum = sum%10 ;
            }
            temp.next = new ListNode(){
                val = sum
            };
            temp = temp.next;
            
            l2 = l2.next;
            
        }
        if(carry != 0)
        {
            temp.next = new ListNode(){
                val = carry
            };
            
        }
        return totalSum;
    }
}
