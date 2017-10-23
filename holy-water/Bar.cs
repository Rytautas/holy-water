using System;

namespace holy_water
{
    public struct Bar
    {
        public String name;
        public double volume, locX, locY;
        public int percentage;
        public int Count { get; private set; }
        public double Average { get; private set; }

        public Bar(string name, double volume, double locX, double locY, int percentage, double average = 0.00, int count = 1)
        {
            this.name = name;
            this.volume = volume;
            this.locX = locX;
            this.locY = locY;
            this.percentage = percentage;
            Count = count;
            Average = average;
        }

        public void CountAverage(Bar bar)
        {
            double sum = Count * Average;
            Average = (sum + bar.percentage) / (Count + 1);
            Count++;
        }
    }
}
