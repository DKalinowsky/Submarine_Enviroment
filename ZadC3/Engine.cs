using System;

namespace ZadC3
{
    class Engine
    {
        private FuelTank tank;
        private Waste waste;
        public Engine(FuelTank tank1, Waste waste1)
        {
            tank = tank1;
            waste = waste1;
        }
        public double GetVelocity(double submarineWeight) //predkosc lodzi
        {
            return submarineWeight + tank.Weight / 1500;
        }
        public bool CheckFuelBeforeTravel(double travelTime) //czy starczy nam paliwa
        {
            return tank.Volume/15 > travelTime;
        }
        public void Travel(double travelTime) //utrata paliwa i przybycie odpadow
        {
            waste.Volume += travelTime * 5;
            tank.Volume -= travelTime * 10;
        }

    }
}