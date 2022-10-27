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
        public City(string nome, string mycountry)
        {
            _nome = nome;
            _myCountry = mycountry;
        }
        
        public void addCitizen(Citizen newCitizen)
        {
            if (_citizenList.IndexOf(newCitizen) == -1)
            {
                _citizenList.Add(newCitizen);
            }
        }

        public void removeCitizen(Citizen newCitizen, City newCity)
        {
            if (_citizenList.IndexOf(newCitizen) != -1)
            {
                _citizenList.Remove(newCitizen);
                newCity.addCitizen(newCitizen);
            }
            
        }
    }
}
