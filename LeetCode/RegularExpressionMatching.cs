using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RegularExpressionMatching
    {
        /**
         *  '.' Matches any single character.​​​​
         *  '*' Matches zero or more of the preceding element.
        */
        public bool IsMatch(string s, string p)
        {
            return new System.Text.RegularExpressions.Regex(String.Concat("^", p, "$")).Match(s).Success;
        }
    }
}
