using System;

namespace Exercise.eventBank
{
    abstract class CentralBank
    {
        public event CEOEventHandler ceoCheck;

        string ceo;
        public string CEO { 
            get { return ceo; }
            set 
            { 
                if(value != CEO)
                {
                    if (value != null)
                    {
                        CEOEventArgs ceoEvent = new CEOEventArgs(value);
                        ceoCheck(this, ceoEvent);
                    }
                }
                 
            }
        }
    }
}
