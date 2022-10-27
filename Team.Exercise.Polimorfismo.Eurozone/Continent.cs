using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team.Exercise.Polimorfismo.Eurozone
{

    public class Continent
    {
        private List<Country> _countryList;
        private string _nome;
        public Continent(string nome)
        {
            _countryList = new List<Country>();
            _nome = nome;
        }

        public void addCountry(Country newCountry)
        {
            if (_countryList.IndexOf(newCountry) == -1 && newCountry._continente == _nome)
            {
                _countryList.Add(newCountry);
            }
        }

        public void removeCountry(Country newCountry)
        {
            if (_countryList.IndexOf(newCountry) != -1 && newCountry._continente == _nome)
            {
                _countryList.Remove(newCountry);
            }
        }
    }
}
