using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingRetry
{
    public class MergeSort
    {
        public static int[] MergeSortList(int[] unsorted)
        {
            List<int> unsortedList = unsorted.ToList();
            if (unsortedList.Count <= 1)
            {
                return unsorted;
            }
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Length / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(unsortedList[i]);
            }
            for (int i = middle; i < unsortedList.Count; i++)
            {
                right.Add(unsortedList[i]);
            }
            int[] leftArray = MergeSortList(left.ToArray());
            int[] rightArray = MergeSortList(right.ToArray());
            return Merge(leftArray, rightArray);
        }

        private static int[] Merge(int[] left, int[] right)
        {
            List<int> leftList = left.ToList();
            List<int> rightList = right.ToList();
            List<int> result = new List<int>();
            while (leftList.Count > 0 || rightList.Count > 0)
            {
                if (leftList.First() <= rightList.First())
                {
                    result.Add(leftList.First());
                    leftList.Remove(left.First());
                }
                else
                {
                    result.Add(rightList.First());
                    rightList.Remove(rightList.First());
                }

            }
            while (leftList.Count > 0)
            {
                result.Add(leftList.First());
                leftList.Remove(leftList.First());
            }
            while (rightList.Count > 0)
            {
                result.Add(rightList.First());
                rightList.Remove(rightList.First());
            }
            int[] resultArray = result.ToArray();
            return resultArray;
        }
    }
}
