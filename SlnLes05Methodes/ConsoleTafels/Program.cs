using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTafels
{
    internal class Program
    {
        static private void Main(string[] args)
        {
            Console.Write("getal 1: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("getal 2: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(getal1 + " x " + getal2 + " tafel:");

            DrukTafel(getal1, getal2);

            Console.ReadLine();
        }

        static private void DrukTafel(int getal1, int getal2)
        {
            for (int i = 1; i <= getal2; i++)
            {
                string tafels = "";
                int uitkomst = getal1 * i;
                tafels = $"{getal2} x {i} = {uitkomst}";
                Console.WriteLine(tafels);
            }
        }
    }
}
