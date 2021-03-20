using LeetCode;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest
{
    public class ZigZagConversionTest
    {
        [Theory]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [InlineData("A", 1, "A")]
        public void Test1(string input, int numOfRows, string expected)
        {
            var container = new ZigZagConversion();
            var result = container.Convert(input, numOfRows);

            Assert.Equal(expected, result);
        }
    }
}
