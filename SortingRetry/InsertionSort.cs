using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingRetry
{
    public class InsertionSort
    {
        public static int[] Insert(int[] arr)
        {
            int index, temp, indexPlus;
            for (index = 0; index < arr.Length; index++)
            {
                for (indexPlus = index + 1; indexPlus > 0; indexPlus--)
                {
                    if (arr[indexPlus - 1] > arr[indexPlus])
                    {
                        temp = arr[indexPlus - 1];
                        arr[indexPlus - 1] = arr[index];
                        arr[indexPlus] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
