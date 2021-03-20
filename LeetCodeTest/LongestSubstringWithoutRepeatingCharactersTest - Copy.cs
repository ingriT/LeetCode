using LeetCode;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest
{
    public class LongestSubstringWithoutRepeatingCharactersTest
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("", 0)]
        [InlineData(" ", 1)]
        [InlineData("au", 2)]
        public void Test1(string input, int length)
        {
            var container = new LongestSubstringWithoutRepeatingCharacters();
            var result = container.LengthOfLongestSubstring(input);

            Assert.Equal(length, result);
        }
    }
}
