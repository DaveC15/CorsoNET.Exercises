using System;
using System.Collections.Generic;
using System.Timers;

namespace Team.Exercise.AccessModifier.Streaming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            App Spotify = new App("Spotify");
            User Dave = new User("dave6", "hahshdh");
        }
    }

    public abstract class StreamingPlatform : Player
    {
        protected string _appName;
        protected List<Song> _apptracks;
        protected Song _streamingsong;
        protected Dictionary<Song, int> _ratedsongs;

        protected Timer _streamingtimer;
        private int _elapsedSeconds;
        protected abstract bool AccessVerified(User user_login);
        public StreamingPlatform(string appName)
        {
            _appName = appName;
            _apptracks = new List<Song>();
            _ratedsongs = new Dictionary<Song, int>();
            _streamingtimer = new Timer(1000);
            _elapsedSeconds = 0;
        }

        /*public void AddSong(string songName, int songDuration)
        {
            Song newSong = new Song(songName, songDuration);

            if (_apptracks.IndexOf(newSong) != -1)
                _apptracks.Add(newSong);
        }

        public void RemoveSong(string songName, int songDuration)
        {
            Song newSong = new Song(songName, songDuration);

            if (_apptracks.IndexOf(newSong) != -1)
                _apptracks.Remove(newSong);
        }*/

        protected class Song
        {
            private string _songname;
            private int _songrate;
            private SongStatus _songstatus;
            private int _songduration;
            private int _songactualtime;

            public Song(string songname, int songduration)
            {
                _songname = songname;
                _songduration = songduration;
                _songstatus = SongStatus.Stop;
                _songactualtime = 0;
            }

            public string Name { get { return _songname; } set { _songname = value; } }
            public int Rate { get { return _songrate; } set { _songrate = value; } }
            public SongStatus Status { get { return _songstatus; } set { _songstatus = value; } }
            public int Duration { get { return _songduration; } set { _songduration = value; } }
            public int ActualTime { get { return _songactualtime; } set { _songactualtime = value; } }
        }

        internal void startTimer()
        {
            _elapsedSeconds++;
            _streamingsong.ActualTime = _elapsedSeconds;
        }

        internal void stopTimer()
        {
            _elapsedSeconds = 0;
        }

        public void Play()
        {
            if (_streamingsong != null)
            {
                _streamingsong.Status = SongStatus.Play;

                _streamingtimer.Start();
                startTimer();
            }
        }

        public void Stop()
        {
            if (_streamingsong != null)
            {
                _streamingsong.Status = SongStatus.Stop;
                _streamingsong.ActualTime = 0;

                _streamingtimer.Stop();
                stopTimer();
            }
        }
        public void Pause()
        {
            if (_streamingsong != null)
            {
                _streamingsong.Status = SongStatus.Pause;

                _streamingsong.ActualTime = _elapsedSeconds;
                _streamingtimer.Stop();
            }
        }

        public void Rate()
        {
            if (_streamingsong != null)
            {
                int newrate = 0;
                bool catchvalue = false;
                while (catchvalue == false)
                {
                    Console.Clear();
                    Console.WriteLine("Vote this Song (1/5): ");
                    catchvalue = Int32.TryParse(Console.ReadLine(), out newrate);
                }

                if (_ratedsongs[_streamingsong] != 0)
                {
                    _ratedsongs[_streamingsong] = (_streamingsong.Rate + newrate) / 2;
                }
                else _ratedsongs.Add(_streamingsong, newrate);
            }
        }
        public void Foreward()
        {
            if (_streamingsong != null)
            {
                int index = _apptracks.IndexOf(_streamingsong);
                _streamingsong.ActualTime = 0;

                if (index >= _apptracks.Count - 1)
                {
                    _streamingsong = _apptracks[0];
                }
                else _streamingsong = _apptracks[index + 1];

                if (_streamingsong.Status != SongStatus.Play)
                {
                    _streamingsong.Status = SongStatus.Play;
                }

                stopTimer();
                startTimer();
            }
        }

        public void Backward()
        {
            if (_streamingsong != null)
            {
                int index = _apptracks.IndexOf(_streamingsong);

                if (_streamingsong.ActualTime == 0)
                {
                    _streamingsong.ActualTime = 0;

                    if (index <= 0)
                    {
                        _streamingsong = _apptracks[_apptracks.Count - 1];
                    }
                    else _streamingsong = _apptracks[index - 1];

                    if (_streamingsong.Status != SongStatus.Play)
                    {
                        _streamingsong.Status = SongStatus.Play;
                    }
                }

                stopTimer();
                startTimer();

            }
        }
    }

    public class App : StreamingPlatform
    {
        private List<User> appUsers;
        private User appLogUser;
        public App(string appName) :base(appName)
        {
            appUsers = new List<User>();
            Song a = new Song("a", 1);
            Song b = new Song("b", 2);
            Song c = new Song("c", 3);
            Song d = new Song("d", 4);
            Song e = new Song("e", 1);
            _apptracks.Add(a);
            _apptracks.Add(b);
            _apptracks.Add(c);
            _apptracks.Add(d);
            _apptracks.Add(e);
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
        interface Player
    {
        void Play();
        void Stop();
        void Pause();
        void Rate();
        void Foreward();
        void Backward();
    }

    public enum SongStatus
    {
        Play,
        Stop,
        Pause
    }
}
