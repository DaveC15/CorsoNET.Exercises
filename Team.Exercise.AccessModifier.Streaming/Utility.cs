using System;
using System.Runtime.CompilerServices;

namespace Team.Exercise.AccessModifier.Streaming
{
    internal static class Utility
    {
        public static void Start()
        {
            App Spotify = new App("Spotify");
            App AmazonMusic = new App("Amazon Music");
            App AppleMusic = new App("Apple Music");
            AppSelecter(Spotify, AmazonMusic, AppleMusic);
            //Exit(Spotify, AmazonMusic, AppleMusic);
        }

        private static void AppSelecter(App Spotify, App AmazonMusic, App AppleMusic)
        {
            string application;
            do
            {
                Console.WriteLine("Select an application to stream music:  press 'S' for Spotify,  'M' for Amazon Music  or  'A' for Apple Music");
                application = Console.ReadLine();
            } while ((application != "S") && (application != "M") && (application != "A"));

            if (application == "S")
            {
                UserRegistrationS(Spotify);
            }
            else if (application == "M")
            {
                UserRegistrationM(AmazonMusic);
            }
            else
            {
                UserRegistrationA(AppleMusic);
            }
        }


        private static void UserRegistrationS(App Spotify)
        {
            string registred;
            do
            {
                Console.WriteLine("If you are already registred press 'L' else press 'R'.  If you want to close the App press 'E'");
                registred = Console.ReadLine();
            } while (registred != "L" && registred != "R" && registred != "E");

            if (registred == "L")
            {
                Spotify.LogIn();
                MusicSelecterS(Spotify);
            }
            else if (registred == "R")
            {
                Spotify.Registration();
                UserRegistrationS(Spotify);
            }
            else
            {
                Start();
            }
        }

        private static void MusicSelecterS(App Spotify)
        {
            string Select;
            do
            {
                Console.WriteLine("Select the track: '1' for Peace of Mind, '2' for Smell like teen spirit, '3' for Runaway Train, '4' for Chlorine or press 'P' to play the current song. If you want to close the App press 'E'");
                Select = Console.ReadLine();
            } while (Select != "1" && Select != "2" && Select != "3" && Select != "4" && Select != "P" && Select != "E");

            if (Select == "1")
            {
                if (Spotify.SetStreamingSong(0))
                {
                    Spotify.Play();
                }
                else Spotify.Play();

                MusicActionS(Spotify);
            }
            else if (Select == "2")
            {
                if (Spotify.SetStreamingSong(1))
                {
                    Spotify.Play();
                }
                else Spotify.Play();

                MusicActionS(Spotify);
            }
            else if (Select == "3")
            {
                if (Spotify.SetStreamingSong(2))
                {
                    Spotify.Play();
                }
                else Spotify.Play();

                MusicActionS(Spotify);
            }
            else if (Select == "4")
            {
                if (Spotify.SetStreamingSong(3))
                {
                    Spotify.Play();
                }
                else Spotify.Play();

                MusicActionS(Spotify);
            }
            else if (Select == "P")
            {
                if (Spotify.Play())
                {
                    MusicActionS(Spotify);
                }
                else
                {
                    Console.WriteLine("No current song");
                    MusicSelecterS(Spotify);
                }
            }
            else
            {
                Start();
            }
        }

        private static void MusicActionS(App Spotify)
        {
            string action;
            do
            {
                Console.WriteLine("Press 'S' to stop, 'P' to pause, 'F' to forward, 'B' to backward or 'R' to Rate the song. If you want to close the App press 'E'");
                action = Console.ReadLine();
            } while (action != "S" && action != "P" && action != "F" && action != "B" && action != "R" && action != "E");

            if (action == "S")
            {
                Spotify.Stop();
                MusicSelecterS(Spotify);
            }
            else if (action == "P")
            {
                Spotify.Pause();
                MusicSelecterS(Spotify);
            }
            else if (action == "F")
            {
                Spotify.Forward();
                MusicActionS(Spotify);
            }
            else if (action == "R")
            {
                Spotify.Rate();
                MusicActionS(Spotify);
            }
            else if (action == "B")
            {
                Spotify.Backward();
                MusicActionS(Spotify);
            }
            else
            {
                Start();
            }
        }

        public static void UserRegistrationM(App AmazonMusic)
        {
            string registred;
            do
            {
                Console.WriteLine("If you are already registred press 'L' else press 'R'. If you want to close the App press 'E'");
                registred = Console.ReadLine();
            } while (registred != "L" && registred != "R" && registred != "E");

            if (registred == "L")
            {
                AmazonMusic.LogIn();
                MusicSelecterS(AmazonMusic);
            }
            else if (registred == "R")
            {
                AmazonMusic.Registration();
                UserRegistrationS(AmazonMusic);
            }
            else
            {
                Start();
            }
        }

