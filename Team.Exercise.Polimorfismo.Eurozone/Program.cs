using System;

namespace Team.Exercise.Polimorfismo.Eurozone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountryEU_ONU italiaCountry = new CountryEU_ONU(60000, 324000, "Europa", "Costituzione Italiana", "VerdeBiancoRosso", "Euro", "Italiano", 100, false, "Italia");
            CountryEU_ONU franciaCountry = new CountryEU_ONU(67000, 675000, "Europa", "Costituzione Francese", "BluBiancoRosso", "Euro", "Francese", 150, false, "Francia");
            CountryEU_ONU germaniaCountry = new CountryEU_ONU(83000, 357000, "Europa", "Legge Fondamentale Tedesca", "NeroRossoGiallo", "Euro", "Tedesco", 200, false, "Germania");
            CountryEU_ONU PortogalloCountry = new CountryEU_ONU(83000, 357000, "Europa", "Costituzione del Portogallo", "VerdeGialloRosso", "Euro", "Portoghese", 200, false, "Portogallo");
            CountryEU_ONU GreciaCountry = new CountryEU_ONU(83000, 357000, "Europa", "Costituzione della Grecia", "BluBianco", "Euro", "Greco", 200, false, "Grecia");

            CountryONU cinaCountry = new CountryONU(1400000, 9706000, "Asia", "Costituzione della Repubblica Popolare Cinese", "RossoGiallo", "Renminbi", "Cinese Mandarino", 30, true, "Cina");

            Continent Europa = new Continent("Europa");

            City Torino = new City("Torino", italiaCountry, 2);
            City Parigi = new City("Parigi", franciaCountry, 5);
            City Lisbona = new City("Lisbona", PortogalloCountry, 8);
            City Atene = new City("Atene", GreciaCountry, 2);

            Citizen Davide = new Citizen("Davide","Rossi", Torino);
            /*Citizen Luca = new Citizen("Luca", "Verdi", Lisbona);
            Citizen Mario = new Citizen("Mario", "Porti", Atene);
            Citizen Ross = new Citizen("Ross", "Perla", Torino);
            Citizen Mer = new Citizen("Mer", "Red", Torino);
            Citizen Paul = new Citizen("Paul", "Goustau", Parigi);*/

            italiaCountry._citiesList.ForEach(PrintCity);
            Console.WriteLine("\n");

            Torino._citizenList.ForEach(PrintCitizen);
            Console.WriteLine("\n");

            Europa.addCountry(italiaCountry);
            Europa.addCountry(franciaCountry);
            Europa.addCountry(germaniaCountry);
            Console.WriteLine("Il continente " + Europa._nome + " contiene questi paesi:");
            Europa._countryList.ForEach(PrintCountry);
            Console.WriteLine("\n");

            Console.WriteLine("Francia");
            franciaCountry.penaMorte();
            franciaCountry.calculateSpread();
            Console.WriteLine("*\n");

            Console.WriteLine("Cina");
            cinaCountry.penaMorte();
            Console.WriteLine("*\n");

            Davide.Apertura(Torino);
            Davide.Apertura(Lisbona);
            Davide.Apertura(Atene);

        }
        static void PrintCountry(Country c)
        {
            Console.WriteLine(c._nome);
        }
        static void PrintCitizen(Citizen c)
        {
            Console.WriteLine(c._nome);
        }
        static void PrintCity(City c)
        {
            Console.WriteLine(c._nome);
        }
    }

    
}
