using System;

namespace ConsoleBmiCalculator
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

            string bmiStatus = GetBmiStatus(bmi);
            DisplayColoredBmiStatus(bmiStatus);

            Console.ReadKey();
        }

        static double CalculateBmi(int lengte, int gewicht)
        {
            double bmi = (gewicht * 10000) / (Math.Pow(lengte, 2));
            return bmi;
        }

        static string GetBmiStatus(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Je hebt ondergewicht";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                return "Je gewicht is normaal";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                return "Je hebt overgewicht";
            }
            else
            {
                return "Je hebt obesitas";
            }
        }

        static void DisplayColoredBmiStatus(string bmiStatus)
        {
            Console.WriteLine("BMI Status:");

            switch (bmiStatus)
            {
                case "Je hebt ondergewicht":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "Je gewicht is normaal":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "Je hebt overgewicht":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "Je hebt obesitas":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine(bmiStatus);
            Console.ResetColor();
        }
    }
}
