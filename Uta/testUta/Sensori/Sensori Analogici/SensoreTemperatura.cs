using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace testUta.Sensori.Sensori_Analogici
{
    public class SensoreTemperatura:SensoreAnalogico
    {
        public const string misuraSensore = " °C";
        public const string produttore = "Belimo";
        public const string Modello = "22DC-11";
        public const double valoreMinimoDiMisurazione = -20;
        public const double valoreMassimoDiMisurazione = 80;
        public SensoreTemperatura() : base(valoreMassimoDiMisurazione, valoreMassimoDiMisurazione, 200, Modello, produttore, misuraSensore, "sensore Temperatura", 0)
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
