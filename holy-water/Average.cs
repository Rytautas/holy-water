using System;
using System.Collections.Generic;
using System.IO;

namespace holy_water
{
    class Average
    {
        public Average()
        {
            List<double> Avg = new List<double>();
            List<string> Name = new List<string>();
            List<Bar> bars = new List<Bar>();
            FilePrep prep = new FilePrep();
            bars = prep.Read("Bar_data.txt");
            string filename = "test.txt";
            FillLists(Name, Avg, bars);
            CalculateAverage(Name, Avg);
            Write(Avg, Name, filename);
        }
        public void FillLists(List<string> Name, List<double> Avg, List<Bar> bars)
        {
            foreach (Bar bar in bars)
            {
                Name.Add(bar.Name);
                Avg.Add(bar.Percentage);
            }
        }
        public void CalculateAverage(List<string> Name, List<double> Avg)
        {
            double sum;
            int count;
            for (int index = 0; index < Name.Count; index++)
            {
                sum = Avg[index];
                count = 1;
                for (int index1 = 0; index1 < Name.Count; index1++)
                {
                    if ((Name[index] == Name[index1]) && (index != index1))
                    {
                        Name.Remove(Name[index1]);
                        sum = sum + Avg[index1];
                        count++;
                        Avg.Remove(Avg[index1]);
                        index1--;
                    }
                }
                Avg[index] = sum / count;
            }

        }
        public void Write(List<double> Avg, List<string> Name, string filename)
        {
            StreamWriter wr = new StreamWriter(filename);
            for (int index = 0; index < Avg.Count; index++)
            {
                wr.WriteLine(Name[index] + " " + Math.Round(Avg[index], 2));
            }
            wr.Close();
        }
    }
}
