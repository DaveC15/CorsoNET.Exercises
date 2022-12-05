using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace Exercise.CovidUE
{
    public static class UE
    {
        static int PositiviTOT;
        public static List<Country> countries = new List<Country>();

        public static void addCountry(Country country)
        {
            countries.Add(country);
        }

        public static void Ricalcola()
        {
            PositiviTOT = 0;
            foreach(Country c in countries)
            {
                PositiviTOT += c.Positivi;
                System.Console.WriteLine($"I positivi in {c.Name} sono: {c.Positivi}");
            }
            if(PositiviTOT <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"I positivi totali in europa sono: {PositiviTOT}");
                Console.ResetColor();
            }
            else if(PositiviTOT > 10 && PositiviTOT <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine($"I positivi totali in europa sono: {PositiviTOT}");
                Console.ResetColor();
            }
            else if(PositiviTOT > 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"I positivi totali in europa sono: {PositiviTOT}");
                Console.ResetColor();
            }
            
        }
    }
}
