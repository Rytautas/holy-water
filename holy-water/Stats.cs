using System;

namespace holy_water
{
    public struct BarAvg
    {
        public String barName;
        public decimal barPercentage;

        public BarAvg(string barName, decimal barPercentage)
        {
            this.barName = barName;
            this.barPercentage = barPercentage;
        }
    }
}
