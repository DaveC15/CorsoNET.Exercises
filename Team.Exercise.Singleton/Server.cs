using System;

namespace Team.Exercise.Singleton
{
    public class Server
    {
        private string _name;

        public Server(string name)
        {
            _name = name;
        }

        public void Access(Utente utente)
        {
            
            Console.WriteLine($"Ti sei connesso con questo IP: {utente.IP}");
            
        }
    }
}
