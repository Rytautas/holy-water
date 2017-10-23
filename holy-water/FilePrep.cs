using System;
using System.Collections.Generic;
using System.IO;

namespace holy_water
{
    class FilePrep
    {
        public List<Bar> Read(String fileName)
        {
            List<Bar> bars = new List<Bar>();
            StreamReader sr = new StreamReader(fileName);
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] split = line.Split(' ');
                bars.Add(new Bar(split[0], Convert.ToDouble(split[1]), Convert.ToDouble(split[3]), Convert.ToDouble(split[4]), Int32.Parse(split[2]), Convert.ToDouble(split[5]), Int32.Parse(split[6])));
                line = sr.ReadLine();
            }
            sr.Close();
            return bars;
        }

        public void Write(String fileName, List<Bar> bars)
        {
            StreamWriter reset = new StreamWriter(fileName);
            reset.Write("");
            reset.Close();

            StreamWriter wr = new StreamWriter(fileName, true);
            foreach (Bar bar in bars)
            {
                wr.WriteLine(bar.name + " " + bar.volume + " " + bar.percentage + " " + bar.locX + " " + bar.locY + " " + bar.Average + " " + bar.Count);
            }
            wr.Close();
        }
    }
}
