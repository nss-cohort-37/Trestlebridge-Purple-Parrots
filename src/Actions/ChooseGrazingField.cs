using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            // Utils.Clear();

            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {

                foreach (var field in farm.GrazingFields)
                {
                    Console.WriteLine($"{1 + i++}.  Grazing Field, currently has {field.Capacity - field.CurrentCapacity} animals");
                }
            }

            // Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            if (farm.GrazingFields[choice - 1].CurrentCapacity > 0)
            {
                farm.GrazingFields[choice - 1].AddResource(animal);
            }
            else
            {
                Console.WriteLine("This grazing field is full.");
            }
            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}