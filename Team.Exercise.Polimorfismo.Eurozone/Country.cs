namespace Team.Exercise.Polimorfismo.Eurozone
{
    public class Country : Territory
    {
        protected string _costituzione;
        protected string _bandiera;
        protected string _moneta;
        protected string _linguaUfficiale;
        protected float _pil;
        protected bool _penaMorte;
        protected string _nome;

        public Country(int popolazione, float areaGeografica, string continente, string costituzione, string bandiera, string moneta, string linguaufficiale, float pil, bool penamorte, string nome) : base(popolazione, areaGeografica, continente)
        {
            _popolazione = popolazione;
            _areaGeografica = areaGeografica;
            _continente = continente;
            _costituzione = costituzione;
            _bandiera = bandiera;
            _moneta = moneta;
            _linguaUfficiale = linguaufficiale;
            _pil = pil;
            _penaMorte = penamorte;
            _nome = nome;
        }
    }
}
