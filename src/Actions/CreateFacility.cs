using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Plowed field");
            Console.WriteLine("3. Duck House");
            Console.WriteLine("4. Chicken House");
            Console.WriteLine("5. Natural field");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");

            Console.Write("> ");
            string input = Console.ReadLine();

            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    Console.WriteLine("You have selected a facility");
                    break;
                case 2:
                    farm.AddPlowedField(new PlowedField());
                    Console.WriteLine("You have added a plowed field");
                    break;
                case 3:
                    farm.AddDuckHouse(new DuckHouse());
                    Console.WriteLine("You have selected a facility");
                    break;
                case 4:
                    farm.AddChickenHouse(new ChickenHouse());
                    Console.WriteLine("You have created a chicken house");
                    break;
                case 5:
                    farm.AddNaturalField(new NaturalField());
                    Console.WriteLine("You have created a natural field");
                    break;
                default:
                    break;
            }
        }
    }
}