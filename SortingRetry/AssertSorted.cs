using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingRetry
{
    public class AssertSorted
    {
        public static bool IsSorted(int[] numbers)
        {
            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] < numbers[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
