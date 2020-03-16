using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 5;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

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

        public void AddResource(IGrazing animal)
        {
            // TODO: implement this...

            _animals.Add(animal);

            // throw new NotImplementedException ();
        }

        public void AddResource(List<IGrazing> animals)
        {
            // TODO: implement this...
            // throw new NotImplementedException ();
        }



        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}