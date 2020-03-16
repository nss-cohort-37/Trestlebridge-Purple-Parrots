using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Duck
    {
        public List<DuckHouse> DuckHouse { get; } = new List<DuckHouse>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T>(IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    DuckHouse[index].AddResource((IDuckHouse)resource);
                    break;
                default:
                    break;
            }
        }

        public void AddDuckHouse(DuckHouse field)
        {
            DuckHouse.Add(field);
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            DuckHouse.ForEach(gf => report.Append(gf));

            return report.ToString();
        }
    }
}