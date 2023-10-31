using System;
namespace ZadC3
{
    class FuelTank : IVisitPort
    {
        public double MaxCapacity {get;} 
        public double VisitPort() //tankowanie do pelna w porcie
        { 
            double VolumeBefore = Volume; //sposob zeby policzyc ilosc paliwa ile tankuja
            Volume = MaxCapacity;
            return (Volume - VolumeBefore) * 3000; //3000$ cena paliwa
        } 
        private Fuel Fuel;

        public double Volume
        {
            get { return Fuel.Volume; } //bo fueltank nie dziedziczy, wiec korzysta z obiektu fuel

            set
            {
                Fuel.Volume = value;
            }
        }
        public double Weight
        {
            get { return Fuel.Weight; } //bo fueltank nie dziedziczy, wiec korzysta z obiektu fuel

            set
            {
                Fuel.Weight = value;
            }
        }
        public string CheckFuelMaterial()
        {
            return Fuel.Material;
        }

        public FuelTank(double capacity, Fuel fuel)
        {
            Fuel = fuel;
            MaxCapacity = capacity;
        }

    }
}