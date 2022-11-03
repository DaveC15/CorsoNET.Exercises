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
        public DateTime _date;
        bool ismaggiorenne;
        City _city1;

        public Citizen(string nome, string cognome, City city1)
        {
            _nome = nome;
            _cognome = cognome;
            _city1 = city1;
            _city1.addCitizen(this);
            InserisciData();
            DateTime c = DateTime.Now;
            int y = c.Year - _date.Year;
            
            if (y >= 18) 
            {
                ismaggiorenne = true;
                _city1.IscriviaComune(this);
                
            }
            else
            {
                Console.WriteLine("Cittadino non aggiunto al comune in quanto minorenne");
            }
            
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

        public void InserisciData()
        {
            Console.WriteLine("Inserire la tua data di Nascita: ");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out _date))
            {
                Console.WriteLine($" - Data di nascita: {_date}");
            }
            else
            {
                Console.WriteLine($" - Data di nascita non corretta ");

            }
        }

        public void Apertura(City city)
        {
            DateTime dateTime;
            if (city._country._nome == "Portogallo" || city._country._nome == "Inghilterra")
            {
                dateTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "GMT Standard Time");
                if (dateTime.Hour >= city._aperturaComune.Hours && dateTime.Hour <= 18)
                {
                    Console.WriteLine("Il comune è aperto");
                }
                else
                {
                    TimeSpan r = new TimeSpan(-1, 12, 0, 0);
                    TimeSpan p = new TimeSpan(0, dateTime.Hour, dateTime.Minute, dateTime.Second);
                    Console.WriteLine($"Mancano {(-(r - (city._aperturaComune - (r + p)))).ToString(@"hh\:mm\:ss")} ore all'apertura del Comune di {city._nome}");
                }
                
                
            }
            else if (city._country._nome == "Italia" || city._country._nome == "Francia" || city._country._nome == "Germania")
            {
                dateTime = DateTime.Now;
                if (dateTime.Hour >= city._aperturaComune.Hours && dateTime.Hour <= 18)
                {
                    Console.WriteLine("Il comune è aperto");
                }
                else
                {
                    TimeSpan r = new TimeSpan(-1,12, 0, 0);
                    TimeSpan p = new TimeSpan(0, dateTime.Hour, dateTime.Minute, dateTime.Second);
                    
                    Console.WriteLine($"Mancano {(-(r - (city._aperturaComune - (r + p)))).ToString(@"hh\:mm\:ss")} ore all'apertura del Comune di {city._nome}");
                }
                
            }
            else
            {
                dateTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "GTB Standard Time");
                if (dateTime.Hour >= city._aperturaComune.Hours && dateTime.Hour <= 18)
                {
                    Console.WriteLine("Il comune è aperto");
                }
                else
                {
                    TimeSpan r = new TimeSpan(-1, 12, 0, 0);
                    TimeSpan p = new TimeSpan(0, dateTime.Hour, dateTime.Minute, dateTime.Second);
                    Console.WriteLine($"Mancano {(-(r - (city._aperturaComune - (r + p)))).ToString(@"hh\:mm\:ss")} ore all'apertura del Comune di {city._nome}");
                }
            }
        }
    }
}
