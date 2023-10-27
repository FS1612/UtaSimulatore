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
        double sezioneTtasversale;
        Timer timer=new Timer(1000);
        Motore M;
        double flusso_m3_h;
        //double velocita;
        public Ventilatore(double pressioneIniziale, Motore motore, double velocitaAria, double sezione)
        {this.velocitaAria = velocitaAria;  
            this.velocitàAttuale = 0;
            this.M = motore;
            this.pressioneFinale = pressioneIniziale;
            this.pressioneIniziale = pressioneIniziale;
            this.timer.Enabled = true;
            this.timer.Elapsed += Timer_Elapsed;
            //this.velocitaAria = velocitaAria;
            this.sezioneTtasversale = sezione;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            
            Aggiorna(M.velocitaEffettiva);
        }

        public void Aggiorna(double velocita)
        {//in giri al secondo
         //pressioneFinale = k * Math.Pow(velocita/60, 2) ;
            velocitàAttuale = velocita;
            //con equazione bernoulli P1 + 0.5 * ρ * V1^2*h2+ρ*g = P2 + 0.5 * ρ * V2^2*h2+ρ* g con h1=h2 perchè il condotto è orizzontale e quindi l'altezza non varia 
            //P2= P1 + 0.5 * ρ * V1^2-0.5 * ρ * V2^2
            double rho = 1.2;
            if( velocita > 0 ) {
                double flusso_m3_s = (Math.PI / 4) * Math.Pow(0.29, 2) * (velocita / 60);
                this.flusso_m3_h = flusso_m3_s * 3600;
                this.velocitaAria = flusso_m3_s / sezioneTtasversale;
            //pressioneFinale = pressioneIniziale + 0.5 * rho * (Math.Pow( velocita,2) - Math.Pow(this.velocitaAria, 2)); 
                pressioneFinale = velocita*Costanti.ventolaMandata_EfficienzaPressione; }
            ////Il flusso d'aria generato da una ventola varia direttamente in base alla velocità della ventola. 
            ////Il legame tra la velocità della ventola (in giri al minuto o RPM) e il flusso d'aria può essere descritto da una relazione approssimata: flusso=k*rpm
            ////esprimo k in m^3/s
            //double k_m3_s = k / 3600;
            ////Flusso d'aria (in metri cubi per secondo, m³/s) = K (m³/s) * RPM / 60
            //double flusso_m3_s = k_m3_s * (velocita / 60);
            // this.flusso_m3_h = flusso_m3_s*3600;
            ////calcolo la velocita dell'aria in[m/s]
            //this.velocita = flusso_m3_s / sezioneTtasversale ;
            //double pressioneDinamica=0.5*rho+Math.Pow(this.velocita, 2);
            
            
        }
    }
}
