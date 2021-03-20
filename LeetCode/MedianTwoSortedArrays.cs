using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MedianTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var allNums = nums1.ToList();
            allNums.AddRange(nums2.ToList());
            allNums.Sort();

            if (allNums.Count == 0)
            {
                return 0;
            }

            if (allNums.Count() % 2 == 0)
            {
                double num1 = allNums[(allNums.Count() / 2)];
                double num2 = allNums[(allNums.Count() / 2) - 1];
                if ((num1 + num2) > 0)
                {
                    return (num1 + num2) / 2;
                }
                else
                {
                    return 0;
                }
            }

            return allNums[(allNums.Count() - 1) / 2];
        }
    }
}
