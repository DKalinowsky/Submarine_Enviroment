using System;

namespace ZadC3
{
    class OxygenBottle : IVisitPort
    {
        public double MaxCapacity {get;} 
        public double VisitPort() //to samo z tlenem
        { 
            double VolumeBefore = Volume;
            Volume = MaxCapacity;
            return (Volume - VolumeBefore) * 500;
        }

        protected double volume, weight;
        public double Volume
        {
            get { return volume; }

            set
            {
                volume = value;
                weight = value * 4; 
            }
        }
        public double Weight
        {
            get { return weight; }

            set
            {
                weight = value;
                volume = value / 4; 
            }
        }

        public OxygenBottle(double capacity)
        {
            MaxCapacity = capacity;
        }
    }
}