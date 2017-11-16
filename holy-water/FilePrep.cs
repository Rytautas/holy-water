﻿using System;
using System.Collections.Generic;
using System.IO;

namespace holy_water
{
    class FilePrep
    {
        public List<Bar> Read(String fileName)
        {
            List<Bar> bars = new List<Bar>();
            
            using(StreamReader sr = new StreamReader(fileName))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] split = line.Split('\t');
                    bars.Add(new Bar(split[0], split[1].ToDecimal(), split[3].ToDecimal(), split[4].ToDecimal(), Int32.Parse(split[2]), split[5].ToDecimal(), Int32.Parse(split[6])));
                    line = sr.ReadLine();
                }
            }
            return bars;
        }

        public void Write(String fileName, List<Bar> bars)
        {
            StreamWriter reset = new StreamWriter(fileName);
            reset.Write("");
            reset.Close();

            using (StreamWriter wr = new StreamWriter(fileName, true))
            {
                foreach (Bar bar in bars)
                {
                    wr.WriteLine(bar.Name + "\t" + bar.Volume + "\t" + bar.Percentage + "\t" + bar.LocX + "\t" + bar.LocY + "\t" + bar.Average + "\t" + bar.Count);
                }
            }
        }
    }
}
