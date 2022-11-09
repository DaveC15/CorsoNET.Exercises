namespace Team.Exercise.Singleton
{
    public class Utente
    {
        private string _username;
        private string _password;
        private int _IP;
        private string _stato;

        public Utente(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public void ServerConnection(Proxy proxy, Server server)
        {
            _IP = proxy.IP();
            server.Access(this);
            _stato = "Connesso";
            Log.WriteonFile(this);
        }
        public void ServerDisconect(Server server)
        {  
            server.Diconect(this);
            _stato = "Disconnesso";
            Log.WriteonFile(this);
            _IP = 0;
        }

        public int IP { get { return _IP; } }
        public string Stato { get { return _stato;} }

    }
}
