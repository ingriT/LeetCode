using LeetCode;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest
{
    public class AddTwoNumbersTest
    {
        [Fact]
        public void Test1()
        {
            var l1 = new ListNode();
            var l2 = new ListNode();

            var container = new AddTwoNumbersContainer();
            var result = container.AddTwoNumbers(l1, l2);

            Assert.True(result is ListNode);
        }

        [Fact]
        public void Test2()
        {
            var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            var output = new ListNode(7, new ListNode(0, new ListNode(8)));

            var container = new AddTwoNumbersContainer();
            var result = container.AddTwoNumbers(l1, l2);

            Assert.Equal(output.val, result.val);
            Assert.Equal(output.next.val, result.next.val);
            Assert.Equal(output.next.next.val, result.next.next.val);
        }

        [Fact]
        public void Test3()
        {
            var l1 = new ListNode(0);
            var l2 = new ListNode(0);
            var output = new ListNode(0);

            var container = new AddTwoNumbersContainer();
            var result = container.AddTwoNumbers(l1, l2);

            Assert.Equal(output.val, result.val);
            Assert.Equal(output.next, result.next);
        }
    }
}
