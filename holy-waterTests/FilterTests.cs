using Microsoft.VisualStudio.TestTools.UnitTesting;
using holy_water;
using System;
using System.Collections.Generic;
using System.Linq;

namespace holy_water.Tests
{
    [TestClass()]
    public class FilterTests
    {
        [TestMethod()]
        public void FilterByPercTest()
        {
            List<Bar> bars = new List<Bar>();
            bars.Add(new Bar("", 0.00, 0.00, 0.00, 20));
            bars.Add(new Bar("", 1.00, 1.00, 1.00, 75));
            bars.Add(new Bar("", 1, 2, 3, 80, count: 2));

            Filter TestFilter = new Filter();
            IEnumerable<Bar> TestList = TestFilter.FilterByPerc(bars, "50");

            Assert.AreEqual(TestList.Count(), 2);
        }

        [TestMethod()]
        public void FilterByAvgTest()
        {
            List<Bar> bars = new List<Bar>();
            bars.Add(new Bar("", 0.00, 0.00, 0.00, 20, 50.00));
            bars.Add(new Bar("", 1.00, 1.00, 1.00, 75, 25.00));;

            Filter TestFilter = new Filter();
            IEnumerable<Bar> TestList = TestFilter.FilterByAvg(bars, "50");

            Assert.AreEqual(TestList.Count(), 1);
        }
    }
}