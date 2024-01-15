using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleComplexiteit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Geef een woord (enter om te stoppen): ");
                string invoer = Console.ReadLine();

                if (string.IsNullOrEmpty(invoer))
                {
                    break;
                }

                double complexiteit = BerekenComplexiteit(invoer);

                Console.WriteLine($"Aantal tekens: {invoer.Length}");
                Console.WriteLine($"Aantal lettergrepen: {TelLetterGroepen(invoer)}");
                Console.WriteLine($"Complexiteit: {complexiteit:F1}");
                Console.WriteLine();
            }

            Console.WriteLine("Bedankt en tot ziens.");
            Console.ReadKey();
        }

        private static bool IsKlinker(char c)
        {
            return "aeiouy".Contains(char.ToLower(c));
        }

        private static int TelLetterGroepen(string woord)
        {
            int letterGroepen = 0;
            bool laatsteWasKlinker = false;

            foreach (char c in woord)
            {
                if (IsKlinker(c))
                {
                    if (!laatsteWasKlinker)
                    {
                        letterGroepen++;
                    }
                    laatsteWasKlinker = true;
                }
                else
                {
                    laatsteWasKlinker = false;
                }
            }

            return letterGroepen;
        }

        private static double BerekenComplexiteit(string woord)
        {
            return Math.Round((woord.Length / 3.0) + TelLetterGroepen(woord) + (woord.ToLower().BevatEenVanDeLetters(new[] { 'x', 'y', 'q' }) ? 1 : 0), 1);
        }
    }

    static class Uitbreidingen
    {
        public static bool BevatEenVanDeLetters(this string bron, params char[] waarden)
        {
            foreach (char waarde in waarden)
            {
                if (bron.Contains(waarde))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
