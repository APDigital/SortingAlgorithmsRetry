using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingRetry
{
    public class SelectSort
    {
        public static int[] Select(int[] arr)
        {
            int smallestIndex, index, minIndex, temp;
            for (index = 0; index < arr.Length; index++)
            {
                smallestIndex = index;
                for (minIndex = 0; minIndex < arr.Length; minIndex++)
                {
                    if (arr[minIndex] < arr[smallestIndex])
                    {
                        smallestIndex = minIndex;
                    }
                    temp = arr[smallestIndex];
                    arr[smallestIndex] = arr[index];
                    arr[index] = temp;
                }
            }
            return arr;
        }
    }
}
        
