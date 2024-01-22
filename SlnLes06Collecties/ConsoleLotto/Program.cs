using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELKOM OP DE LOTTOTREKKING");
            Console.WriteLine("===========================");

            int[] vasteGetallen = { 4, 8, 17, 22, 31, 39, 41 };

            int[] gebruikerGetallen = new int[6];

            Console.Write("Geef 6 getallen tussen 1 en 42 gescheiden door spaties: ");
            string invoer = Console.ReadLine();
            string[] getalStrings = invoer.Split(' ');

            for (int i = 0; i < gebruikerGetallen.Length; i++)
            {
                gebruikerGetallen[i] = Convert.ToInt32(getalStrings[i]);
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
    }
}
