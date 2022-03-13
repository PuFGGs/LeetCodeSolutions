using System;

namespace _1_TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Solution solution = new Solution();

            foreach (var item in solution.TwoSum(new int[] { 3, 2, 3 }, 6))
            {
                Console.WriteLine(item);
            }
        }
    }
}
