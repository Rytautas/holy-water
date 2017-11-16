using System;

namespace holy_water
{
    public class Bar
    {
        private String name;
        private decimal volume, locX, locY;
        private int percentage;
        private int count;
        private decimal average;

        public int Count { get => count; }
        public decimal Average { get => average; }

        public int Percentage {
            get => percentage; 
            set {
                percentage = value;
                CountAverage();
            }
        }

        public string Name { get => name; }
        public decimal Volume { get => volume;  }
        public decimal LocX { get => locX; }
        public decimal LocY { get => locY; }

        public Bar(string name, decimal volume, decimal locX, decimal locY, int percentage, decimal average = 0, int count = 1)
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
