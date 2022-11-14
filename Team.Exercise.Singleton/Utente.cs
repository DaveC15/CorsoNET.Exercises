using System.Diagnostics;
using System.Linq;

namespace Team.Exercise.Singleton
{
    public class Utente
    {
        private string _username;
        private string _password;
        private int _IP;
        private string _stato = "Disconnesso";
        private const string _msgin = "Entrato in ";
        private const string _msgout = "Uscito da ";
        private string _metodo;
        

        public Utente(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public void ServerConnection(Proxy proxy, Server server)
        {
            StackFrame stackFrame = new StackFrame();
            _metodo = stackFrame.GetMethod().Name.ToString();
            Log.WriteonFile(_msgin, _metodo, this);
            _IP = proxy.IP();
            server.Access(this);
            _stato = "Connesso";
            _metodo = stackFrame.GetMethod().Name.ToString();
            Log.WriteonFile(_msgout, _metodo,this);
        }
        public void ServerDisconect(Server server)
        {
            StackFrame stackFrame1 = new StackFrame();
            _metodo = stackFrame1.GetMethod().Name.ToString();
            Log.WriteonFile(_msgin, _metodo, this);
            server.Diconect(this);
            _stato = "Disconnesso";
            _IP = 0;
            _metodo = stackFrame1.GetMethod().Name.ToString();
            Log.WriteonFile(_msgout,_metodo, this);
        }

        public int IP { get { return _IP; } }
        public string Stato { get { return _stato;} }
        public string Username { get { return _username; } }

    }
}
