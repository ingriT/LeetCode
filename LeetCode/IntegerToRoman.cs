using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class IntegerToRoman
    {
        /// <summary>
        /// I can be placed before V(5) and X(10) to make 4 and 9.
        /// X can be placed before L(50) and C(100) to make 40 and 90.
        /// C can be placed before D(500) and M(1000) to make 400 and 900.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string IntToRoman(int num)
        {
            var romanInts = new Dictionary<int, string>()
            { {1000, "M" },{500, "D" },{100, "C" },{50, "L" },{10, "X" },{5, "V" }, {1, "I" } };

            if (romanInts.ContainsKey(num))
            {
                return romanInts[num];
            }

            var output = "";

            foreach (var romanInt in romanInts)
            {
                while ((num / romanInt.Key) >= 1)
                {
                    output = output + romanInt.Value;
                    num = num - romanInt.Key;
                }

                if (num == 0)
                {
                    break;
                }

                if (romanInt.Key <= 10 && num > (romanInt.Key - 2) && (num + 1 / romanInt.Key) >= 1)
                {
                    if ((num + 1 - romanInt.Key) < 0)
                    {
                        continue;
                    }

                    output = output + romanInts[1] + romanInt.Value;
                    num = num + 1 - romanInt.Key;
                }
                else if (romanInt.Key > 10 && romanInt.Key <= 100 && num > (romanInt.Key - 20) && (num + 10 / romanInt.Key) >= 1)
                {
                    if ((num + 10 - romanInt.Key) < 0)
                    {
                        continue;
                    }

                    output = output + romanInts[10] + romanInt.Value;
                    num = num + 10 - romanInt.Key;
                }
                else if (romanInt.Key > 100 && romanInt.Key <= 1000 && num > (romanInt.Key - 200) && (num + 100 / romanInt.Key) >= 1)
                {
                    if ((num + 100 - romanInt.Key) < 0)
                    {
                        continue;
                    }

                    output = output + romanInts[100] + romanInt.Value;
                    num = num + 100 - romanInt.Key;
                }
            }

            return output;
        }
    }
}
