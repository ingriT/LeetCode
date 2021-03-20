using LeetCode;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest
{
    public class ReverseIntegerTest
    {
        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(0, 0)]
        [InlineData(1534236469, 0)]
        public void Test1(int input, long expected)
        {
            var container = new ReverseInteger();
            var result = container.Reverse(input);

            Assert.Equal(expected, result);
        }
    }
}