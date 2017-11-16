using System;
using System.Collections.Generic;
using System.IO;

namespace holy_water
{
    class StatsPrep
    {
        public List<BarAvg> Read(String fileName)
        {
            List<BarAvg> barsAvg = new List<BarAvg>();

            using (StreamReader sr = new StreamReader(fileName))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] split = line.Split(' ');
                    barsAvg.Add(new BarAvg(split[0], split[1].ToDecimal()));
                    line = sr.ReadLine();
                }
            }
            return barsAvg;
        }
    }
}
