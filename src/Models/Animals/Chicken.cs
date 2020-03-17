using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Chicken : IResource, IMeatProducing
    {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 1.7;
        private int EggQuantity { get; set; } = 6;
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double FeedPerDay { get; set; } = 0.9;
        public string Type { get; } = "Chicken";

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Chicken {this._shortId} just ate {this.FeedPerDay}kg of grass");
        }

        public double Butcher()
        {
            return _meatProduced;
        }

        public int LayEgg()
        {
            return EggQuantity;
        }

        public override string ToString()
        {
            return $"Chicken {this._shortId}. Bok bok!";
        }
    }
}