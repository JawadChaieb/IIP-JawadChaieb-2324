using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLottoVervolg
{
    internal class Program
    {
        const int MIN_WAARDE = 1;
        const int MAX_WAARDE = 42;
        const int AANTAL_GEBRUIKER_GETALLEN = 6;
        const int AANTAL_COMMON_VALUES = 7;

        static void Main(string[] args)
        {
                Console.WriteLine("WELKOM OP DE LOTTOTREKKING");
                Console.WriteLine("===========================");

                int[] vasteGetallen = GenereerGetallen(AANTAL_COMMON_VALUES, MIN_WAARDE, MAX_WAARDE);

                int[] gebruikerGetallen = new int[AANTAL_GEBRUIKER_GETALLEN];

                Console.Write("Geef 6 getallen tussen 1 en 42 gescheiden door spaties, of druk op Enter voor willekeurige getallen: ");
                string invoer = Console.ReadLine();

                if (string.IsNullOrEmpty(invoer))
                {
                    gebruikerGetallen = GenereerGetallen(AANTAL_GEBRUIKER_GETALLEN, MIN_WAARDE, MAX_WAARDE);
                }
                else
                {
                    string[] getalStrings = invoer.Split(' ');

                    for (int i = 0; i < gebruikerGetallen.Length; i++)
                    {
                        gebruikerGetallen[i] = Convert.ToInt32(getalStrings[i]);
                    }
                }

                int[] correcteGetallen = new int[gebruikerGetallen.Length];
                int correcteGetallenIndex = 0;

                foreach (int getal in gebruikerGetallen)
                {
                    if (vasteGetallen.Contains(getal))
                    {
                        correcteGetallen[correcteGetallenIndex] = getal;
                        correcteGetallenIndex++;
                    }
                }

                Console.WriteLine($"Trekking: {string.Join(", ", vasteGetallen)}");
                Console.Write($"Je hebt {correcteGetallenIndex} juist: ");
                for (int i = 0; i < correcteGetallenIndex; i++)
                {
                    Console.Write(correcteGetallen[i]);
                    if (i < correcteGetallenIndex - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.ReadLine();
            }

            static int[] GenereerGetallen(int aantalaantalGetallen, int minWaarde, int maxWaarde)
            {
                HashSet<int> getallen = new HashSet<int>();

                while (getallen.Count < aantalaantalGetallen)
                {
                    getallen.Add(new Random().Next(minWaarde, maxWaarde + 1));
                }

                return getallen.OrderBy(x => x).ToArray();
            }
        }
    }
