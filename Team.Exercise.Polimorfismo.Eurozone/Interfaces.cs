using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team.Exercise.Polimorfismo.Eurozone
{
    public interface UnioneEuropea
    {
        public void monetaUnica();
        public void costituzioneEuro();
        public void EMA();

        public bool checkEuroZona();
    }

    public interface ONU
    {
        public void OMS();
        public void FMI();
    }

    public interface CorteEuropea
    {
        public void penaMorte();
    }

    public interface EuroCntralBank
    {
        public void calculateSpread();
    }
}
