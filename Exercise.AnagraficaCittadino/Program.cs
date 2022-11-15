using System;
using System.Collections.Generic;

namespace Exercise.AnagraficaCittadino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<ENTI,List<string>>> Anagrafica = new Dictionary<string, Dictionary<ENTI, List<string>>>();
            Anagrafica.Add("CRT45HSJ788SK9",new());
            Anagrafica.Add("CRgh63mdi92md9", new());
            int i = 0;


            #region Aggiunta valori anagrafica
            Anagrafica["CRT45HSJ788SK9"].Add(ENTI.POLIZIA, new());
            Anagrafica["CRT45HSJ788SK9"].Add(ENTI.ASL, new());
            Anagrafica["CRT45HSJ788SK9"].Add(ENTI.INPS, new());
            Anagrafica["CRT45HSJ788SK9"].Add(ENTI.COMUNE, new());
            Anagrafica["CRT45HSJ788SK9"].Add(ENTI.SCUOLA, new());

            if (Anagrafica["CRT45HSJ788SK9"].ContainsKey(ENTI.POLIZIA))
            {
                Anagrafica["CRT45HSJ788SK9"][ENTI.POLIZIA].Add("Fedina Pulita");
            }
            if (Anagrafica["CRT45HSJ788SK9"].ContainsKey(ENTI.ASL))
            {
                Anagrafica["CRT45HSJ788SK9"][ENTI.ASL].Add("Medico base: Ferri");
                Anagrafica["CRT45HSJ788SK9"][ENTI.ASL].Add("Stato salute: Buona");
            }
            if (Anagrafica["CRT45HSJ788SK9"].ContainsKey(ENTI.INPS))
            {
                Anagrafica["CRT45HSJ788SK9"][ENTI.INPS].Add("Lavoratore");
                Anagrafica["CRT45HSJ788SK9"][ENTI.INPS].Add("Dipendente");
                Anagrafica["CRT45HSJ788SK9"][ENTI.INPS].Add("Contratto metalmecanico");
                Anagrafica["CRT45HSJ788SK9"][ENTI.INPS].Add("Stato contributi: Pagati");
            }
            if (Anagrafica["CRT45HSJ788SK9"].ContainsKey(ENTI.COMUNE))
            {
                Anagrafica["CRT45HSJ788SK9"][ENTI.COMUNE].Add("Residenza: via rossi 2");
                Anagrafica["CRT45HSJ788SK9"][ENTI.COMUNE].Add("Nazionalità: italiana");
            }
            if (Anagrafica["CRT45HSJ788SK9"].ContainsKey(ENTI.SCUOLA))
            {
                Anagrafica["CRT45HSJ788SK9"][ENTI.SCUOLA].Add("Titolo studi: Laureato");
                Anagrafica["CRT45HSJ788SK9"][ENTI.SCUOLA].Add("Stato studi: Completati");
            }

            


            Anagrafica["CRgh63mdi92md9"].Add(ENTI.POLIZIA, new());
            Anagrafica["CRgh63mdi92md9"].Add(ENTI.ASL, new());
            Anagrafica["CRgh63mdi92md9"].Add(ENTI.COMUNE, new());
            Anagrafica["CRgh63mdi92md9"].Add(ENTI.SCUOLA, new());

            Anagrafica["CRgh63mdi92md9"][ENTI.POLIZIA].Add("Fedina Pulita");
            Anagrafica["CRgh63mdi92md9"][ENTI.ASL].Add("Medico base: rossi");
            Anagrafica["CRgh63mdi92md9"][ENTI.ASL].Add("Stato salute: Buona");
            Anagrafica["CRgh63mdi92md9"][ENTI.ASL].Add("Donatore");
            Anagrafica["CRgh63mdi92md9"][ENTI.COMUNE].Add("Residenza: via rossi 2");
            Anagrafica["CRgh63mdi92md9"][ENTI.COMUNE].Add("Nazionalità: italiana");
            Anagrafica["CRgh63mdi92md9"][ENTI.SCUOLA].Add("Titolo studi: Diploma");
            Anagrafica["CRgh63mdi92md9"][ENTI.SCUOLA].Add("Stato studi: In corso");
            #endregion


            Console.WriteLine("Questi sono i codici fiscali dei cittadini presenti");
            Console.WriteLine("\n");
            foreach(var item in Anagrafica.Keys)
            {
                Console.WriteLine($"Press {i} for");
                i++;
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            i = 0;
            string input = Console.ReadLine();

            if (input == "0") 
            {
                Console.WriteLine("Questi sono gli enti che hanno dei dati pe il cittadino \"CRT45HSJ788SK9\"");
                Console.WriteLine("\n");
                foreach (var item in Anagrafica["CRT45HSJ788SK9"].Keys)
                {
                    Console.WriteLine($"Press {i} for");
                    i++;
                    Console.WriteLine(item);
                }
                Console.WriteLine("Or Press T per visualizzare tutto");

                Console.WriteLine("\n");

                input = Console.ReadLine();

                switch(input)
                {
                    case "0":
                        foreach (var item in Anagrafica["CRT45HSJ788SK9"][ENTI.POLIZIA])
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        break;
                        case "1":
                        foreach (var item in Anagrafica["CRT45HSJ788SK9"][ENTI.ASL])
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        break;
                        case "2":
                        foreach (var item in Anagrafica["CRT45HSJ788SK9"][ENTI.INPS])
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        break;
                        case "3":
                        foreach (var item in Anagrafica["CRT45HSJ788SK9"][ENTI.COMUNE])
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        break;
                        case "4":
                        foreach (var item in Anagrafica["CRT45HSJ788SK9"][ENTI.SCUOLA])
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        break;
                        case "T":
                        foreach (var item in Anagrafica["CRT45HSJ788SK9"][ENTI.POLIZIA])
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        foreach (var item in Anagrafica["CRT45HSJ788SK9"][ENTI.ASL])
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        foreach (var item in Anagrafica["CRT45HSJ788SK9"][ENTI.INPS])
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        foreach (var item in Anagrafica["CRT45HSJ788SK9"][ENTI.COMUNE])
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        foreach (var item in Anagrafica["CRT45HSJ788SK9"][ENTI.SCUOLA])
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Questi sono gli enti che hanno dei dati pe il cittadino \"CRgh63mdi92md9\"");
                Console.WriteLine("\n");
                foreach (var item in Anagrafica["CRgh63mdi92md9"].Keys)
                {
                    Console.WriteLine($"Press {i} for");
                    i++;
                    Console.WriteLine(item);
                }
                Console.WriteLine("Or Press T per visualizzare tutto");
                Console.WriteLine("\n");

                input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        foreach (var item in Anagrafica["CRgh63mdi92md9"][ENTI.POLIZIA])
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        break;
                    case "1":
                        foreach (var item in Anagrafica["CRgh63mdi92md9"][ENTI.ASL])
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        break;
                    case "2":
                        foreach (var item in Anagrafica["CRgh63mdi92md9"][ENTI.COMUNE])
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        break;
                    case "3":
                        foreach (var item in Anagrafica["CRgh63mdi92md9"][ENTI.SCUOLA])
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        break;
                    case "T":
                        foreach (var item in Anagrafica["CRgh63mdi92md9"][ENTI.POLIZIA])
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        foreach (var item in Anagrafica["CRgh63mdi92md9"][ENTI.ASL])
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        foreach (var item in Anagrafica["CRgh63mdi92md9"][ENTI.COMUNE])
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        foreach (var item in Anagrafica["CRgh63mdi92md9"][ENTI.SCUOLA])
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        break;

                }
            }
            
        }
    }
    public enum ENTI
    {
        POLIZIA,
        ASL,
        INPS,
        COMUNE,
        SCUOLA
    }
}
