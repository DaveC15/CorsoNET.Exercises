using System;
using System.Runtime.Intrinsics.Arm;

namespace Exercise.Atm.DeleGate
{

    public delegate void PrelievoAction(int am);
    public delegate void DepositoAction(int am);
    public delegate int SaldoAction();
    public delegate int InteresseAction();
    internal class Program
    {
        static void Main(string[] args)
        {
            Conto conto1 = new Conto() { country = Country.Italia};
            ATMGermania atmgermania = new ATMGermania();
            PrelievoAction prelievo = conto1.Prelievo;
            DepositoAction deposito = conto1.Deposito;
            SaldoAction saldo = conto1.SaldoRimasto;
            InteresseAction interesse = conto1.InteressiMaturati;
            int amount = 0;
            int scelta;
            if (!conto1.status)
            {
                Console.WriteLine("Puoi solo prelevare. Quanto desideri prelevare? ");
                amount = Int32.Parse(Console.ReadLine());
                atmgermania.Prelievo(prelievo, amount);
            }
            else
            {
                Console.WriteLine("Scegli cosa fare: 1 Daposito, 2 Prelievo, 3 Saldo, 4 Interesse");
                scelta= Int32.Parse(Console.ReadLine());
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Quanto desideri depositare? ");
                        amount = Int32.Parse(Console.ReadLine());
                        atmgermania.Deposito(deposito, amount);
                    break;
                    case 2:
                        Console.WriteLine("Quanto desideri prelevare? ");
                        amount = Int32.Parse(Console.ReadLine());
                        atmgermania.Prelievo(prelievo, amount);
                    break;
                    case 3:
                        Console.WriteLine("Ecco il saldo ");
                        atmgermania.SaldoRimasto(saldo);
                    break;
                    case 4:
                        Console.WriteLine("Ecco i tuoi interessi ");
                        
                        atmgermania.InteressiMaturati(interesse);
                    break;

                }
            }
            

            
            

        }

        public static bool countrycheck(Country c, Country a)
        {
            if(c == a) return true;
            else return false;
        }
        


    }


    internal class Conto
    {
        int Saldo;
        int Interessi;
        public bool status;
        public Country country { get; set; }

        public void Deposito(int soldi)
        {
            Saldo += soldi;
        }

        public void Prelievo(int amount)
        {
            Saldo = Saldo-amount;
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

        public void check(ATMGermania atm) 
        {
            if (atm.countryATM != country)
            {
                status= false;
            }
            else
            {
                status=true;
            }
        }

    }

    internal class ATMGermania
    {
        public Country countryATM = Country.Germania;
        
        public void Deposito(DepositoAction deposito, int soldi)
        {
            deposito(soldi);
            Console.WriteLine("Deposito effettuato");
        }

        public void Prelievo(PrelievoAction prelievo, int am)
        {
            prelievo(am);
            Console.WriteLine("prelievo effettuato");
        }

        public void SaldoRimasto(SaldoAction saldo)
        {
            saldo();
            Console.WriteLine();
        }

        public void InteressiMaturati(InteresseAction interesse)
        {
            interesse();
            Console.WriteLine();
        }

        

    }
    

    public enum Country
    {
        Germania,
        Italia,
        Francia
    }
}
