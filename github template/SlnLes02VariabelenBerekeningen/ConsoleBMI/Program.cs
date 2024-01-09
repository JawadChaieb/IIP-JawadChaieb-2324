using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI CALCULATOR");
            Console.WriteLine("===============");

            Console.WriteLine("Lengte (in cm): ");
            int lengte = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gewicht (in kg): ");
            int gewicht = Convert.ToInt32(Console.ReadLine());

            double bmi = CalculateBmi(lengte, gewicht);
            Console.WriteLine("Je BMI bedraagt: " + Math.Round(bmi, 1));
            Console.ReadKey();
        }

        static double CalculateBmi(int lengte, int gewicht)
        {
            double bmi = (gewicht * 10000) / (Math.Pow(lengte, 2));
            return bmi;
        }
        }
}
