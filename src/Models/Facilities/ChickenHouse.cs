using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class ChickenHouse : IFacility<IMeatProducing>
    {
        private int _capacity = 15;
        private Guid _id = Guid.NewGuid();

        public List<IMeatProducing> _animals = new List<IMeatProducing>();
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public double CurrentCapacity
        {
            get
            {
                return _capacity - _animals.Count;
            }
        }


        public void AddResource(IMeatProducing animal)
        {
            // TODO: implement this...
            _animals.Add(animal);
            // throw new NotImplementedException ();
        }

        public void AddResource(List<IMeatProducing> animal)
        {
            // TODO: implement this...
            // throw new NotImplementedException ();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken house {shortId} has {this._animals.Count} animals\n and {this._capacity - this._animals.Count} spaces left.");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}