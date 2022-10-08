using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_1
{
    internal class Gtr35
    {
        public Gtr35() {}

        public Gtr35(string model, string type, int price, int mileage, string fueltype, string gearboxtype, string city) : base (model, price, mileage, fueltype, gearboxtype, city)
        {
            Model = model;
            Price = price;
            Mileage = mileage;
            Fueltype = fueltype;
            Gearboxtype = gearboxtype;
            City = city;
            Type = type;
        }

        public string Type { get; set; }

        public void Information35()
        {
            Debug.WriteLine($"Model ({Model.GetType()}): {Model}");
            Debug.WriteLine($"Model ({Type.GetType()}): {Type}");
            Debug.WriteLine($"Price ({Price.GetType()}): {Price}" + "$");
            Debug.WriteLine($"Mileage ({Mileage.GetType()}): {Mileage}");
            Debug.WriteLine($"Fuel Type ({Fueltype.GetType()}): {Fueltype}");
            Debug.WriteLine($"Gearbox Type ({Gearboxtype.GetType()}): {Gearboxtype}");
            Debug.WriteLine($"Owner: {GetType()}\n");
        }
    }
}
