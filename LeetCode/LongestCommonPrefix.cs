using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class GetLongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var output = "";
            var error = false;

            while (strs[0].Length > 0 && !error)
            {
                var letter = strs[0].Substring(0, 1);
                strs[0] = strs[0].Substring(1);

                for (var i = 1; i < strs.Length; i++)
                {
                    if (strs[i].Length == 0 || strs[i].Substring(0, 1) != letter)
                    {
                        error = true;
                        break;
                    }

                    strs[i] = strs[i].Substring(1);
                }

                if (!error)
                {
                    output += letter;
                }
            }

            return output;
        }
    }
}
