namespace Team.Exercise.AccessModifier.Streaming.Interfaces
{
    interface Player
    {
        bool Play();
        void Stop();
        void Pause();
        void Rate();
        void Forward();
        void Backward();
    }
}
