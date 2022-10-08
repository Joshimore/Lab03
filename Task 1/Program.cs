using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gtr34 gtr34 = new("Nissan GTR r34", 100000, 0, "Petrol", "Mechanical", "Tokyo");
            gtr34.Information34();

            Gtr35 gtr35 = new("Nissan GTR r35", 200000, 0, "Petrol", "Mechanical", "Hiroshima");
            gtr35.Information35();

            Gtr34 car1 = gtr35;
            car1.Information34();

            Gtr35 car2 = (Gtr35)car1;
            car2.Information35();

            Console.ReadLine();
        }
    }
}
