using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLancering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel seconden tot lancering: ");
            int aantalSeconden = int.Parse(Console.ReadLine());

            // Tel af tot de lancering met een for-loop
            for (int i = aantalSeconden; i >= 0; i--)
            {
                Console.WriteLine("Aftellen: " + i + " seconden");
            }

            Console.WriteLine("Lift off!");

            Console.ReadKey();
        }
    }
}
