using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace holy_water
{
    public class Filter
    {
        public List<Bar> FilterCondition(int index, List<Bar> bars)
        {
            string input;
            IEnumerable<Bar> selectedBars = null;

            switch (index)
            {
                case 0:
                    input = Interaction.InputBox("Enter the minimal level for filter");
                    selectedBars = FilterByPerc(bars, input);
                    break;
                case 1:
                    input = Interaction.InputBox("Enter the minimal level for filter");
                    selectedBars = FilterByAvg(bars, input);
                    break;
                default:
                    selectedBars = null;
                    break;
            }
            if (selectedBars != null)
            {
                return new List<Bar>(selectedBars);
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Bar> FilterByPerc(List<Bar> bars, string input)
        {
            Regex reg = new Regex(@"^[\d]+$");
            if (reg.IsMatch(input))
            {
                var selectedBars = from bar in bars
                                   where bar.percentage >= Int32.Parse(input)
                                   select bar;
                return selectedBars;
            }
            return null;
        }

        public IEnumerable<Bar> FilterByAvg(List<Bar> bars, string input)
        {
            Regex reg = new Regex(@"^[\d]+$");
            if (reg.IsMatch(input))
            {
                var selectedBars = from bar in bars
                                   where bar.Average >= double.Parse(input)
                                   select bar;
                return selectedBars;
            }
            return null;
        }
    }
}
