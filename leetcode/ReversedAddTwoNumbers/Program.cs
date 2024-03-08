public class Solution
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    static void Main(string[] args)
    {
        ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3))); // Example values for l1
        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4))); // Example values for l2

        Solution solution = new Solution();

        ListNode result = solution.AddTwoNumbers(l1, l2); // Call the method and store the result

        // Print the values of the resulting linked list (optional for demonstration)
        ListNode current = result;
        while (current != null)
        {
            Console.Write(current.val + " ");
            current = current.next;
        }
        Console.WriteLine();
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new ListNode(0); // Create a dummy head node
        ListNode current = dummyHead;
        int carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            int val1 = l1 != null ? l1.val : 0;
            int val2 = l2 != null ? l2.val : 0;
            int sum = val1 + val2 + carry;

            carry = sum / 10;
            current.next = new ListNode(sum % 10);
            current = current.next;

            l1 = l1 != null ? l1.next : null;
            l2 = l2 != null ? l2.next : null;
        }

        return dummyHead.next;
    }
}
