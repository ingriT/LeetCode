using LeetCode;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest
{
    public class ContainerWithMostWaterTest
    {
        [Theory]
        [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [InlineData(new int[] { 1, 1 }, 1)]
        [InlineData(new int[] { 2, 3 }, 2)]
        [InlineData(new int[] { 4, 3, 2, 1, 4}, 16)]
        [InlineData(new int[] { 1, 2, 1 }, 2)]
        public void Test1(int[] input, int expected)
        {
            var container = new ContainerWithMostWater();
            var result = container.MaxArea(input);

            Assert.Equal(expected, result);
        }
    }
}