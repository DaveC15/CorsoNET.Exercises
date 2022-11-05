using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Team.Exercise.AccessModifier.Streaming
{
    public class App : StreamingPlatform
    {
        private List<User> appUsers;
        private User appLogUser;
        public App(string appName) : base(appName)
        {
            appUsers = new List<User>();
            Song a = new Song("Peace of Mind", 2);
            Song b = new Song("Smell Like Teen Spirit", 2);
            Song c = new Song("Runaway Train", 2);
            Song d = new Song("Chlorin", 2);
            _apptracks.Add(a);
            _apptracks.Add(b);
            _apptracks.Add(c);
            _apptracks.Add(d);
        }

        public bool SetStreamingSong(int index)
        {
            if (_streamingsong != _apptracks[index])
            {
                _streamingsong = _apptracks[index];
                return true;
            }
            else return false;
        }
        protected sealed override bool AccessVerified(User user_login)
        {
            for (int i = 0; i < appUsers.Capacity; i++)
            {
                if (user_login.Username == appUsers[i].Username && user_login.Password == appUsers[i].Password)
                {
                    return true;
                }
            }

            return false;
        }


        public bool Registration()
        {
            Console.WriteLine("Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            User user_registration = new User(username, password);
            if (appUsers.IndexOf(user_registration) == -1)
            {
                appUsers.Add(user_registration);
                return true;
            }
            else
            {
                Console.WriteLine("User already added");
                return false;
            }

        }
        public void LogIn()
        {
            Console.WriteLine("Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            User user_login = new User(username, password);

            if (AccessVerified(user_login))
            {
                appLogUser = user_login;
                Console.WriteLine("You are Logged In");

            }
            else
            {
                Console.WriteLine("User not found please register");
                Registration();

            }
        }
    }
}
