using System;

namespace Exercise.eventBank
{
    delegate void CEOEventHandler(object source, CEOEventArgs e);
    public class CEOEventArgs : EventArgs
    {
        public string newceo;
        public bool cancel;

        public CEOEventArgs(string ceo)
        {
            this.newceo = ceo;
        }
    }
}
