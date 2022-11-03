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
        public int _massimoabitanti;
        public List<Citizen> _citizenList = new List<Citizen>();
        public List<Citizen> _comunecitizenList = new List<Citizen>();
        public Country _country;
        public TimeSpan _aperturaComune = new TimeSpan(09, 0, 0);
        
        public City(string nome, Country country, int massimoabitanti)
        {
            _nome = nome;
            _country = country;
            _massimoabitanti = massimoabitanti;
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
            if (_citizenList.IndexOf(newcitizen) == -1 && _citizenList.Count < _massimoabitanti)
            {
                _citizenList.Add(newcitizen);
                Console.WriteLine("Cittadini attuali: " + _citizenList.Count);
                Console.WriteLine("Cittadini rimanenti: " + (_massimoabitanti- _citizenList.Count));
            }
            else
            {
                Console.WriteLine("Cittadini eccedono capacità città o il cittadino è già presente");
            }
        }

        public void removeCitizen(Citizen newcitizen)
        {
            if (_citizenList.IndexOf(newcitizen) != -1)
            {
                _citizenList.Remove(newcitizen);
            }
            
        }

        public void IscriviaComune(Citizen newcitizen) 
        {
            if (_comunecitizenList.IndexOf(newcitizen) == -1)
            {
                _comunecitizenList.Add(newcitizen);
            }
        }
        public void removedaCoumune(Citizen newcitizen)
        {
            if (_comunecitizenList.IndexOf(newcitizen) != -1)
            {
                _comunecitizenList.Remove(newcitizen);
            }

        }
    }
}
