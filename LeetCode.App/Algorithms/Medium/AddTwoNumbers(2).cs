using System.Transactions;

public class Solution2Medium
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode l3 = new ListNode(0);
        var tail3 = l3;
        int carry = 0;

        while (l1 != null || l2 != null)
        {
            int a = 0;
            int b = 0;
            
            if (l1 != null)
            {
                a = l1.val;
                l1 = l1.next;
            }

            if (l2 != null)
            {
                b = l2.val;
                l2 = l2.next;
            }

            int sum = a + b + carry;
            carry = sum / 10;

            tail3.next = new ListNode(sum % 10);
            tail3 = tail3.next;
        }

        if (carry > 0)
        {
            tail3.next = new ListNode(carry);
        }

        return l3.next;
    }
}