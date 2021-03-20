using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            if (x > -10 && x < 10)
            {
                return x;
            }

            var inputValue = (x < 0 ? 0 - x : x).ToString().ToArray();
            var outputValue = new StringBuilder();
            var len = inputValue.Length;
            for (int i = 1; i <= len; i++)
            {
                outputValue.Append(inputValue[len - i]);
            }

            try
            {
                var result = outputValue.ToString();
                if (x < 0)
                {
                    return 0 - Int32.Parse(result);
                }
                else
                {
                    return Int32.Parse(result);
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}