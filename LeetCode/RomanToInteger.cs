using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class RomanToInteger
    {
        /// <summary>
        /// I can be placed before V(5) and X(10) to make 4 and 9.
        /// X can be placed before L(50) and C(100) to make 40 and 90.
        /// C can be placed before D(500) and M(1000) to make 400 and 900.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int RomanToInt(string s)
        {
            var output = 0;

            var romanInts = new Dictionary<int, string>()
            { {1000, "M" },{500, "D" },{100, "C" },{50, "L" },{10, "X" },{5, "V" }, {1, "I" } };

            while (s.Length > 0)
            {
                string prevRoman = null;
                int prevRomanInt = 0;

                string prevPrevRoman = null;
                int prevPrevRomanInt = 0;

                foreach (var romanInt in romanInts)
                {
                    if (s.StartsWith(romanInt.Value))
                    {
                        if (s.Substring(0, 1).Equals("I") ||
                            s.Substring(0, 1).Equals("X") ||
                            s.Substring(0, 1).Equals("C"))
                        {
                            if (s.Length > 1)
                            {
                                var secondChar = s.Substring(1, 1);
                                if (secondChar.Equals(prevPrevRoman))
                                {
                                    output += prevPrevRomanInt;
                                    output = output - romanInt.Key;

                                    s = s.Substring(2);
                                    break;
                                }

                                if (secondChar.Equals(prevRoman))
                                {
                                    output += prevRomanInt;
                                    output = output - romanInt.Key;

                                    s = s.Substring(2);
                                    break;
                                }
                            }
                        }

                        output += romanInt.Key;

                        s = s.Substring(1);
                        break;
                    }

                    if (prevRoman != null)
                    {
                        prevPrevRoman = prevRoman;
                        prevPrevRomanInt = prevRomanInt;
                    }
                    prevRoman = romanInt.Value;
                    prevRomanInt = romanInt.Key;
                }
            }

            return output;
        }
    }
}
