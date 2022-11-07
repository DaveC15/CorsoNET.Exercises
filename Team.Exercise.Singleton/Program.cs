﻿using Microsoft.VisualBasic;

namespace Team.Exercise.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = Proxy.Getinstance();
            Utente u1 = new Utente("red", "red");
            Utente u2 = new Utente("re", "re");
            Utente u3 = new Utente("r", "r");

            Server s1 = new Server("server1");

            u1.ReturnIP(p, s1);
            u2.ReturnIP(p, s1);
            u3.ReturnIP(p, s1);
        }
    }
}