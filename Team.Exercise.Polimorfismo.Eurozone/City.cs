using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team.Exercise.Polimorfismo.Eurozone
{
    public class City
    {
        public string _nome;
        public List<Citizen> _citizenList;
        Country _country;
        public City(string nome, Country country)
        {
            _nome = nome;
            _country = country;
            _citizenList = new List<Citizen>();
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
