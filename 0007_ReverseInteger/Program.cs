using System;

namespace _0007_ReverseInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine("Needed Result : 321 | Output : {0}", solution.Reverse(123));
            Console.WriteLine("Needed Result : -321 | Output : {0}", solution.Reverse(-123));
            Console.WriteLine("Needed Result : 21 | Output : {0}", solution.Reverse(120));
            Console.WriteLine("Needed Result : 0 | Output : {0}", solution.Reverse(1534236469));
        }
    }
}
