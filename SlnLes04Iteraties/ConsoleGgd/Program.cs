using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGgd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voer het eerste getal in: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Voer het tweede getal in: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());

            int gcd = BerekenGCD(getal1, getal2);

            Console.WriteLine("BEREKEN GROOTST GEMENE DELER ");
            Console.WriteLine("==============================");
            Console.WriteLine("getal 1=" + getal1);
            Console.WriteLine("getal 2 =" + getal2);
            Console.WriteLine("de grootst gemene deler is:" + gcd);
            Console.ReadKey();

        }
        static int BerekenGCD(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
            Console.ReadKey();
        }
    }
}
