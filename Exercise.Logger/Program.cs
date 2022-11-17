using System;
using System.Collections.Generic;

namespace Exercise.Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var log = Log.Instance();
            Persona persona = new Persona() { name = "mario", surname = "rossi"};
            log.WriteLog<Persona>(persona);
        }
    }
    public class Persona
    {
        public string name { get; set; }
        public string surname { get; set; }

    }
}
