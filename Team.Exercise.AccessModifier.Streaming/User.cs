namespace Team.Exercise.AccessModifier.Streaming
{
    public class User
    {
        private string _userusername;
        private string _userpassword;



        public string Username { get { return _userusername; } set { _userusername = value; } }
        public string Password { get { return _userpassword; } set { _userpassword = value; } }

        public User(string userusername, string userpassword)
        {
            this._userusername = userusername;
            this._userpassword = userpassword;
        }
    }
}
