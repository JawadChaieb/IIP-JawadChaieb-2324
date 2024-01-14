using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKlinkersSpaties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string zin = Console.ReadLine().ToLower();

            int klinkers = TelKlinkers(zin);
            int spaties = TelSpaties(zin);

            Console.WriteLine($"Deze tekst bevat {klinkers} klinkers en {spaties} spaties");
            Console.WriteLine($"In geheimschrift: {NaarGeheimschrift(zin)}");
            Console.ReadLine();
        }

        static int TelKlinkers(string zin)
        {
            int klinkers = 0;
            string klinkerLetters = "aeiou";

            foreach (char letter in zin)
            {
                if (klinkerLetters.Contains(letter))
                {
                    klinkers++;
                }
            }

            return klinkers;
        }

        static int TelSpaties(string zin)
        {
            int spaties = 0;

            foreach (char letter in zin)
            {
                if (letter == ' ')
                {
                    spaties++;
                }
            }

            return spaties;
        }

        static string NaarGeheimschrift(string tekst)
        {
            string geheimschrift = "";

            foreach (char letter in tekst)
            {
                if (letter != ' ')
                {
                    geheimschrift += (char)(letter + 1);
                }
                else
                {
                    geheimschrift += ' ';
                }
            }

            return geheimschrift;
        }
    }
}
