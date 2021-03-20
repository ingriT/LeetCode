using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AddTwoNumbersContainer
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode emptyNode = new ListNode(0);
            ListNode currentNode = new ListNode(0);
            ListNode output = currentNode;

            while (l1 != emptyNode || l2 != emptyNode)
            {
                var sum = l1.val + l2.val + carry;
                carry = sum / 10;

                currentNode = (currentNode.next = new ListNode(sum %= 10));
                l1 = null != l1.next ? l1.next : emptyNode;
                l2 = null != l2.next ? l2.next : emptyNode;
            }

            if (carry == 1)
            {
                currentNode.next = new ListNode(carry);
            }

            return output.next;
        }
    }

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
}
