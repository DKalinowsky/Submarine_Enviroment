using System;
namespace ZadC3
{
    class Scientist : Human
    {
        private Equipment equipment;

        public void Work(double time)
        {
            for(int i = 0 ; i< time/24; i++)
            {
                equipment.GatherData();
            }
        }

        public Scientist(Equipment equipment1) 
        { 
            equipment = equipment1; 
        }
    }
}