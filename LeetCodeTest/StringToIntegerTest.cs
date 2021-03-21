using LeetCode;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest
{
    public class StringToIntegerTest
    {
        [Theory]
        [InlineData("42", 42)]
        [InlineData("   -42", -42)]
        [InlineData("4193 with words", 4193)]
        [InlineData("words and 987", 0)]
        [InlineData("-91283472332", -2147483648)]
        [InlineData("+-12", 0)]
        [InlineData("", 0)]
        [InlineData("+", 0)]
        [InlineData("-", 0)]
        [InlineData("21474836460", 2147483647)]
        [InlineData("-2147483647", -2147483647)]
        public void Test1(string input, int expected)
        {
            var container = new StringToInteger();
            var result = container.MyAtoi(input);

            Assert.Equal(expected, result);
        }
    }
}
