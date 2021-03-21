using System;
using System.Text;

namespace LeetCode
{
    public class StringToInteger
    {
        public int MyAtoi(string s)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(s.Trim()))
            {
                return 0;
            }

            var negative = false;
            var input = s.Trim();
            var firstChar = input.Substring(0, 1);
            var outputString = new StringBuilder();

            if (firstChar.Equals("-") && input.Length > 1)
            {
                negative = true;
                firstChar = input.Substring(1, 1);
                input = input.Substring(1);
            }
            else if (firstChar.Equals("+") && input.Length > 1)
            {
                firstChar = input.Substring(1, 1);
                input = input.Substring(1);
            }
            
            if (!Int32.TryParse(firstChar, out var _))
            {
                return 0;
            }

            var startIndex = 1;
            outputString.Append(firstChar);

            while (startIndex < input.Length)
            {
                var nextChar = input.Substring(startIndex, 1);
                if (Int32.TryParse(nextChar, out var _))
                {
                    outputString.Append(nextChar);
                    startIndex++;
                }
                else
                {
                    break;
                }
            }

            int output = 0;

            if (!Int32.TryParse(outputString.ToString(), out output))
            {
                if (outputString.Length > 0)
                {
                    output = Int32.MaxValue;
                    if (negative)
                    {
                        output = output + 1;
                    }
                }
            }

            if (negative)
            {
                output = 0 - output;
            }

            return output;
        }
    }
}
