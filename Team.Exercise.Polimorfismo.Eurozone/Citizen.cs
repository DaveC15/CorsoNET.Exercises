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
        public string _city;

        public Citizen(string nome, string cognome, string city)
        {
            _nome = nome;
            _cognome = cognome; 
            _city = city;
        }
    }
}
