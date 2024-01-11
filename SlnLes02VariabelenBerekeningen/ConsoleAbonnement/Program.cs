using System;

namespace OdiseeX_Bestelgegevens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bestelgegevens");
            Console.WriteLine("==============");
            Console.WriteLine("naam klant: ");
            string naamKlant = Console.ReadLine();

            Console.WriteLine("aantal toegangsbeurten: ");
            int aantalToegangsbeurten = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("prijs (b.v. 122,5): ");
            double prijs = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("- badkledij inbegrepen (typ true of false): ");
            bool badkledijInbegrepen = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("- geslacht (druk 'm' of 'v'): ");
            char geslacht = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.WriteLine("Samenvatting");
            Console.WriteLine("==============");
            Console.WriteLine($"houder: {naamKlant}");
            Console.WriteLine($"- geslacht: {geslacht}");
            Console.WriteLine($"- prijs: €{prijs}");
            Console.WriteLine($"aantal beurten: {aantalToegangsbeurten}");
            Console.WriteLine($"incl. badkledij: {badkledijInbegrepen}");
            ///Console.WriteLine($"- kaartnummer: {GetRandomCardNumber()}");
            Console.WriteLine("druk op een toets om verder te gaan...");
            Console.ReadKey();
        }
    }
}