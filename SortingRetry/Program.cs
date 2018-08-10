using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingRetry
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myList = { 8, 9, 6, 7, 4, 5, 3, 2, 1 };
            InsertionSort.Insert(myList);
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
      
    }
}
