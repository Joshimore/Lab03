using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Linq;

namespace Task_1
{
    internal class Gtr34
    {
        public Gtr34(){}

        public Gtr34(string model, int price, int mileage, string fueltype, string gearboxtype, string city)
        {
            Model = model;
            Price = price;
            Mileage = mileage;
            Fueltype = fueltype;
            Gearboxtype = gearboxtype;
            City = city;
        }

        public string Model { get; set; }
        public int Price { get; set; }
        public int Mileage { get; set; }
        public string Fueltype { get; set; }
        public string Gearboxtype { get; set; }
        public string City { get; set; }

        public void Information34()
        {
            Debug.WriteLine($"Model ({Model.GetType()}): {Model}");
            Debug.WriteLine($"Price ({Price.GetType()}): {Price}" + "$");
            Debug.WriteLine($"Mileage ({Mileage.GetType()}): {Mileage}");
            Debug.WriteLine($"Fuel Type ({Fueltype.GetType()}): {Fueltype}");
            Debug.WriteLine($"Gearbox Type ({Gearboxtype.GetType()}): {Gearboxtype}");
            Debug.WriteLine($"Owner: {GetType()}\n");
        }
    }
}
