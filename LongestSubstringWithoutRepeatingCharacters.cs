using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            var longest = 0;
            var current = 0;

            var charInput = s.ToCharArray();
            var charsSeen = new List<char>();

            for (var startIndex = 0; startIndex < charInput.Length; startIndex++)
            {
                if (charInput.Length - startIndex < longest)
                {
                    break;
                }

                current = 0;
                charsSeen = new List<char>();

                for (var charIndex = startIndex; charIndex < charInput.Length; charIndex++)
                {
                    var currentChar = charInput[charIndex];

                    if (charsSeen.Contains(currentChar))
                    {
                        break;
                    }

                    current++;

                    charsSeen.Add(currentChar);
                }

                if (current > longest)
                {
                    longest = current;
                }
            }

            return longest;
        }
    }
}
