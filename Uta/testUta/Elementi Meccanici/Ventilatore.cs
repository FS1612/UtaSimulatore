using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUta.Elementi_Meccanici
{
    public class Ventilatore
    {
       
        double pressioneFinale;
        double velocitàAttuale;
        double k = Costanti.ventola_FattoreK_adimensionale;
        double tempoSimulazione;

        public Ventilatore(double pressioneIniziale,double tempo) {
            this.velocitàAttuale = 0;
            
            this.pressioneFinale = pressioneIniziale;
            this.tempoSimulazione = tempo;
        }
        public void Aggiorna(double velocita)
        {//in giri al secondo
            this.pressioneFinale += k * Math.Pow(velocita, 2) * tempoSimulazione;

        }
    }
}
