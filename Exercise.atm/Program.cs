using System;

namespace Exercise.atm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Conto c1= new Conto();
            ATM atm = new ATM();
            
            
        }

        public static void check(ATM a, Conto c)
        {
            int amount;
            if (a.countryATM == c.country)
            {
                Console.WriteLine("Puoi effettuare tutte le operazioni");
            }
            else
            {
                Console.WriteLine("Puoi solo prelevare");
                amount = Int32.Parse(Console.ReadLine());
                a.Prelievo(c, amount);
            }
        }
    }
    


    internal class Conto
    {
        int Saldo;
        int Interessi;
        
        public Country country { get; } = Country.Italia;

        public void Deposito(int soldi)
        {
            Saldo += soldi;
        }

        public void Prelievo(int amount)
        {
            Saldo = Saldo - amount;
        }

        public int SaldoRimasto()
        {
            return Saldo;
        }

        public int InteressiMaturati()
        {
            Interessi += 10;
            Saldo += Interessi;
            return Interessi;
        }

        
        
    }

    
    internal class ATM
    {
        public Country countryATM = Country.Germania;
        public void Deposito(Conto c, int am)
        {
            if (c.country == countryATM)
            {
                c.Deposito(am);
            }
            else
            {
                Console.WriteLine("Non puoi effettuare questa operazione");
            }
        }

        public void Prelievo(Conto c, int am)
        {
            if (c.country == countryATM)
            {
                c.Prelievo(am);
            }
            else
            {
                Console.WriteLine("Non puoi effettuare questa operazione");
            }
        }

        public void SaldoRimasto(Conto c)
        {
            if (c.country == countryATM)
            {
                c.SaldoRimasto();
            }
            else
            {
                Console.WriteLine("Non puoi effettuare questa operazione");
            }

        }

        public void InteressiMaturati(Conto c)
        {
            if (c.country == countryATM)
            {
                c.InteressiMaturati();
            }
            else
            {
                Console.WriteLine("Non puoi effettuare questa operazione");
            }
        }
    }
    
    

    public enum Country
    {
        Germania,
        Italia,
        Francia
    }
}
