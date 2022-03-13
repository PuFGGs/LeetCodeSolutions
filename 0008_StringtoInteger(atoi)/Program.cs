using System;

namespace _0008_StringtoInteger_atoi_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine("Needed Result : 42 | Output : {0}", solution.MyAtoi("42"));
            Console.WriteLine("Needed Result : -42 | Output : {0}", solution.MyAtoi("   -42"));
            Console.WriteLine("Needed Result : 4193 | Output : {0}", solution.MyAtoi("4193 with words"));
            Console.WriteLine("Needed Result : 0 | Output : {0}", solution.MyAtoi("words and 987"));
            Console.WriteLine("Needed Result : -2147483648 | Output : {0}", solution.MyAtoi("-91283472332"));
            Console.WriteLine("Needed Result : 0 | Output : {0}", solution.MyAtoi("-+12"));
            Console.WriteLine("Needed Result : 3 | Output : {0}", solution.MyAtoi("3.14159"));
            Console.WriteLine("Needed Result : 0 | Output : {0}", solution.MyAtoi("+"));
        }
    }
}
