using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleBuffet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double adultBuffet = 18.5;
            const double dessertBuffet = 7.95;
            const double kidBuffet = 8.95;

            Console.WriteLine(@"WELKOM IN HET BUFFETRESTAURANT");
            Console.WriteLine("===============================");
            Console.WriteLine(" Alles is à volonté en dranken zijn inbegrepen!");
            Console.WriteLine("!!Promotie!! Vandaag ronden we het totaalbedrag af naar beneden! ");

            Console.Write($"Aantal seizoensbuffets (€{adultBuffet}): ");
            int adultBuffets = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Aantal dessertenbuffets (€{dessertBuffet}): ");
            int dessertBuffets = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Aantal kids menus (€{kidBuffet}): ");
            int kidBuffets = Convert.ToInt32(Console.ReadLine());

            double totalCost = (adultBuffet * adultBuffets) + (dessertBuffet * dessertBuffets) + (kidBuffet * kidBuffets);
            double roundedTotal = Math.Floor(totalCost);

            Console.WriteLine($"\nTotaal te betalen: €{totalCost}");
            Console.WriteLine($"Afgerond naar beneden: €{roundedTotal}\n");

            Console.Write("Cash betaald: ");
            double cash = Convert.ToDouble(Console.ReadLine());

            if (cash >= roundedTotal)
            {
                double change = cash - roundedTotal;

                int change20 = (int)(change / 20);
                change = change % 20;

                int change10 = (int)(change / 10);
                change = change % 10;

                int change5 = (int)(change / 5);
                change = change % 5;

                int change2 = (int)(change / 2);
                change = change % 2;

                int change1 = (int)(change / 1);

                Console.WriteLine("U krijgt terug: ");
                Console.WriteLine("- {0} briefje(s) van 20", change20);
                Console.WriteLine("- {0} briefje(s) van 10", change10);
                Console.WriteLine("- {0} briefje(s) van 5", change5);
                Console.WriteLine("- {0} munt(en) van 2 euro", change2);
                Console.WriteLine("- {0} munt(en) van 1 euro", change1);
            }
                Console.ReadKey();
            }
        }
}
