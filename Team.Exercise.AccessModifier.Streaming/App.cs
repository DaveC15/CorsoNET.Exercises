using System;
using System.Collections.Generic;

namespace Team.Exercise.AccessModifier.Streaming
{
    public class App : StreamingPlatform
    {
        private List<User> appUsers;
        private User appLogUser;
        public App(string appName) :base(appName)
        {
            appUsers = new List<User>();
            Song a = new Song("a",2);
            Song b = new Song("b", 2);
            _apptracks.Add(a);
            _apptracks.Add(b);
        }

        protected sealed override bool AccessVerified(User user_login)
        {
            if (appUsers.IndexOf(user_login) != -1)
            {
                return false;
            }
            else return true;
        }

        public bool LogIn()
        {
            Console.WriteLine("Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            User user_login = new User(username, password);

            if (AccessVerified(user_login))
            {
                appLogUser = user_login;
                return true;
            }
            else
            {
                Console.ReadKey();
                Console.Clear();
                return false;
            }
        }
    }
}
