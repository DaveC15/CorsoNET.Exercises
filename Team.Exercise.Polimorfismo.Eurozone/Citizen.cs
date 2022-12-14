using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Team.Exercise.Polimorfismo.Eurozone
{
    public class Citizen
    {
        public string _nome;
        public string _cognome;
        public DateTime _date;
        public bool ismaggiorenne;
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

        }

        void RemoveCity()
        {
            _city1.removeCitizen(this);
            _city1 = null;
            if (ismaggiorenne)
            {
                _city1.removedaCoumune(this);
            }
        }

        public void UpdateCity(City newcity)
        {
            RemoveCity();
            _city1 = newcity;
            _city1.addCitizen(this);
            if (ismaggiorenne)
            {
                _city1.removedaCoumune(this);
            }
        }

        public void InserisciData()
        {
            Console.WriteLine("Inserire la tua data di Nascita: ");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out _date) == false)
            {
                Console.WriteLine($" - Data di nascita non corretta ");
            }
        }

        

        public void Apertura(City city)
        {
            bool isWindows = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            DateTime dateTime;
            if (city._country._nome == "Portogallo" || city._country._nome == "Inghilterra")
            {
                if (isWindows)
                {
                    dateTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "GMT Standard Time"); 
                }
                else dateTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "Europe/London");
                //dateTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "GMT Standard Time"); //"Europe/London" For Linux like system
                if (dateTime.Hour >= city._aperturaComune.Hours && dateTime.Hour <= 18)
                {
                    Console.WriteLine($"Il comune è aperto a {city._nome}");
                }
                else
                {
                    TimeSpan r = new TimeSpan(-1, 12, 0, 0);
                    TimeSpan p = new TimeSpan(dateTime.Hour, dateTime.Minute, dateTime.Second);
                    Console.WriteLine($"Mancano {(-(r - (city._aperturaComune - (r + p)))).ToString(@"hh\:mm\:ss")} ore all'apertura del Comune di {city._nome}");
                }
                
                
            }
            else if (city._country._nome == "Italia" || city._country._nome == "Francia" || city._country._nome == "Germania")
            {
                if (isWindows)
                {
                    dateTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "Central Europe Standard Time"); 
                }
                else dateTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "Europe/Rome");
                //dateTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "Central Europe Standard Time"); //"Europe/Rome" For Linux like system
                if (dateTime.Hour >= city._aperturaComune.Hours && dateTime.Hour <= 18)
                {
                    Console.WriteLine($"Il comune è aperto a {city._nome}");
                }
                else
                {
                    TimeSpan r = new TimeSpan(-1,12, 0, 0);
                    TimeSpan p = new TimeSpan(dateTime.Hour, dateTime.Minute, dateTime.Second);
                    
                    Console.WriteLine($"Mancano {(-(r - (city._aperturaComune - (r + p)))).ToString(@"hh\:mm\:ss")} ore all'apertura del Comune di {city._nome}");
                }
                
            }
            else
            {
                if (isWindows)
                {
                    dateTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "GTB Standard Time"); 
                }
                else dateTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "Europe/Athens");
                //dateTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "GTB Standard Time"); //"Europe/Athens" For Linux like system
                if (dateTime.Hour >= city._aperturaComune.Hours && dateTime.Hour <= 18)
                {
                    Console.WriteLine($"Il comune è aperto a {city._nome}");
                }
                else
                {
                    TimeSpan r = new TimeSpan(-1, 12, 0, 0);
                    TimeSpan p = new TimeSpan(dateTime.Hour, dateTime.Minute, dateTime.Second);
                    Console.WriteLine($"Mancano {(-(r - (city._aperturaComune - (r + p)))).ToString(@"hh\:mm\:ss")} ore all'apertura del Comune di {city._nome}");
                }
            }
        }
    }
}
