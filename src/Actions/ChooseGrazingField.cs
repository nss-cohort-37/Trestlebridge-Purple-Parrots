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
                Console.WriteLine($"{i + 1}. Grazing Field");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            // int numberOfAnimals = farm.GrazingFields[choice - 1].ToString

            // double grazingFieldFullCapacity = farm.GrazingFields[choice - 1].Capacity;

            // string grazingFieldReport = farm.GrazingFields[choice - 1].ToString();

            // if (grazingFieldCapacity ) {
            farm.GrazingFields[choice - 1].AddResource(animal);
            // Console.WriteLine(grazingFieldReport);
            // } else {
            //     Console.WriteLine ("all full");
            // }
            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}