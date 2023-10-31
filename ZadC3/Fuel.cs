using System;

namespace ZadC3
{
    abstract class Fuel : ITransportable
    {
        public string Material {get; protected set;} //klasy dziedziczace moga zmienic
        protected double density;

        protected double volume, weight;
        public double Volume
        {
            get { return volume; }

            set
            {
                volume = value;
                weight = value * density; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }

            set
            {
                weight = value;
                volume = value / density; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
    }
}