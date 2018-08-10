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
    public class InsertionSortTests
    {
        [TestMethod()]
        public void InsertTest()
        {
            int[] myList = { 8, 9, 6, 7, 4, 5, 3, 2, 1 };
            InsertionSort.Insert(myList);
            Assert.IsTrue(AssertSorted.IsSorted(myList));
        }
    }
}