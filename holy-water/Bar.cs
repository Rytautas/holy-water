using System;

namespace holy_water
{
    public class Bar
    {
        private String name;
        private double volume, locX, locY;
        private int percentage;
        private int count;
        private double average;

        public int Count { get => count; }
        public double Average { get => average; }

        public int Percentage {
            get => percentage; 
            set {
                percentage = value;
                CountAverage();
            }
        }

        public string Name { get => name; }
        public double Volume { get => volume;  }
        public double LocX { get => locX; }
        public double LocY { get => locY; }

        public Bar(string name, double volume, double locX, double locY, int percentage, double average = 0.0, int count = 1)
        {
            this.name = name;
            this.volume = volume;
            this.locX = locX;
            this.locY = locY;
            this.percentage = percentage;
            this.count = count;
            this.average = average == 0 ? percentage : average;
        }

        
        private void CountAverage()
        {
            average = (count * average + percentage) / ++count;
        }
    }
}
