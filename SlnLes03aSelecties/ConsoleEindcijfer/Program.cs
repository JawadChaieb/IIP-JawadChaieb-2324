using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEindcijfer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double eindcijfer = 0;

            Console.WriteLine(@"Berekening eindcijfer
===============================
");
            Console.Write("Geef het cijfer dagelijks werk (op 20): ");
            double dagelijksWerk = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef het cijfer op het project (op 20): ");
            double project = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef het cijfer op het examen (op 20): ");
            double examen = Convert.ToDouble(Console.ReadLine());


            dagelijksWerk = (dagelijksWerk / 20) * 30;
            project = (project / 20) * 20;
            examen = (examen / 20) * 50;

            eindcijfer = examen + project + dagelijksWerk;

            Console.WriteLine();
            Console.WriteLine($"Je eindcijfer is {eindcijfer}%");


            switch ((int)eindcijfer)
            {
                case int n when n < 50:
                    Console.WriteLine("-> onvoldoende");
                    break;
                case int n when n >= 50 && n < 67.5:
                    Console.WriteLine("-> voldoende");
                    break;
                case int n when n >= 67.5 && n < 75:
                    Console.WriteLine("-> onderscheiding");
                    break;
                case int n when n >= 75 && n < 82.5:
                    Console.WriteLine("-> grote onderscheiding");
                    break;
                case int n when n >= 82.5:
                    Console.WriteLine("-> grootste onderscheiding");
                    break;
            }

            Console.ReadKey();
        }
    }
}
