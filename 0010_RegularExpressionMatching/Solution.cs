using System.Text.RegularExpressions;

namespace _0010_RegularExpressionMatching
{
    public class Solution
    {
        public bool IsMatch(string s, string p) => Regex.IsMatch(s, "^" + p + "$");
    }
}