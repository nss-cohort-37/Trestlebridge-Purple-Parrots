using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
  public class ChooseNaturalField
  {
    public static void CollectInput(Farm farm, INatural seed)
    {

      for (int i = 0; i < farm.NaturalFields.Count; i++)

      {

        foreach (var field in farm.NaturalFields)
        {
          Console.WriteLine($"{1 + i++}.  Natural Field, currently has {field.Capacity - field.CurrentCapacity} seeds");
        }
      }

      // Console.WriteLine();

      // How can I output the type of animal chosen here?
      Console.WriteLine($"Place the seed where?");

      Console.Write("> ");
      int choice = Int32.Parse(Console.ReadLine());

      if (farm.NaturalFields[choice - 1].CurrentCapacity > 0)
      {
        farm.NaturalFields[choice - 1].AddResource(seed);
      }
      else
      {
        Console.WriteLine("This natural field is full.");
      }
    }
  }
}