using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaswoordenSorteren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] secretCodes = { "klepketoe", "test", "Azerty123", "rogier@work", "password", "MisterNasty12", "pwnz0red" };
            int length = secretCodes.Length;

            Console.WriteLine("Alle paswoorden");
            Console.WriteLine(IsCorrectPaswoord(secretCodes, length));
            Console.ReadLine();
        }
        static private string IsCorrectPaswoord(string[] secretCodes, int length)
        {
            string passwordOk = "Ok: ";
            string passwordNietOk = "Niet ok: ";
            string result = "";

            for (int i = 0; i != length; i++)
            {
                string response = $"{i + 1}. {secretCodes[i]}";
                Console.WriteLine(response);

                if (secretCodes[i].Length >= 8 && secretCodes[i] != "password" && secretCodes[i] != "Azerty123" && !secretCodes[i].Contains('@'))
                {
                    passwordOk += $"{secretCodes[i]}, ";
                }
                else if (secretCodes[i].Contains('@'))
                {
                    passwordNietOk += $"{secretCodes[i]}, ";
                }
                else
                {
                    passwordNietOk += $"{secretCodes[i]}, ";
                }
                result = $@"{passwordOk} 
{passwordNietOk}";
            }
            Console.ReadKey();
            return result;
        }
    }
}
