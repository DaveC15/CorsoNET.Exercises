using System;

namespace Exercise.eventBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommercialBank cm = new CommercialBank();
            CryptoBank cr = new CryptoBank();
            cm.ceoCheck += new CEOEventHandler(CEOChange);
            cr.ceoCheck += new CEOEventHandler(CEOChange);
            cm.CEO = "Davide";
            cr.CEO = "Mario";

        }

        public static void CEOChange(object source, CEOEventArgs e)
        {
            Console.WriteLine($"Ciao {source.GetType()} il nuovo ceo è {e.newceo}");
        }
    }

    

}
