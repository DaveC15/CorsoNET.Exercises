namespace Exercise.CovidUE
{
    public class Country
    {
        public string Name { get; set; }
        int positivi { get; set; }
        public event UpdatePositiviEventHandler UpdateCheck;
        public Country() 
        {
            
        }
        public int Positivi {
            get { return positivi; }
            set 
            {
                UpdatePositiviEventArgs Update = new(value);
                positivi = value;
                UpdateCheck(this, Update);
                
            } 
        }
        
    }
}
