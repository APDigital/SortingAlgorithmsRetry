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
    public class AssertSortedTests
    {
        [TestMethod()]
        public void IsSortedTrueTest()
        {
            int[] input = { 5, 4, 3, 2, 1 };
            Assert.IsTrue(AssertSorted.IsSorted(input));
        }
        [TestMethod()]
        public void IsSortedFalseTest()
        {
            int[] input = { 1, 4, 3, 2, 5 };
            Assert.IsFalse(AssertSorted.IsSorted(input));
        }
    }
}