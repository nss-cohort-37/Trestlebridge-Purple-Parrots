using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities {
    public class ChickenHouse : IFacility<IMeatProducing> {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid ();

        private List<IMeatProducing> _chickens = new List<IMeatProducing> ();
        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (IMeatProducing chicken) {
            // TODO: implement this...
            _chickens.Add (chicken);
            // throw new NotImplementedException ();
        }

        public void AddResource (List<IMeatProducing> chicken) {
            // TODO: implement this...
            // throw new NotImplementedException ();
        }

        public override string ToString () {
            StringBuilder output = new StringBuilder ();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append ($"Chicken house {shortId} has {this._chickens.Count} animals\n");
            this._chickens.ForEach (a => output.Append ($"   {a}\n"));

            return output.ToString ();
        }
    }
}