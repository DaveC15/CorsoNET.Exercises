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
            Utente u1 = new Utente("red", "red");
            Utente u2 = new Utente("re", "re");
            Utente u3 = new Utente("r", "r");

            Server s1 = new Server("server1");

            u1.ServerConnection(p, s1);
            u2.ServerConnection(p, s1);
            u3.ServerConnection(p, s1);

            u1.ServerDisconect(s1);
        }
    }
}
