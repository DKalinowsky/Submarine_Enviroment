using System;
using System.Collections.Generic;
using System.Text;

namespace ZadC3
{
    class Equipment : ITransportable
    {
        protected double volume, weight;
        public double Volume
        {
            get { return volume; }

            set
            {
                volume = value;
                weight = value * 2.0; 
            }
        }
        public double Weight
        {
            get { return weight; }

            set
            {
                weight = value;
                volume = value / 2.0; 
            }
        }
        public void GatherData()
        {
            string data = "";
            for (int i = 0; i < 10; i++) data += (char)(new Random()).Next(128);
            Console.WriteLine("Important data gathered: " + data);
        }
    }
}
