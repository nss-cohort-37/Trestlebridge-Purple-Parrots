using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<IPlowing>
    {
        private int _capacity = 13;
        private Guid _id = Guid.NewGuid();

        private List<IPlowing> _rows = new List<IPlowing>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IPlowing row)
        {
            // TODO: implement this...
            _rows.Add(row);
            // throw new NotImplementedException ();
        }

        public void AddResource(List<IPlowing> row)
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
            output.Append($"Plowed field {shortId} has {this._rows.Count} used rows\n and {this._capacity - this._rows.Count} spaces left.");
            this._rows.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}