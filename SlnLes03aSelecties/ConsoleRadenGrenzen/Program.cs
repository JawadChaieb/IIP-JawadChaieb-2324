using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRadenGrenzen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int getal1, getal2, userGuess, randomNumber;
            Console.WriteLine("Geef 2 gehele getallen");
            Console.Write("- getal 1: ");
            getal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("- getal 2: ");
            getal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Even denken... ja, ik heb een getal tussen " + getal1 + " en " + getal2 + " in mijn hoofd.");

            if (getal1 > getal2)
            {
                int temp = getal1;
                getal1 = getal2;
                getal2 = temp;
            }

            randomNumber = new Random().Next(getal1, getal2);

            Console.Write("Enter your guess: ");
            userGuess = Convert.ToInt32(Console.ReadLine());

            if (userGuess == randomNumber)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("JUIST");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FOUT");

                int difference = Math.Abs(randomNumber - userGuess);

                if (difference <= 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Je zat er nochtans niet ver af!");
                }
            }

            Console.ResetColor();
        }
            }
        }
