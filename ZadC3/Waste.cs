using System;

namespace ZadC3
{
    class Waste : IVisitPort
    {
        public double VisitPort() 
        { 
            double VolumeBefore = Volume;
            Volume = 0;
            return VolumeBefore * 200; //koszt wyrzucania smieci
        }

        protected double volume, weight;

        public double Volume
        {
            get { return volume; }

            set
            {
                volume = value;
                weight = value * 0.8; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }

            set
            {
                weight = value;
                volume = value / 0.8; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
    }
}