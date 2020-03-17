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

        private List<INatural> _seeds = new List<INatural>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(INatural seed)
        {
            // TODO: implement this...
            _seeds.Add(seed);
            // throw new NotImplementedException ();
        }

        public void AddResource(List<INatural> seed)
        {
            // TODO: implement this...
            // throw new NotImplementedException ();
        }

        public double CurrentCapacity
        {
            get
            {
                return _capacity - _seeds.Count;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append($"Natural field {shortId} has {this._seeds.Count} seeds\n and {this._capacity - this._seeds.Count} spaces left.");
            this._seeds.ForEach(s => output.Append($"   {s}\n"));

            return output.ToString();
        }
    }
}