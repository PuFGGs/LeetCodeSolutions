using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0005_LongestPalindromicSubstring
{
    public class Solution
    {
        string result = "";
        public string LongestPalindrome(string s)
        {
            result = "";
            for (int i = 0; i < s.Length; i++)
            {
                CheckString(s, i, i);
                CheckString(s, i, i + 1);
            }
            return result;
        }

        void CheckString(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                if (right - left + 1 > result.Length)
                {
                    result = s.Substring(left, right - left + 1);
                }
                left--;
                right++;
            }
        }
    }
}
