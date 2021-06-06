using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var output = new List<IList<int>>();

            if (nums.Length <= 2)
            {
                return output;
            }

            var input = nums.OrderBy(n => n).ToList();
            for (var count1 = 0; count1 < input.Count - 2; count1++)
            {
                for (var count2 = count1 + 1; count2 < input.Count - 1; count2++)
                {
                    var neededCount = 0 - (input[count1] + input[count2]);
                    if (input.FindIndex(count2 + 1, n => n == neededCount) > 0)
                    {
                        var outputList = new List<int> { input[count1], input[count2], neededCount };
                        var addNewOutput = true;

                        foreach (var outputL in output)
                        {
                            if (outputL[0] != outputList[0])
                            {
                                continue;
                            }

                            if (outputL[1] != outputList[1])
                            {
                                continue;
                            }

                            if (outputL[2] != outputList[2])
                            {
                                continue;
                            }

                            addNewOutput = false;
                            break;
                        }

                        if (addNewOutput)
                        {
                            output.Add(outputList);
                        }
                    }
                }
            }

            return output;
        }
    }
}
