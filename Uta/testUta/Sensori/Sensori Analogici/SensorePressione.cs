using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace testUta.Sensori.Sensori_Analogici
{
    public class SensorePressione: SensoreAnalogico
    {
        public const string misuraSensore = " PA";
        public const string produttore = "Belimo";
        public const string Modello = "22DC-11";
        public const double valoreMinimoDiMisurazione = -100;
        public const double valoreMassimoDiMisurazione = 2500;
        public SensorePressione() : base(valoreMassimoDiMisurazione, valoreMassimoDiMisurazione, 200, Modello, produttore, misuraSensore, "sensore Pressione", 0)
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
