using LeetCode;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest
{
    public class MedianTwoSortedArraysTest
    {
        [Fact]
        public void Test1()
        {
            var l1 = new int[] { };
            var l2 = new int[] { };
            double output = 0;

            var container = new MedianTwoSortedArrays();
            var result = container.FindMedianSortedArrays(l1, l2);

            Assert.Equal(output, result);
        }

        [Fact]
        public void Test2()
        {
            var l1 = new int[] { 1, 3 };
            var l2 = new int[] { 2 };
            double output = 2;

            var container = new MedianTwoSortedArrays();
            var result = container.FindMedianSortedArrays(l1, l2);

            Assert.Equal(output, result);
        }

        [Fact]
        public void Test3()
        {
            var l1 = new int[] { 0, 0, 0, 0, 0 };
            var l2 = new int[] { -1, 0, 0, 0, 0, 0, 1 };
            double output = 0;

            var container = new MedianTwoSortedArrays();
            var result = container.FindMedianSortedArrays(l1, l2);

            Assert.Equal(output, result);
        }


        [Fact]
        public void Test4()
        {
            var l1 = new int[] { 1, 3 };
            var l2 = new int[] { 2, 7 };
            double output = 2.5;

            var container = new MedianTwoSortedArrays();
            var result = container.FindMedianSortedArrays(l1, l2);

            Assert.Equal(output, result);
        }
    }
}
