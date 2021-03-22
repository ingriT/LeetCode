using LeetCode;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest
{
    public class RegularExpressionMatchingTest
    {
        [Theory]
        [InlineData("aa", "a", false)]
        [InlineData("aa", "a*", true)]
        [InlineData("aa", "*a", true)]
        [InlineData("ab", ".*", true)]
        [InlineData("aab", "c*a*b", true)]
        [InlineData("mississippi", "mis*is*p*.", false)]
        [InlineData("mississippi", "mis*is*ip*.", true)]
        public void Test1(string input, string pattern, bool expected)
        {
            var container = new RegularExpressionMatching();
            var result = container.IsMatch(input, pattern);

            Assert.Equal(expected, result);
        }
    }
}
