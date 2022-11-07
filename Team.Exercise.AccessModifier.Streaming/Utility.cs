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
                UserRegistration(Spotify);
            }
            else if (application == "M")
            {
                UserRegistration(AmazonMusic);
            }
            else
            {
                UserRegistration(AppleMusic);
            }
        }


        private static void UserRegistration(App app)
        {
            string registred;
            do
            {
                Console.WriteLine("If you are already registred press 'L' else press 'R'.  If you want to close the App press 'E'");
                registred = Console.ReadLine();
            } while (registred != "L" && registred != "R" && registred != "E");

            if (registred == "L")
            {
                app.LogIn();
                MusicSelecter(app);
            }
            else if (registred == "R")
            {
                app.Registration();
                UserRegistration(app);
            }
            else
            {
                Start();
            }
        }

        private static void MusicSelecter(App app)
        {
            string Select;
            do
            {
                app.Paste();
                //Console.WriteLine("Select the track: '1' for Peace of Mind, '2' for Smell like teen spirit, '3' for Runaway Train, '4' for Chlorine or press 'P' to play the current song. If you want to close the App press 'E'");
                Select = Console.ReadLine();
            } while (Select != "1" && Select != "2" && Select != "3" && Select != "4" && Select != "P" && Select != "E");

            if (Select == "1")
            {
                if (app.SetStreamingSong(0))
                {
                    app.Play();
                }
                else app.Play();

                MusicActionS(app);
            }
            else if (Select == "2")
            {
                if (app.SetStreamingSong(1))
                {
                    app.Play();
                }
                else app.Play();

                MusicActionS(app);
            }
            else if (Select == "3")
            {
                if (app.SetStreamingSong(2))
                {
                    app.Play();
                }
                else app.Play();

                MusicActionS(app);
            }
            else if (Select == "4")
            {
                if (app.SetStreamingSong(3))
                {
                    app.Play();
                }
                else app.Play();

                MusicActionS(app);
            }
            else if (Select == "P")
            {
                if (app.Play())
                {
                    MusicActionS(app);
                }
                else
                {
                    Console.WriteLine("No current song");
                    MusicSelecter(app);
                }
            }
            else
            {
                Start();
            }
        }

        private static void MusicActionS(App app)
        {
            string action;
            do
            {
                Console.WriteLine("Press 'S' to stop, 'P' to pause, 'F' to forward, 'B' to backward or 'R' to Rate the song. If you want to close the App press 'E'");
                action = Console.ReadLine();
            } while (action != "S" && action != "P" && action != "F" && action != "B" && action != "R" && action != "E");

            if (action == "S")
            {
                app.Stop();
                MusicSelecter(app);
            }
            else if (action == "P")
            {
                app.Pause();
                MusicSelecter(app);
            }
            else if (action == "F")
            {
                app.Forward();
                MusicActionS(app);
            }
            else if (action == "R")
            {
                app.Rate();
                MusicActionS(app);
            }
            else if (action == "B")
            {
                app.Backward();
                MusicActionS(app);
            }
            else
            {
                Start();
            }
        }

        
    }
}
