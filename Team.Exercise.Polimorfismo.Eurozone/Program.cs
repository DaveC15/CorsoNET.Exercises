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

            CountryONU cinaCountry = new CountryONU(1400000, 9706000, "Asia", "Costituzione della Repubblica Popolare Cinese", "RossoGiallo", "Renminbi", "Cinese Mandarino", 30, true, "Cina");


            Console.WriteLine("Francia");
            franciaCountry.penaMorte();
            franciaCountry.calculateSpread();
            Console.WriteLine("*\n");

            Console.WriteLine("Cina");
            cinaCountry.penaMorte();
            Console.WriteLine("*\n");

        }
    }

    
}
