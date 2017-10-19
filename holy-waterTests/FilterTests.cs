using Microsoft.VisualStudio.TestTools.UnitTesting;
using holy_water;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Filter TestFilter = new Filter();
            IEnumerable<Bar> TestList = TestFilter.FilterByPerc(bars, "50");
            int count = TestList.Count();

            Assert.AreEqual(count, 1);
        }
    }
}