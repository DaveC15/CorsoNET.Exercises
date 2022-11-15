using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Exercise.CorsiUniversitari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esame prova = new Esame();
            int Matricola = 0;
            Dictionary<CORSI, Dictionary<int, List<Esame>>> CorsiUniversitari = new Dictionary<CORSI, Dictionary<int, List<Esame>>>();

            foreach(CORSI corsi in (CORSI[])Enum.GetValues(typeof(CORSI)))
            {
                CorsiUniversitari.Add(corsi, new());
                CorsiUniversitari[corsi].Add(Matricola, new());
                CorsiUniversitari[corsi][Matricola].Add(prova);
                Matricola++;
            }

            foreach (CORSI corsi in (CORSI[])Enum.GetValues(typeof(CORSI)))
            {
                Console.WriteLine(corsi);
                foreach (var item in CorsiUniversitari[corsi].Keys)
                {
                    Console.WriteLine(item);
                    foreach (var item2 in CorsiUniversitari[corsi][item])
                    {
                        Console.WriteLine(item2.Voto);
                    }
                }
            }

            
        }
    }

   public class Esame
    {
        static Random rd = new Random();
        public int Voto = rd.Next(0, 31);
    }
    
    public enum CORSI
    {
        INFORMATICA,
        MEDICINA,
        INGEGNERIA,
        CHIMICA,
        MATEMATICA,
        FISICA
    }
}
