using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, IMeatProducing animal)
        {
            // Utils.Clear();

            // added new code below
            for (int i = 0; i < farm.ChickenHouses.Count; i++)
            {
                foreach (var house in farm.ChickenHouses)
                {
                    Console.WriteLine($"{1 + i++}. Chicken house, currently has {house.Capacity - house.CurrentCapacity} animals");
                    if (house._animals.Count > 0)
                    {
                        foreach (var singleAnimal in house._animals.GroupBy(a => a.GetType().Name))
                        {
                            Console.Write($" - Contains {singleAnimal.Count()} {singleAnimal.Key}");
                            if (singleAnimal.Count() > 1) { Console.Write("s" + "\n"); } else { Console.Write("\n"); }
                        }
                    }
                }
            }

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            if (farm.ChickenHouses[choice - 1].CurrentCapacity > 0)
            {
                farm.ChickenHouses[choice - 1].AddResource(animal);
            }
            else
            {
                Console.WriteLine("This chicken house is full.");
            }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}