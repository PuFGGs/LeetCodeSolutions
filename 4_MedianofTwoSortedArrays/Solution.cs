using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MedianofTwoSortedArrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> mergedList = new List<int>();
            List<double> resultList = new List<double>();

            mergedList.AddRange(nums1);
            mergedList.AddRange(nums2);
            mergedList.Sort();

            if (mergedList.Count % 2 == 0)
            {
                resultList.Add(mergedList[mergedList.Count / 2]);
                resultList.Add(mergedList[(mergedList.Count / 2) - 1]);
            }
            else
            {
                resultList.Add(mergedList[mergedList.Count / 2]);
            }
            return resultList.Sum() / resultList.Count;
        }
    }
}
