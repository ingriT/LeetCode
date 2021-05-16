using LeetCode;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest
{
    public class LongestCommonPrefixTest
    {
        [Theory]
        [InlineData(new [] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new[] { "dog", "racecar", "car" }, "")]
        [InlineData(new[] { "aa", "aa" }, "aa")]
        public void Test1(string[] input, string expected)
        {
            var container = new GetLongestCommonPrefix();
            var result = container.LongestCommonPrefix(input);

            Assert.Equal(expected, result);
        }
    }
}