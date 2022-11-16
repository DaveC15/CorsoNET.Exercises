﻿using System;
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
            List<Persona> list = new List<Persona>() { new Persona {name = "davide", surname="chiesa" }, new Persona { name = "mario", surname = "rossi" } };
            Prova(@"C:\LOG\prova.txt", list);
        }
        public static void Prova<T>(string path, List<T> ts)
        {
            List<string> list = new List<string>();
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
            }
            if (!File.Exists(path))
            {
                File.Create(path);
                
            }
            
            File.WriteAllLines(path, list);
        }
    }

    public class Persona
    {
        public string name;
        public string surname;
    }
    public class Conto
    {
        public string id;
    }
    
    
}
