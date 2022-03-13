using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0006_ZigzagConversion
{
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows <= 1) return s;

            StringBuilder result = new StringBuilder();
            List<StringBuilder> rows = new List<StringBuilder>();
            int n = s.Length;
            int cycleLen = 2 * numRows - 2;

            for (int i = 0; i < numRows; i++)
                rows.Add(new StringBuilder());

            bool down = false;
            int currentRow = 0;

            foreach (char c in s.ToCharArray())
            {
                rows[currentRow].Append(c);
                if (currentRow == 0 || currentRow == numRows - 1) down = !down;
                currentRow += down ? 1 : -1;
            }

            foreach (StringBuilder item in rows)
                result.Append(item);

            return result.ToString();
        }
    }
}
