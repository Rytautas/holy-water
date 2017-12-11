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
                IEnumerable<Bar> iBar = selectBars(bars, input);
                if (iBar == null)
                    return null;
                List<Bar> newBarList = new List<Bar>();
                foreach (Bar bar in iBar)
                    newBarList.Add(bar);
                return newBarList;

            
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
                                   where bar.Percentage >= Int32.Parse(input)
                                   select bar;
                return selectedBars;
            }
            else
            {
                return null;
            }
           
        }

        public IEnumerable<Bar> FilterByAvg(List<Bar> bars, string input)
        {

            Regex reg = new Regex(Resource1.FilterNumberReg);
            if (reg.IsMatch(input))
            {
                var selectedBars = from bar in bars
                                   where bar.Average >= input.ToDecimal()
                                   select bar;
                return selectedBars;
            }
            else
            {
                return null;
            }
            
        }
    }
}
