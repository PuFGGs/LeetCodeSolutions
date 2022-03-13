using System;

namespace _0009_PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine("Needed Result : true | Output : {0}", solution.IsPalindrome(121));
            Console.WriteLine("Needed Result : false | Output : {0}", solution.IsPalindrome(-121));
            Console.WriteLine("Needed Result : false | Output : {0}", solution.IsPalindrome(10));
            Console.WriteLine("Needed Result : true | Output : {0}", solution.IsPalindrome(11));
        }
    }
}
