using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class ApplicationLicense
    {
        string licenseCodeTrial;
        string licenseCodeCommon;
        string licenseCodePro;

        public string LicenseCodeTrial
        {
            get { return licenseCodeTrial; }
            set { licenseCodeTrial = value; }
        }
        public string LicenseCodeCommon
        {
            get { return licenseCodeCommon; }
            set { licenseCodeCommon = value; }
        }
        public string LicenceCodePro
        {
            get { return licenseCodePro; }
            set { licenseCodePro = value; }
        }
        public void AllowTrial()
        {
            Console.WriteLine("Trial version");
            Console.WriteLine("\nSelect an action:");

            Console.WriteLine("1 - <+>");
            Console.WriteLine("2 - <->");

            switch (Console.ReadLine())
            {
                case "1":
                    double resultaddition;
                    double Firstnumberaddition;
                    double Secondnumberaddition;

                    Console.WriteLine("Type the first digit:");
                    Firstnumberaddition = double.Parse(Console.ReadLine());

                    Console.WriteLine("Type the second digit:");
                    Secondnumberaddition = double.Parse(Console.ReadLine());
                    
                    resultaddition = (Firstnumberaddition + Secondnumberaddition);
                    
                    Console.WriteLine("Result:" + resultaddition);
                    break;
                case "2":
                    double resultsubstraction;
                    double Firstnumbersubstraction;
                    double Secondnumbersubstraction;

                    Console.WriteLine("Type the first digit:");
                    Firstnumbersubstraction = double.Parse(Console.ReadLine());

                    Console.WriteLine("Type the second digit:");
                    Secondnumbersubstraction = double.Parse(Console.ReadLine());

                    resultsubstraction = (Firstnumbersubstraction - Secondnumbersubstraction);

                    Console.WriteLine("Result:" + resultsubstraction);
                    break;
                default:
                    Console.WriteLine("**INPUT ERROR**");
                    break;
            }
        }

        public void AllowCommon()
        {
            Console.WriteLine("Free version");
            Console.WriteLine("In this version are available new functions like <*> & </>");
            Console.WriteLine("Select an action:");

            Console.WriteLine("1 - <+>");
            Console.WriteLine("2 - <->");
            Console.WriteLine("3 - <*>");
            Console.WriteLine("4 - </>");

            switch (Console.ReadLine())
            {
                case "1":
                    double resultaddition;
                    double Firstnumberaddition;
                    double Secondnumberaddition;

                    Console.WriteLine("Type the first digit:");
                    Firstnumberaddition = double.Parse(Console.ReadLine());

                    Console.WriteLine("Type the second digit:");
                    Secondnumberaddition = double.Parse(Console.ReadLine());

                    resultaddition = (Firstnumberaddition + Secondnumberaddition);

                    Console.WriteLine("Result:" + resultaddition);
                    break;
                case "2":
                    double resultsubstraction;
                    double Firstnumbersubstraction;
                    double Secondnumbersubstraction;

                    Console.WriteLine("Type the first digit:");
                    Firstnumbersubstraction = double.Parse(Console.ReadLine());

                    Console.WriteLine("Type the second digit:");
                    Secondnumbersubstraction = double.Parse(Console.ReadLine());

                    resultsubstraction = (Firstnumbersubstraction - Secondnumbersubstraction);

                    Console.WriteLine("Result: " + resultsubstraction);
                    break;
                case "3":
                    double resultmultiplication;
                    double Firstnumbermultiplication;
                    double Secondnumbermultiplication;

                    Console.WriteLine("Type the first digit:");
                    Firstnumbermultiplication = double.Parse(Console.ReadLine());

                    Console.WriteLine("Type the second digit:");
                    Secondnumbermultiplication = double.Parse(Console.ReadLine());

                    resultmultiplication = (Firstnumbermultiplication - Secondnumbermultiplication);

                    Console.WriteLine("Result: " + resultmultiplication);
                    break;
                case "4":
                    double resultdivision;
                    double Firstnumberdivision;
                    double Secondnumberdivision;

                    Console.WriteLine("Type the first digit:");
                    Firstnumberdivision = double.Parse(Console.ReadLine());

                    Console.WriteLine("Type the second digit:");
                    Secondnumberdivision = double.Parse(Console.ReadLine());

                    resultdivision = (Firstnumberdivision - Secondnumberdivision);

                    Console.WriteLine("Result: " + resultdivision);
                    break;
                default:
                    Console.WriteLine("**INPUT ERROR**");
                    break;
            }
        }
        public void AllowPro()
        {
            Console.WriteLine("Pro version");
        }
    }
}
