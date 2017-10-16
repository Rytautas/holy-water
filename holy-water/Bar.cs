using System;

namespace holy_water
{
    public struct Bar
        {
            public String name;
            public double volume, locX, locY;
            public int percentage;

            public Bar(string name, double volume, double locX, double locY, int percentage)
            {
                this.name = name;
                this.volume = volume;
                this.locX = locX;
                this.locY = locY;
                this.percentage = percentage;
            }
        }
}
