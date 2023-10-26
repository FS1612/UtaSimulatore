using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using testUta.Attuatori;

namespace testUta.Elementi_Meccanici
{
    public class Ventilatore
    {
       
        public double pressioneFinale { get; set; }
        public double pressioneIniziale { get; set; }
        public double velocitàAttuale { get; set; }
        double k = Costanti.ventola_FattoreK_adimensionale;
        double velocitaAria;
        Timer timer=new Timer(1000);
        Motore M;

        public Ventilatore(double pressioneIniziale, Motore motore, double velocitaAria )
        {this.velocitaAria = velocitaAria;  
            this.velocitàAttuale = 0;
            this.M = motore;
            this.pressioneFinale = pressioneIniziale;
            this.pressioneIniziale = pressioneIniziale;
            this.timer.Enabled = true;
            this.timer.Elapsed += Timer_Elapsed;
            this.velocitaAria = velocitaAria;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            
            Aggiorna(M.velocitaEffettiva);
        }

        public void Aggiorna(double velocita)
        {//in giri al secondo
         //pressioneFinale = k * Math.Pow(velocita/60, 2) ;

            //con equazione bernoulli P1 + 0.5 * ρ * V1^2*h2+ρ*g = P2 + 0.5 * ρ * V2^2*h2+ρ* g con h1=h2 perchè il condotto è orizzontale e quindi l'altezza non varia 
            //P2= P1 + 0.5 * ρ * V1^2-0.5 * ρ * V2^2
            double rho = 1.2;
            if( velocita > 0 ) { pressioneFinale = pressioneIniziale + 0.5 * rho * (Math.Pow( velocita,2) - Math.Pow(velocitaAria,2)); }
            

        }
    }
}
