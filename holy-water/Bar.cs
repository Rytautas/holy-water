using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace holy_water
{
    [DataContract]
    public class Bar
    {
        public Bar()
        {

        }

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

        private String name;
        private decimal volume, locX, locY;
        private int percentage;
        private int count;
        private decimal average;
        
        [DataMember]
        [JsonProperty("Count")]
        public int Count { get; set; }

        [DataMember]
        [JsonProperty("Average")]
        public decimal Average { get; set; }

        [DataMember]
        [JsonProperty("Name")]
        public string Name { get; set; }

        [DataMember]
        [JsonProperty("Volume")]
        public decimal Volume { get; set; }

        [DataMember]
        [JsonProperty("LocX")]
        public decimal LocX { get; set; }

        [DataMember]
        [JsonProperty("LocY")]
        public decimal LocY { get; set; }

        [DataMember]
        [JsonProperty("Percentage")]
        public int Percentage
        {
            get => percentage; 
            set {
                percentage = value;
                CountAverage();
            }
        }


        private void CountAverage()
        {
            average = (count * average + percentage) / ++count;
        }
    }
}
