using System;

namespace Exercise.CovidUE
{
    public delegate void UpdatePositiviEventHandler(object source, UpdatePositiviEventArgs e);
    public class UpdatePositiviEventArgs : EventArgs
    {
        public int newpositivitot;

        public UpdatePositiviEventArgs(int positivi)
        {
            newpositivitot = positivi;
            
        }
    }
}
