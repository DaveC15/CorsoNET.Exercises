using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Exercise.WriteFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> persona = new List<Persona>() { new Persona {name = "davide", surname="chiesa" }, new Persona { name = "mario", surname = "rossi" } };
            WriteonFile<Persona>(@"C:\LOG\persona.txt", persona);
            List<Conto> _conto = new List<Conto>() { new Conto { id = "TSBSJ53738" }, new Conto { id = "OKGNY73839"} };
            WriteonFile<Conto>(@"C:\LOG\conto.txt", _conto);
        }
        public static void WriteonFile<T>(string path, List<T> ts) where T : class, new()
        {
            List<string> list = new List<string>();
            var cols = ts[0].GetType().GetProperties();
            foreach ( var line in ts )
            {
                foreach (var col in cols)
                {
                    list.Add($"--{col.Name}: ");
                    list.Add(col.GetValue(line).ToString());
                }
                list.Add("");
            }
            /* Controllo precedente
            if (ts is List<Persona>)
            {
                List<Persona> person = ts.Cast<Persona>().ToList();
                foreach (var item in person)
                {
                    list.Add(item.name);
                    list.Add(item.surname);
                }
            }
            else
            {
                List<Conto> conto = ts.Cast<Conto>().ToList();
                foreach (var item in conto)
                {
                    list.Add(item.id);
                }
            }*/
            File.WriteAllLines(path, list);
        }
    }

    public class Persona
    {
        public string name { get; set; }
        public string surname { get; set; }

    }
    public class Conto
    {
        public string id { get; set; }
    }
    
    
}