        public static void MusicSelecterM(App AmazonMusic)
        {
            string Select;
            do
            {
                Console.WriteLine("Select the track: '1' for Smell like teen spirit, '2' for Runaway Train,'3' for Chlorine or press 'P' to play the first Peace of Mind. If you want to close the App press 'E'");
                Select = Console.ReadLine();
            } while (Select != "1" && Select != "2" && Select != "3" && Select != "P" && Select != "E");

            if (Select == "1")
            {
                if (AmazonMusic.SetStreamingSong(1))
                {
                    AmazonMusic.Play();
                }
                else AmazonMusic.Play();

                MusicActionS(AmazonMusic);
            }
            else if (Select == "2")
            {
                if (AmazonMusic.SetStreamingSong(2))
                {
                    AmazonMusic.Play();
                }
                else AmazonMusic.Play();

                MusicActionS(AmazonMusic);
            }
            else if (Select == "3")
            {
                if (AmazonMusic.SetStreamingSong(3))
                {
                    AmazonMusic.Play();
                }
                else AmazonMusic.Play();

                MusicActionS(AmazonMusic);
            }
            else if (Select == "P")
            {
                AmazonMusic.Play();
                MusicActionS(AmazonMusic);
            }
            else
            {
                Start();
            }
        }

        public static void MusicActionM(App AmazonMusic)
        {
            string action;
            do
            {
                Console.WriteLine("Press 'S' to stop, 'P' to pause, 'F' to forward, 'B' to backward or 'R' to Rate the song. If you want to close the App press 'E'");
                action = Console.ReadLine();
            } while (action != "S" && action != "P" && action != "F" && action != "B" && action != "R" && action != "E");

            if (action == "S")
            {
                AmazonMusic.Stop();
                MusicSelecterS(AmazonMusic);
            }
            else if (action == "P")
            {
                AmazonMusic.Pause();
                MusicSelecterS(AmazonMusic);
            }
            else if (action == "F")
            {
                AmazonMusic.Forward();
                MusicActionS(AmazonMusic);
            }
            else if (action == "R")
            {
                AmazonMusic.Rate();
                MusicActionS(AmazonMusic);
            }
            else if (action == "B")
            {
                AmazonMusic.Backward();
                MusicActionS(AmazonMusic);
            }
            else
            {
                Start();
            }
        }

        public static void UserRegistrationA(App AppleMusic)
        {
            string registred;
            do
            {
                Console.WriteLine("If you are already registred press 'L' else press 'R'. If you want to close the App press 'E'");
                registred = Console.ReadLine();
            } while (registred != "L" && registred != "R" && registred != "E");

            if (registred == "L")
            {
                AppleMusic.LogIn();
                MusicSelecterS(AppleMusic);
            }
            else if (registred == "R")
            {
                AppleMusic.Registration();
                UserRegistrationS(AppleMusic);
            }
            else
            {
                Start();
            }
        }

        public static void MusicSelecterA(App AppleMusic)
        {
            string Select;
            do
            {
                Console.WriteLine("Select the track: '1' for Smell like teen spirit, '2' for Runaway Train,'3' for Chlorine or press 'P' to play the first Peace of Mind. If you want to close the App press 'E'");
                Select = Console.ReadLine();
            } while (Select != "1" && Select != "2" && Select != "3" && Select != "P" && Select != "E");

            if (Select == "1")
            {
                if (AppleMusic.SetStreamingSong(1))
                {
                    AppleMusic.Play();
                }
                else AppleMusic.Play();

                MusicActionS(AppleMusic);
            }
            else if (Select == "2")
            {
                if (AppleMusic.SetStreamingSong(2))
                {
                    AppleMusic.Play();
                }
                else AppleMusic.Play();

                MusicActionS(AppleMusic);
            }
            else if (Select == "3")
            {
                if (AppleMusic.SetStreamingSong(3))
                {
                    AppleMusic.Play();
                }
                else AppleMusic.Play();

                MusicActionS(AppleMusic);
            }
            else if (Select == "P")
            {
                AppleMusic.Play();
                MusicActionS(AppleMusic);
            }
            else
            {
                Start();
            }
        }

        public static void MusicActionA(App AppleMusic)
        {
            string action;
            do
            {
                Console.WriteLine("Press 'S' to stop, 'P' to pause, 'F' to forward, 'B' to backward or 'R' to Rate the song. If you want to close the App press 'E'");
                action = Console.ReadLine();
            } while (action != "S" && action != "P" && action != "F" && action != "B" && action != "R" && action != "E");

            if (action == "S")
            {
                AppleMusic.Stop();
                MusicSelecterS(AppleMusic);
            }
            else if (action == "P")
            {
                AppleMusic.Pause();
                MusicSelecterS(AppleMusic);
            }
            else if (action == "F")
            {
                AppleMusic.Forward();
                MusicActionS(AppleMusic);
            }
            else if (action == "R")
            {
                AppleMusic.Rate();
                MusicActionS(AppleMusic);
            }
            else if (action == "B")
            {
                AppleMusic.Backward();
                MusicActionS(AppleMusic);
            }
            else
            {
                Start();
            }
        }
    }
}
