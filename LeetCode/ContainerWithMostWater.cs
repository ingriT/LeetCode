using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            if (height.Length == 2)
            {
                return height.OrderBy(i => i).First();
            }

            return height[0];
        }
    }
}
