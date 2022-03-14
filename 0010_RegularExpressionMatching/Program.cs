using System;

namespace _0010_RegularExpressionMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine("Needed Result : false | Output : {0}", solution.IsMatch("aa", "a"));
            Console.WriteLine("Needed Result : true | Output : {0}", solution.IsMatch("aa", "a*"));
            Console.WriteLine("Needed Result : true | Output : {0}", solution.IsMatch("ab", ".*"));
            Console.WriteLine("Needed Result : true | Output : {0}", solution.IsMatch("aab", "c*a*b"));
            Console.WriteLine("Needed Result : true | Output : {0}", solution.IsMatch("mississippi", "mis*is*ip*."));
            Console.WriteLine("Needed Result : false | Output : {0}", solution.IsMatch("mississippi", "mis*is*p*."));
        }
    }
}
