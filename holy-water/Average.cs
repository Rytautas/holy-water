using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Write(Avg);
        }
        public void FillLists(List<string> Name, List<double> Avg, List<Bar> bars)
        {
            foreach (Bar bar in bars)
            {
                Name.Add(bar.name);
                Avg.Add(bar.percentage);
            }
        }
        public void CalculateAverage(List<string> Name, List<double> Avg)
        {   
            for (int index = 0; index < Name.Count; index++)
            {
                for (int index1 = 0; index1 < Name.Count; index1++)
                {
                    if ((Name[index] == Name[index1]) && (index != index1))
                    {
                        Name.Remove(Name[index1]);
                        Avg[index] = (Avg[index] + Avg[index1]) / 2;
                        Avg.Remove(Avg[index1]);
                        index1--;
                    }
                }
            }
            
        }
        public void Write(List<double> Avg)
        {
            StreamWriter wr = new StreamWriter("test.txt");
            for (int index = 0; index < Avg.Count; index++)
            {
                wr.WriteLine(Math.Round(Avg[index], 2));
            }
            wr.Close();
        }
    }
}
