using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<IDuckHouse>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        private List<IDuckHouse> _animals = new List<IDuckHouse>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IDuckHouse animal)
        {
            // TODO: implement this...
            _animals.Add(animal);
            // throw new NotImplementedException ();
        }
        public double CurrentCapacity
        {
            get
            {
                return _capacity - _animals.Count;
            }
        }
        public void AddResource(List<IDuckHouse> animals)
        {

            // TODO: implement this...

            // throw new NotImplementedException ();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck House {shortId} has {this._animals.Count} animals\n and {this._capacity - this._animals.Count} spaces left.");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> master
