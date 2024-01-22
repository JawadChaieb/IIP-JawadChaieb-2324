using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBergbeklimmen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hoogtes = new int[0];
            int vorigeHoogte = 0;

            while (true)
            {
                Console.Write("Voer een hoogtemeting in (in m): ");
                string invoer = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(invoer))
                {
                    break;
                }

                if (!int.TryParse(invoer, out int hoogte) || hoogte < 0)
                {
                    Console.WriteLine("Ongeldige invoer. Probeer opnieuw.");
                    continue;
                }

                Array.Resize(ref hoogtes, hoogtes.Length + 1);
                hoogtes[hoogtes.Length - 1] = hoogte;

                int huidigeStijging = hoogte - vorigeHoogte;
                if (huidigeStijging > 0)
                {
                    Console.WriteLine($"Stijging van {vorigeHoogte}m naar {hoogte}m: {huidigeStijging} meter");
                }

                vorigeHoogte = hoogte;
            }

            Console.WriteLine($"De hoogteverschillen zijn: {string.Join(", ", BerekenStijgingen(hoogtes))} meter");
            Console.WriteLine($"De hoogste stijging is {BerekenSterksteStijging(BerekenStijgingen(hoogtes))} meter");
            Console.WriteLine($"De totale stijging is {BerekenTotaleStijging(BerekenStijgingen(hoogtes))} meter");

            Console.ReadKey();
        }

        static int[] BerekenStijgingen(int[] hoogtes)
        {
            return hoogtes.Select((hoogte, index) => index > 0 ? hoogte - hoogtes[index - 1] : 0).ToArray();
        }

        static int BerekenSterksteStijging(int[] stijgingen)
        {
            return stijgingen.Max();
        }

        static int BerekenTotaleStijging(int[] stijgingen)
        {
            return stijgingen.Sum();
        }
    }
}
    