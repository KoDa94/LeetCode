
using System.Globalization;
using System.Runtime.CompilerServices;

public class Solution83Easy
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null) { return null; }

        var tail = head;

        while (tail.next != null)
        {
            if (tail.val == tail.next.val)
            {
                tail.next = tail.next.next;
            }
            else
            {
                tail = tail.next;
            }
        }

        return head;
    }
}