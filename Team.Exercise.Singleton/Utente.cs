namespace Team.Exercise.Singleton
{
    public class Utente
    {
        private string _username;
        private string _password;
        private int _IP;

        public Utente(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public void ReturnIP(Proxy proxy, Server server)
        {
            _IP = proxy.IP();
            server.Access(this);
        }

        public int IP { get { return _IP; } }

    }
}
