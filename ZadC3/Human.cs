using System;

namespace ZadC3
{
    abstract class Human : ITransportable
    {
        protected double volume, weight;
        public double Volume
        {
            get { return volume; }

            set
            {
                volume = value;
                weight = value * 0.0098; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }

            set
            {
                weight = value;
                volume = value / 0.0098; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }

    }
}