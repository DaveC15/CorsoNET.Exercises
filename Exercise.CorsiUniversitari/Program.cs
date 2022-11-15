using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Exercise.CorsiUniversitari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            Esame prova = new Esame();
            Esame prova2 = new Esame();
            Esame prova3 = new Esame();
            int Matricola = 0;
            Dictionary<CORSI, Dictionary<int, List<Esame>>> CorsiUniversitari = new Dictionary<CORSI, Dictionary<int, List<Esame>>>();

            foreach(CORSI corsi in (CORSI[])Enum.GetValues(typeof(CORSI)))
            {
                CorsiUniversitari.Add(corsi, new());
            }
            #region Aggiunta Matricole
            CorsiUniversitari[CORSI.INFORMATICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.INFORMATICA][Matricola].Add(prova);
            Matricola++;
            CorsiUniversitari[CORSI.INFORMATICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.INFORMATICA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.INFORMATICA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.INFORMATICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.INFORMATICA][Matricola].Add(prova);
            Matricola++;
            CorsiUniversitari[CORSI.INFORMATICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.INFORMATICA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.INFORMATICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.INFORMATICA][Matricola].Add(prova);
            Matricola++;
            CorsiUniversitari[CORSI.INFORMATICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.INFORMATICA][Matricola].Add(prova2);

            Matricola++;
            CorsiUniversitari[CORSI.MEDICINA].Add(Matricola, new());
            CorsiUniversitari[CORSI.MEDICINA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.MEDICINA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.MEDICINA].Add(Matricola, new());
            CorsiUniversitari[CORSI.MEDICINA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.MEDICINA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.MEDICINA].Add(Matricola, new());
            CorsiUniversitari[CORSI.MEDICINA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.MEDICINA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.MEDICINA].Add(Matricola, new());
            CorsiUniversitari[CORSI.MEDICINA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.MEDICINA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.MEDICINA].Add(Matricola, new());
            CorsiUniversitari[CORSI.MEDICINA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.MEDICINA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.MEDICINA].Add(Matricola, new());
            CorsiUniversitari[CORSI.MEDICINA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.MEDICINA][Matricola].Add(prova3);

            Matricola++;
            CorsiUniversitari[CORSI.INGEGNERIA].Add(Matricola, new());
            CorsiUniversitari[CORSI.INGEGNERIA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.INGEGNERIA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.INGEGNERIA].Add(Matricola, new());
            CorsiUniversitari[CORSI.INGEGNERIA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.INGEGNERIA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.INGEGNERIA].Add(Matricola, new());
            CorsiUniversitari[CORSI.INGEGNERIA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.INGEGNERIA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.INGEGNERIA].Add(Matricola, new());
            CorsiUniversitari[CORSI.INGEGNERIA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.INGEGNERIA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.INGEGNERIA].Add(Matricola, new());
            CorsiUniversitari[CORSI.INGEGNERIA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.INGEGNERIA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.INGEGNERIA].Add(Matricola, new());
            CorsiUniversitari[CORSI.INGEGNERIA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.INGEGNERIA][Matricola].Add(prova3);

            Matricola++;
            CorsiUniversitari[CORSI.CHIMICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.CHIMICA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.CHIMICA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.CHIMICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.CHIMICA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.CHIMICA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.CHIMICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.CHIMICA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.CHIMICA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.CHIMICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.CHIMICA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.CHIMICA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.CHIMICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.CHIMICA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.CHIMICA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.CHIMICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.CHIMICA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.CHIMICA][Matricola].Add(prova3);

            Matricola++;
            CorsiUniversitari[CORSI.MATEMATICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.MATEMATICA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.MATEMATICA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.MATEMATICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.MATEMATICA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.MATEMATICA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.MATEMATICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.MATEMATICA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.MATEMATICA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.MATEMATICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.MATEMATICA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.MATEMATICA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.MATEMATICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.MATEMATICA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.MATEMATICA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.MATEMATICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.MATEMATICA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.MATEMATICA][Matricola].Add(prova3);

            Matricola++;
            CorsiUniversitari[CORSI.FISICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.FISICA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.FISICA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.FISICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.FISICA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.FISICA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.FISICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.FISICA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.FISICA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.FISICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.FISICA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.FISICA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.FISICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.FISICA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.FISICA][Matricola].Add(prova3);
            Matricola++;
            CorsiUniversitari[CORSI.FISICA].Add(Matricola, new());
            CorsiUniversitari[CORSI.FISICA][Matricola].Add(prova2);
            CorsiUniversitari[CORSI.FISICA][Matricola].Add(prova3);
            #endregion

            foreach (CORSI corsi in (CORSI[])Enum.GetValues(typeof(CORSI)))
            {
                Console.Write("Dipartimento: ");
                Console.WriteLine(corsi);
                foreach (var item in CorsiUniversitari[corsi].Keys)
                {
                    Console.Write("Matricola: ");
                    Console.WriteLine(item);
                    foreach (var item2 in CorsiUniversitari[corsi][item])
                    {
                        Console.Write("Voto: ");
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
