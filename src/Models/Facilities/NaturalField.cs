using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<INatural>
    {
        private int _capacity = 10;
        private Guid _id = Guid.NewGuid();

        public List<INatural> _rows = new List<INatural>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(INatural row)
        {
            // TODO: implement this...
            _rows.Add(row);
            // throw new NotImplementedException ();
        }

        public void AddResource(List<INatural> row)
        {
            // TODO: implement this...
            // throw new NotImplementedException ();
        }

        public double CurrentCapacity
        {
            get
            {
                return _capacity - _rows.Count;
            }
        }




        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append($"Natural field {shortId} has {this._rows.Count} seeds\n and {this._capacity - this._rows.Count} spaces left.");
            this._rows.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}