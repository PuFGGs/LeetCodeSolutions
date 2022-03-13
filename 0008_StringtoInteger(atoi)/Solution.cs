using System;
using System.Linq;

namespace _0008_StringtoInteger_atoi_
{
    public class Solution
    {
        public int MyAtoi(string s)
        {
            string resultString = s.Trim();
            bool negative = resultString.StartsWith('-');
            bool pozitveSign = resultString.StartsWith('+');
            int n = negative ? 1 : pozitveSign ? 1 : 0;
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            if (n >= resultString.Length)
                return 0;

            for (; n < resultString.Length; n++)
            {
                char currentChar = resultString[n];

                if (numbers.Contains(currentChar))
                    continue;

                if (n == 1 && (negative || pozitveSign))
                    return 0;
                resultString = resultString.Remove(n);
            }

            if (resultString.Length == 0)
                return 0;

            int resultInt = int.TryParse(resultString, out int value) ? value : negative ? Int32.MinValue : Int32.MaxValue;

            return resultInt;
        }
    }
}