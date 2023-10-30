using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace testUta.Sensori.Sensori_Analogici
{
   public class SensoreUmidita:SensoreAnalogico
    {
        public const string misuraSensore = " %";
        public const string produttore = "Belimo";
        public const string Modello = "22Dth-11M";
        public const double valoreMinimoDiMisurazione = 0;
        public const double valoreMassimoDiMisurazione = 100;
        public SensoreUmidita() : base(valoreMassimoDiMisurazione, valoreMassimoDiMisurazione, 200, Modello, produttore, misuraSensore, "sensore Umidità", 0)
        {
            Timer timer = new Timer(1000);
            timer.Enabled = true;
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            base.aggiornaMisurazione();
        }
    }
}
