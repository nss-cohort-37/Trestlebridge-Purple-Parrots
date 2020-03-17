using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IDuckHouse animal)
        {
            // Utils.Clear();

            // added new code below

            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {

                foreach (var field in farm.DuckHouses)
                {
                    Console.WriteLine($"{1 + i++}.  Duck House, currently has {field.Capacity - field.CurrentCapacity} animals");
                }
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            if (farm.DuckHouses[choice - 1].CurrentCapacity > 0)
            {
                farm.DuckHouses[choice - 1].AddResource(animal);
            }
            else
            {
                Console.WriteLine("This duck house is full.");
            }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}