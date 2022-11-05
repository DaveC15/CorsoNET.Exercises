using System;
using System.Collections.Generic;
using System.Timers;
using Team.Exercise.AccessModifier.Streaming.Interfaces;

namespace Team.Exercise.AccessModifier.Streaming
{
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

        public void AddSong(string songName, int songDuration)
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
        }

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

        public bool Play()
        {

            if (_streamingsong != null)
            {
                _streamingsong.Status = SongStatus.Play;
                Console.WriteLine(_streamingsong.Name);
                _streamingtimer.Start();
                startTimer();
                return true;
            }
            return false;
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
                if (_ratedsongs.ContainsKey(_streamingsong))
                {
                    if (_ratedsongs[_streamingsong] != 0)
                    {
                        _ratedsongs[_streamingsong] = (_streamingsong.Rate + newrate) / 2;
                        Console.WriteLine($"This song rate is {_ratedsongs[_streamingsong]}");
                    }
                    else
                    {
                        _ratedsongs[_streamingsong] = newrate;
                        Console.WriteLine($"This song rate is {_ratedsongs[_streamingsong]}");
                    }
                }
                else
                {
                    _ratedsongs.Add(_streamingsong, newrate);
                    Console.WriteLine($"This song rate is {_ratedsongs[_streamingsong]}");

                }

            }
        }
        public void Forward()
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
    public enum SongStatus
    {
        Play,
        Stop,
        Pause
    }
}
