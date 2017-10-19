using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace holy_water
{
    public class Filter
    {
        public IEnumerable<Bar> FilterByPerc(List<Bar> bars, string input)
        {
            Regex reg = new Regex(@"[\d]");
            if (reg.IsMatch(input))
            {
                var selectedBars = from bar in bars
                                           where bar.percentage >= Int32.Parse(input)
                                           select bar;
                return selectedBars;
            }
            return null;
        }
    }
}
