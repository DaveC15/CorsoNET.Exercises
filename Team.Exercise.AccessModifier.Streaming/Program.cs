namespace Team.Exercise.AccessModifier.Streaming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            App Spotify = new App("Spotify");
            User Dave = new User("dave6", "hahshdh");
            Spotify.Play();
        }
    }
}
