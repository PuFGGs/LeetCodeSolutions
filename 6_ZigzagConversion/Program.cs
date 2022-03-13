using System;

namespace _6_ZigzagConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine("Needed Result : PAHNAPLSIIGYIR | Output : {0}", solution.Convert("PAYPALISHIRING", 3));
            Console.WriteLine("Needed Result : PINALSIGYAHRPI | Output : {0}", solution.Convert("PAYPALISHIRING", 4));
            Console.WriteLine("Needed Result : A | Output : {0}", solution.Convert("A", 1));
        }
    }
}
