using System.Collections.Generic;

namespace Team.Exercise.Polimorfismo.Eurozone
{
    public class Country : Territory
    {
        protected string _costituzione;
        protected string _bandiera;
        protected string _moneta;
        protected string _linguaUfficiale;
        protected float _pil;
        protected bool _penaMorte;
        public string _nome;

        public List<City> _citiesList = new List<City>();

        public Country(int popolazione, float areaGeografica, string continente, string costituzione, string bandiera, string moneta, string linguaufficiale, float pil, bool penamorte, string nome) : base(popolazione, areaGeografica, continente)
        {
            _popolazione = popolazione;
            _areaGeografica = areaGeografica;
            _continente = continente;
            _costituzione = costituzione;
            _bandiera = bandiera;
            _moneta = moneta;
            _linguaUfficiale = linguaufficiale;
            _pil = pil;
            _penaMorte = penamorte;
            _nome = nome;
        }

        public void addCity(City newcity)
        {
            if (_citiesList.IndexOf(newcity) == -1)
            {
                _citiesList.Add(newcity);
            }
        }

        public void removeCity(City newcity)
        {
            if (_citiesList.IndexOf(newcity) != -1)
            {
                _citiesList.Remove(newcity);
                
            }

        }
    }
}
