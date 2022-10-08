using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------");

            Operator ChrisParollo = new Operator("Chris Parollo", "Tanto's", "Operator");
            ChrisParollo.Information();

            Rifleman JackDaSilva = new Rifleman("Jack da Silva", "Da Silva's", "Operator", 28, "opscar");
            JackDaSilva.Information();

            Leader Ozz = new Leader("Ozz", "Ozz", "Squad Leader", 36, "Benghazi main base");
            Ozz.Information();

            Operatormobil DeSantos = new Operatormobil("De Santos", "Toy", "Sergeant", "opscar");
            DeSantos.Information();

            Console.WriteLine("------------------------------------------");

            Console.ReadLine();
        }
    }
}
