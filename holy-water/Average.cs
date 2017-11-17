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
            FillLists(Name, Avg, bars);
            CalculateAverage(Name, Avg);
            Write(Avg, Name);
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
        
        public void Write(List<double> Avg, List<string> Name)
        {
            StreamWriter wr1 = new StreamWriter("Name.txt");
            StreamWriter wr2 = new StreamWriter("Avg.txt");
            double avg;
            string name;
            for (int index = 0; index < Avg.Count; index++)
            {
                name = Name[index];
                avg = Math.Round(Avg[index], 2);
                Print(ref name, wr1);
                Print(ref avg, wr2);
            }
            wr1.Close();
            wr2.Close();
        }
        static void Print<T>(ref T a, StreamWriter wr)
        {
            wr.WriteLine(a);
        }
    }
}
