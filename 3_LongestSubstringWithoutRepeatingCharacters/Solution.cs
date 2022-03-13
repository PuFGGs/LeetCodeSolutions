using System;
using System.Linq;
using System.Collections.Generic;

namespace _3_LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            List<char> temp = new List<char>();

            int longestFound = 0;
            int found = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (temp.Contains(c))
                {
                    int index = temp.FindIndex(x => x.Equals(c)) + 1;

                    temp = temp.Where(x => temp.FindIndex(y => y.Equals(x)) > index - 1).ToList();
                }
                temp.Add(c);

                found = temp.Count;
                longestFound = Math.Max(found, longestFound);
            }


            if (longestFound == 0)
                longestFound = temp.Count;

            return Math.Max(found, longestFound);
        }
    }
}
