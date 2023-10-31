using System;
using System.Linq;
using System.Collections.Generic;
namespace ZadC3
{
    class LifeSupportSystem
    {
        private List<OxygenBottle> oxygenBottles;
        private FoodContainer foodContainer;
        private Waste waste;
        private List<Human> Crew;

        public LifeSupportSystem(List<OxygenBottle> oxygenBottles1, FoodContainer foodContainer1, Waste waste1,List<Human> crew1)
        {
            oxygenBottles = oxygenBottles1;
            foodContainer = foodContainer1;
            waste = waste1;
            Crew = crew1;
        }
        public bool CheckSuppliesBeforeTravel(double travelTime)
        {
            double fullOxygen = 0;
            foreach (var item in oxygenBottles)
            {
                fullOxygen = fullOxygen + item.Volume;
            }
            return fullOxygen > (travelTime/24)*Crew.Count*40 && foodContainer.Volume > (travelTime/24)*Crew.Count*0.1;
            //jedna osoba zuzywa 40 tlenu, i jedzenie
        }

        public void Run(double travelTime)
        {
            foreach (var item in oxygenBottles)
            {
                item.Volume -= ((travelTime/24) * 40 * Crew.Count)/oxygenBottles.Count;
                foodContainer.Volume -= (travelTime/24) * Crew.Count * 0.1;
                waste.Volume += ((travelTime/24) * Crew.Count * 0.05);
            }
        }

    }
}