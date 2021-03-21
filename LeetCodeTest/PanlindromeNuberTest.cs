using LeetCode;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest
{
    public class PalindromeNumberTest
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(0, true)]
        [InlineData(5, true)]
        [InlineData(10, false)]
        [InlineData(-101, false)]
        public void Test1(int input, bool expected)
        {
            var container = new PalindromeNumber();
            var result = container.IsPalindrome(input);

            Assert.Equal(expected, result);
        }
    }
}