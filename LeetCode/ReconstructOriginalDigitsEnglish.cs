using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReconstructOriginalDigitsEnglish
    {
        public string OriginalDigits(string s)
        {
            var output = new List<string>();

            var zero = "zero".ToCharArray();
            var one = "one".ToCharArray();
            var two = "two".ToCharArray();
            var three = "three".ToCharArray();
            var four = "four".ToCharArray();
            var five = "five".ToCharArray();
            var six = "six".ToCharArray();
            var seven = "seven".ToCharArray();
            var eight = "eight".ToCharArray();
            var nine = "nine".ToCharArray();

            var numbers = new Dictionary<string, char[]>();
            numbers.Add("0", zero);
            numbers.Add("2", two);
            numbers.Add("6", six);
            numbers.Add("8", eight);
            numbers.Add("7", seven);
            numbers.Add("5", five);
            numbers.Add("4", four);
            numbers.Add("3", three);
            numbers.Add("1", one);
            numbers.Add("9", nine);

            var input = s;

            while (input.Length > 0)
            {
                foreach (var number in numbers)
                {
                    var hasNumber = true;
                    while (hasNumber)
                    {
                        foreach (var c in number.Value)
                        {
                            if (!input.Contains(c))
                            {
                                hasNumber = false;
                                break;
                            }
                        }

                        if (!hasNumber)
                        {
                            break;
                        }

                        foreach (var c in number.Value)
                        {
                            input = input.Remove(input.IndexOf(c), 1);
                        }

                        output.Add(number.Key);
                    }
                }
            }

            var result = new StringBuilder();
            foreach(var o in output.OrderBy(x => x))
            {
                result.Append(o);
            }

            return result.ToString();
        }
    }
}
