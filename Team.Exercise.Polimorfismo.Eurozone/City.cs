using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team.Exercise.Polimorfismo.Eurozone
{
    public class City
    {
        private string _nome;
        public List<Citizen> _citizenList;
        public string _myCountry;
        Country _country;
        public City(string nome, string mycountry, Country country)
        {
            _nome = nome;
            _myCountry = mycountry;
            _country = country;
            _country.addCity(this);
        }

        void RemoveCountry()
        {
            _country.removeCity(this);
            _country = null;


        }

        public void UpdateCountry(Country newcountry)
        {
            RemoveCountry();
            _country = newcountry;
            _country.addCity(this);
        }

        public void addCitizen(Citizen newcitizen)
        {
            if (_citizenList.IndexOf(newcitizen) == -1)
            {
                _citizenList.Add(newcitizen);
            }
        }

        public void removeCitizen(Citizen newcitizen)
        {
            if (_citizenList.IndexOf(newcitizen) != -1)
            {
                _citizenList.Remove(newcitizen);
            }
            
        }
    }
}
