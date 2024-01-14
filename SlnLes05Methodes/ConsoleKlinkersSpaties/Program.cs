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

            int klinkers = TelKarakters(zin, "aeiou");
            int spaties = TelKarakters(zin, " ");

            Console.WriteLine($"Deze tekst bevat " + klinkers + "klinkers en " + spaties + "spaties");
            Console.WriteLine($"In geheimschrift: {NaarGeheimschrift(zin)}");
            Console.ReadLine();
        }

        static int TelKarakters(string zin, string karakters)
        {
            int count = 0;

            foreach (char letter in zin)
            {
                if (karakters.Contains(letter))
                {
                    count++;
                }
            }

            return count;
        }

        static string NaarGeheimschrift(string tekst)
        {
            string geheimschrift = "";

            foreach (char letter in tekst)
            {
                geheimschrift += (letter != ' ') ? (char)(letter + 1) : ' ';
            }

            return geheimschrift;
        }
    }
}
