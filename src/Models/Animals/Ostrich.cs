using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Ostrich : IResource, INatural, IMeatProducing
    {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 2.6;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double NaturalGrass { get; set; }
        public string Type { get; } = "Ostrich";

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Ostrich {this._shortId} lives on kg of {this.NaturalGrass}");
        }

        public double Butcher()
        {
            return _meatProduced;
        }

        public override string ToString()
        {
            return $"Ostrich {this._shortId}. Squack!";
        }
    }
}