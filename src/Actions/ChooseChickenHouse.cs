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

            for (int i = 0; i < farm.ChickenHouses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Chicken House");
            }
            // added new code below

            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {

                foreach (var field in farm.GrazingFields)
                {
                    // Console.WriteLine($"{1 + i++}.  Grazing Field {field.CurrentCapacity}");
                    Console.WriteLine($"{1 + i++}.  Grazing Field, currently has {field.Capacity - field.CurrentCapacity} animals");
                }
            }

            Console.WriteLine();

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