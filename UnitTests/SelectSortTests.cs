﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingRetry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingRetry.Tests
{
    [TestClass()]
    public class SelectSortTests
    {
        int[] answer = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        [TestMethod()]
        public void SelectTest()
        {
            int[] myList = { 8, 9, 6, 7, 4, 5, 3, 2, 1 };
            SelectSort.Select(myList);
            Assert.IsTrue(AssertSorted.IsSorted(myList));
        }
    }
}