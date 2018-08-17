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
            List<int> left = null;
            List<int> right = null;

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
            return Merge(left, right);
        }

        private static int[] Merge(List<int> left, List<int> right)
        {
            List<int> result = null;
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            int[] resultArray = result.ToArray();
            return resultArray;
        }
    }
}
