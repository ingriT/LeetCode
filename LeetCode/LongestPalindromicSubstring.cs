using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            if (s.Length == 1)
            {
                return s;
            }

            var longest = s.Substring(0, 1);

            for (var startIndex = 0; startIndex < s.Length; startIndex++)
            {
                for (var endIndex = startIndex + longest.Length; endIndex <= s.Length; endIndex++)
                {
                    var inputValue = s.Substring(startIndex, endIndex - startIndex);

                    if (inputValue.Length > longest.Length)
                    {
                        var len = inputValue.Length;
                        var half = len-- >> 1;
                        var found = true;
                        for (int i = 0; i < half; i++)
                        {
                            if (inputValue[i] != inputValue[len - i])
                            {
                                found = false;
                                break;
                            }
                        }
                        if (found)
                        {
                            longest = inputValue;
                        }
                    }
                }
            }

            return longest;
        }
    }
}
