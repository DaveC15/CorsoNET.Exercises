using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team.Exercise.Polimorfismo.Eurozone
{
    public class Citizen
    {
        public string _nome;
        public string _cognome;
        City _city1;

        public Citizen(string nome, string cognome, City city1)
        {
            _nome = nome;
            _cognome = cognome;
            _city1 = city1;
            _city1.addCitizen(this);
        }

        void RemoveCity()
        {
            _city1.removeCitizen(this);
            _city1 = null;
            
            
        }

        public void UpdateCity(City newcity)
        {
            RemoveCity();
            _city1 = newcity;
            _city1.addCitizen(this);
        }
    }
}
