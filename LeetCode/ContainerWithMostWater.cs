using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int size = height.Length;
            if (size == 1) { return 0; }
            if (size == 2) { return Math.Min(height[0], height[1]); }

            int left = 0;
            int right = size - 1;
            int max_area = 0;

            while (left != right)
            {
                if (height[left] < height[right])
                {
                    max_area = Math.Max(max_area, height[left] * (right - left));
                    left++;
                }
                else
                {
                    max_area = Math.Max(max_area, height[right] * (right - left));
                    right--;
                }
            }
            return max_area;
        }
    }
}
