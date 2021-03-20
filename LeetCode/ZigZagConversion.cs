using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ZigZagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            var word = s.ToCharArray();

            Dictionary<int, string> rows = new Dictionary<int, string>();
            var i = 1;
            while (i <= numRows)
            {
                rows.Add(i, string.Empty);
                i++;
            }

            var down = true;
            var currentRow = 1;

            foreach (var c in word)
            {
                rows[currentRow] = rows[currentRow] + c;

                if (currentRow == 1)
                {
                    down = true;
                }
                else if (currentRow == numRows)
                {
                    down = false;
                }

                if (down)
                {
                    currentRow++;
                }
                else
                {
                    currentRow--;
                }
            }

            var output = string.Empty;
            foreach(var row in rows)
            {
                output += row.Value;
            }
            return output;
        }
    }
}
