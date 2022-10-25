using System;

namespace Team.Exercise.Polimorfismo.Eurozone
{
    public class CountryUE : Country, UnioneEuropea, CorteEuropea, EuroCntralBank
    {

        public CountryUE(int popolazione, float areaGeografica, string continente, string costituzione, string bandiera, string moneta, string linguaufficiale, float pil, bool penamorte, string name) : base(popolazione, areaGeografica, continente, costituzione, bandiera, moneta, linguaufficiale, pil, penamorte, name)
        {

        }
        public void monetaUnica()
        {
            if (_moneta.ToLower() == "euro")
            {
                Console.WriteLine(_nome + " è un paese con moneta unica");
            }
            else Console.WriteLine(_nome + " non è un paese con moneta unica");
        }
        public void costituzioneEuro()
        {
            Console.WriteLine("Aderisce alla Costituzione Europea");
        }
        public void EMA()
        {
            Console.WriteLine("Aderisce all' Agenzia Europea per i Medicinali");
        }
        public bool checkEuroZona()
        {
            if (_moneta.ToLower().Contains("euro"))
                return true;
            else return false;
        }

        public void penaMorte()
        {
            if (_penaMorte)
                Console.WriteLine("Non rispetti i diritti umani");
            else Console.WriteLine("Rispetti i diritti umani");
        }

        public void calculateSpread()
        {
            Random random = new Random();
            if (checkEuroZona())
                Console.WriteLine("Spread: " + _pil * random.Next(100, 300));
            else Console.WriteLine(_nome + " non è parte dell'eurozona");
        }
    }
}
