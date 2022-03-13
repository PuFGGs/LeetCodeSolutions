using System;

namespace _5_LongestPalindromicSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine("Needed Result : bab or aba | Output : {0}", solution.LongestPalindrome("babad"));
            Console.WriteLine("Needed Result : bb | Output : {0}", solution.LongestPalindrome("cbbd"));
            Console.WriteLine("Needed Result : a | Output : {0}", solution.LongestPalindrome("a"));
            Console.WriteLine("Needed Result : bb | Output : {0}", solution.LongestPalindrome("bb"));
        }
    }
}
