using System;
using System.Collections.Generic;
using System.IO;

namespace holy_water
{
    class StatsPrep
    {
        public List<BarAvg> Read(String fileName1, String fileName2)
        {
            List<BarAvg> barsAvg = new List<BarAvg>();

            StreamReader sr1 = new StreamReader(fileName1);
            StreamReader sr2 = new StreamReader(fileName2);
            string line1 = sr1.ReadLine();
            string line2 = sr2.ReadLine();
            while ((line1 != null) && (line2 != null))
            {   
                barsAvg.Add(new BarAvg(line1, line2.ToDecimal()));
                line1 = sr1.ReadLine();
                line2 = sr2.ReadLine();
            }
            return barsAvg;
        }
    }
}
