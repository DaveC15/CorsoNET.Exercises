namespace Team.Exercise.Polimorfismo.Eurozone
{
    public abstract class Territory
    {
        protected int _popolazione;
        protected float _areaGeografica;
        public string _continente;

        public Territory(int popolazione, float areaGeografica, string continente)
        {
            _popolazione = popolazione;
            _areaGeografica = areaGeografica;
            _continente = continente;
        }
    }
}
