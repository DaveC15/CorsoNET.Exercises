using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Exercise.WriteFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> prova = new List<Persona>() { new Persona { name = "davide", surname = "chiesa" }, new Persona { name = "mario", surname = "rossi" } };
            List<Persona> persona;
            //WriteonFile<Persona>(@"C:\LOG\persona.csv", prova);
            persona = ReadfromFile<Persona>(@"C:\LOG\persona.csv");
            foreach (var item in persona)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.surname);
            }

        }
        public static void WriteonFile<T>(string path, List<T> ts) where T : class, new()
        {
            List<string> list = new List<string>();
            StringBuilder sb = new StringBuilder();
            var cols = ts[0].GetType().GetProperties();
            if(!File.Exists(path))
            {
                foreach (var col in cols)// cicla tutte le Entity della classe in oggetto
                {
                    sb.Append(col.Name);
                    sb.Append(" ");
                }

                list.Add(sb.ToString().Substring(0, sb.Length - 1));
                
            }
            foreach (var row in ts)
            {

                sb = new StringBuilder();
                foreach (var col in cols)// cicla tutte le Entity della classe in oggetto
                {
                    sb.Append(col.GetValue(row));
                    sb.Append(" ");
                }
                list.Add(sb.ToString().Substring(0, sb.Length - 1));
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
            File.AppendAllLines(path, list);
        }
        public static List<T> ReadfromFile<T>(string path) where T : class, new()
        {
            List<T> list = new List<T>();
            var lines = File.ReadAllLines(path).ToList();
            string[] headers = lines.ElementAt(0).Split(" ");
            lines.RemoveAt(0);
            bool corretto = false;
            bool p = true;
            T entry = new T();
            var prop = entry.GetType().GetProperties();

            for (int i =0; i < prop.Length; i++)
            {
              
                    if (prop.ElementAt(i).Name == headers[i])
                    {
                        corretto = true;
                    }
                    else p= false;
                
            }

            if (corretto && p)
            {
                foreach (var line in lines)
                {
                    int j = 0;
                    string[] colons = line.Split(" ");
                    entry = new T();
                    foreach (var col in colons)
                    {
                        entry.GetType().GetProperty(headers[j]).SetValue(entry, Convert.ChangeType(col, entry.GetType().GetProperty(headers[j]).PropertyType));
                        j++;
                    }
                    list.Add(entry);
                }
            }
            else Console.WriteLine("le proprietà nel file non corrispondono a proprietà oggetto");
            

            return list;
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
