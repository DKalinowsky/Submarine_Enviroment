using System;

namespace ZadC3
{
    class FoodContainer : IVisitPort
    {
        public double MaxCapacity {get;} 
        public double VisitPort() //sposob zeby policzyc jedzenie
        { 
            double VolumeBefore = Volume;
            Volume = MaxCapacity;
            return (Volume - VolumeBefore) * 600;
        }

        protected double volume, weight;
        public double Volume
        {
            get { return volume; }

            set
            {
                volume = value;
                weight = value * 3; 
            }
        }
        public double Weight
        {
            get { return weight; }

            set
            {
                weight = value;
                volume = value / 3; 
            }
        }
        public FoodContainer(double capacity)
        {
            MaxCapacity = capacity;
        }

    }
}