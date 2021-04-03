using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    //TODO THIS IS TOO SLOW
    public class ReconstructOriginalDigitsEnglish
    {
        public string OriginalDigits(string s)
        {
            var output = new List<string>();

            var zero = "zero".ToCharArray();
            var two = "wto".ToCharArray();
            var six = "xis".ToCharArray();
            var four = "ufor".ToCharArray();
            var three = "rthee".ToCharArray();
            var one = "one".ToCharArray();
            var five = "five".ToCharArray();
            var seven = "seven".ToCharArray();
            var eight = "geiht".ToCharArray();
            var nine = "nine".ToCharArray();

            var numbers = new Dictionary<string, char[]>();
            numbers.Add("0", zero);
            numbers.Add("2", two);
            numbers.Add("6", six);
            numbers.Add("4", four);
            numbers.Add("3", three);
            numbers.Add("1", one);
            numbers.Add("5", five);
            numbers.Add("7", seven);
            numbers.Add("8", eight);
            numbers.Add("9", nine);

            var input = s.ToList();

            while (input.Count > 0)
            {
                foreach (var number in numbers)
                {
                    while (true)
                    {
                        if (!input.Contains(number.Value[0]))
                        {
                            break;
                        }

                        foreach (var c in number.Value)
                        {
                            input.Remove(c);
                        }

                        output.Add(number.Key);
                    }
                }
            }

            var result = new StringBuilder();
            foreach (var o in output.OrderBy(o => o))
            {
                result.Append(o);
            }
            return result.ToString();
        }
    }
}
