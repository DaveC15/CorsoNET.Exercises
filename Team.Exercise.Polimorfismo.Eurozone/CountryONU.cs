using System;

namespace Team.Exercise.Polimorfismo.Eurozone
{
    public class CountryONU : Country, ONU, CorteEuropea
    {

        public CountryONU(int popolazione, float areaGeografica, string continente, string costituzione, string bandiera, string moneta, string linguaufficiale, float pil, bool penamorte, string name) : base(popolazione, areaGeografica, continente, costituzione, bandiera, moneta, linguaufficiale, pil, penamorte, name)
        {

        }
        public void OMS()
        {
            Console.WriteLine("Aderisce all' Organizzazione Mondiale della Sanità");
        }
        public void FMI()
        {
            Console.WriteLine("Aderisce al Fondo Monetario Internazionale");
        }

        public void penaMorte()
        {
            if (_penaMorte)
                Console.WriteLine("Non rispetti i diritti umani");
            else Console.WriteLine("Rispetti i diritti umani");
        }
    }
}
