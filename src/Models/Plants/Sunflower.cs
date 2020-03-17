using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
  public class Sunflower : IResource, ISeedProducing, INatural, IPlowing
  {
    public double NaturalGrass { get; set; }
    private int _seedsProduced = 40;
    public string Type { get; } = "Sunflower";

    public double Rows { get; set; }
    public double Plants { get; set; }

    public double Harvest()
    {
      return _seedsProduced;
    }

    public override string ToString()
    {
      return $"Sunflower. Yum!";
    }
  }
}