using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingRetry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingRetry.Tests
{
    [TestClass()]
    public class MergeSortTests
    {
        [TestMethod()]
        public void MergeSortListTest()
        {
            int[] myList = { 8, 9, 6, 7, 4, 5, 3, 2, 1 };
            MergeSort.MergeSortList(myList);
            Assert.IsTrue(AssertSorted.IsSorted(myList));
        }
        
    }
}