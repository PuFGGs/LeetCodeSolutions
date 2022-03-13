using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            List<char> list = x.ToString().ToList();
            list.Remove('-');
            list.Reverse();

            int result = 0;

            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.Append(item.ToString());
            }

            result = int.TryParse(sb.ToString(), out int value) ? value : 0;

            if (x < 0)
                result *= -1;

            return result;
        }
    }
}
