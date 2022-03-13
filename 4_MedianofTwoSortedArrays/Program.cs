using System;

namespace _4_MedianofTwoSortedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine("Needed Result : 2 | Output : {0}", solution.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 }));
            Console.WriteLine("Needed Result : 2.5 | Output : {0}", solution.FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 }));
        }
    }
}
