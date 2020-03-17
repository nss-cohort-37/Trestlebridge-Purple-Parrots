using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<INatural>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();

        private List<INatural> _animals = new List<INatural>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(INatural animal)
        {
            // TODO: implement this...
            _animals.Add(animal);
            // throw new NotImplementedException ();
        }

        public void AddResource(List<INatural> animal)
        {
            // TODO: implement this...
            // throw new NotImplementedException ();
        }

        public double CurrentCapacity
        {
            get
            {
                return _capacity - _animals.Count;
            }
        }




        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n and {this._capacity - this._animals.Count} spaces left.");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}