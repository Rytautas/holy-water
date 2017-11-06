using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace holy_water
{
    public struct BarAvg
    {
        public String barName;
        public double barPercentage;

        public BarAvg(string barName, double barPercentage)
        {
            this.barName = barName;
            this.barPercentage = barPercentage;
        }
    }
}
