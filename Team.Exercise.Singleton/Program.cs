using Microsoft.VisualBasic;
using System;

namespace Team.Exercise.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var log = Log.Instance(@"C:\LOG", "TeamExerciseSingleton.txt");
            var p = Proxy.Getinstance();
            Utente u1 = new Utente("Davide", "red");
            Utente u2 = new Utente("Filippo", "re");
            Utente u3 = new Utente("Rodolfo", "r");
            Utente u4 = new Utente("Marco", "red");
            Utente u5 = new Utente("Paola", "re");
            Utente u6 = new Utente("Mirco", "r");
            Utente u7 = new Utente("Elias", "red");
            Utente u8 = new Utente("Nicole", "re");
            Utente u9 = new Utente("Giorgio", "r");
            Utente u0 = new Utente("Umberto", "r");

            Server s1 = new Server("server1");

            u1.ServerConnection(p, s1);
            u2.ServerConnection(p, s1);
            u3.ServerConnection(p, s1);
            u4.ServerConnection(p, s1);
            u5.ServerConnection(p, s1);
            u6.ServerConnection(p, s1);
            u7.ServerConnection(p, s1);
            u8.ServerConnection(p, s1);
            u9.ServerConnection(p, s1);
            u0.ServerConnection(p, s1);

            u1.ServerDisconect(s1);
        }
    }
}
