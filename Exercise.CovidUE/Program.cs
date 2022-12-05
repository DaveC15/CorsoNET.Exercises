using System;

namespace Exercise.CovidUE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Country country = new Country() { Name= "Italy"};
            country.UpdateCheck += UpdatePositivi;
            Country country1 = new Country() { Name = "France" };
            country1.UpdateCheck += UpdatePositivi;
            Country country2 = new Country() { Name = "Germany" };
            country2.UpdateCheck += UpdatePositivi;
            UE.addCountry(country);
            UE.addCountry(country1);
            UE.addCountry(country2);

            country.Positivi = 10;
            country1.Positivi = 10;
            addpositivi(country1, -5);
            addpositivi(country2, 30);
        }
        public static void UpdatePositivi(object source, UpdatePositiviEventArgs e)
        {
            UE.Ricalcola();
        }
        public static void addpositivi(Country c, int val)
        {
            c.Positivi += val;
        }
    }
}
