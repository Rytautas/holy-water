using holy_water.Resources;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace holy_water
{
    public class Filter
    {
        public delegate IEnumerable<Bar> FilterDel(List<Bar> bar, string text);
        public List<Bar> FilterCondition(int index, List<Bar> bars)
        {
            string input;
            FilterDel selectBars = null;

            switch (index)
            {
                case 0:
                    input = Interaction.InputBox(Resource1.MinimalFilter);
                    selectBars += FilterByPerc;
                    break;
                case 1:
                    input = Interaction.InputBox(Resource1.MinimalFilter);
                    selectBars += FilterByAvg;
                    break;
                default:
                    input = "";
                    selectBars = null;
                    break;
            }
            if (selectBars != null)
            {
                return new List<Bar>(selectBars(bars, input));
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Bar> FilterByPerc(List<Bar> bars, string input)
        {
            Regex reg = new Regex(Resource1.FilterNumberReg);
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

            Regex reg = new Regex(Resource1.FilterNumberReg);
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
