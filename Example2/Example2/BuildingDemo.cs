using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class BuildingDemo
    {
        static void Main()
        {
            Building house = new Building();
            
            house.Occupants = 4;
            house.Arrea = 2500;
            house.Floors = 2;

            Console.WriteLine("Дом имеет: \n" + house.Floors + " этажa\n" + house.Occupants + " жильца\n" + house.Arrea 
                + " кв. футов общей площади, из них " + house.ArreaPerPerson() + " приходится на одного человека.");

            Building office = new Building();

            office.Occupants = 23;
            office.Arrea = 4500;
            office.Floors = 3;

            Console.WriteLine();
            Console.WriteLine("Оффис имеет: \n" + office.Floors + " этажa\n" + office.Occupants + " жильца\n" 
                + office.Arrea + " кв. футов общей площади, из них " + office.ArreaPerPerson() + " приходится на одного человека.");

            if (house.ArreaPerPerson() > office.ArreaPerPerson())
            {
                Console.WriteLine();
                Console.WriteLine("В доме выделяется больше площади на жильца, чем в оффисе на сотрудника.");
            }
        }
    }
}
