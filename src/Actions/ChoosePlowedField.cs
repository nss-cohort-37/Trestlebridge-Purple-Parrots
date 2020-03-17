using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChoosePlowedField
    {
        public static void CollectInput(Farm farm, IPlowing row)
        {

            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {
                foreach (var field in farm.PlowedFields)
                {
                    Console.WriteLine($"{1 + i++}. Plowed field, currently has {field.Capacity - field.CurrentCapacity} seeds");
                    if (field._rows.Count > 0)
                    {
                        foreach (var singleSeed in field._rows.GroupBy(a => a.GetType().Name))
                        {
                            Console.Write($" - Contains {singleSeed.Count()} {singleSeed.Key}");
                            if (singleSeed.Count() > 1) { Console.Write("s" + "\n"); } else { Console.Write("\n"); }
                        }
                    }
                }
            }

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the seed where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            if (farm.PlowedFields[choice - 1].CurrentCapacity > 0)
            {
                farm.PlowedFields[choice - 1].AddResource(row);
            }
            else
            {
                Console.WriteLine("This Plowed Field is full.");
            }
        }
    }
}