using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;


namespace testUta.Attuatori
{
    public class Motore : InterfaceAttuatori
    {
        public string nome { get; set; }
        public string descrizione { get; set; }
        public string costruttore { get; set; }
        public string marca { get; set; }
        public string modello { get; set; }
        public int attivato { get; set; }
        public int allarme { get; set; }
        public double posizioneAttuale { get; set; }
        public double velocitaRichiesta { get; set; }
        public double posizioneRichiesta { get; set; }
        public double velocitaAttuale { get; set; }
        public double velocitaMassima { get; set; }
        public double spostamentoMassimo { get; set; }
        public int fineCorsaMassimo { get; set; }
        public int fineCorsaMinimo { get; set; }
        public double tempoRotazione { get; set; }
        public double gradiMassimi { get; set; }
        public double tempoRotazioneMassimo { get; set; }
        public double tempoRotazioneRichiesto { get; set; }
        public double velocitaEffettiva { get; set; }
        public double tempo_s { get; set; }

        public Motore(string nome, string modello, string marca, string costruttore, string descrizione, double velocitaMassima, double spostamentoMassimo, double tempoDiRotazione, double gradiMassimoSpostamento, double tempoRotazioneMassimo) {
            this.nome = nome;
            this.modello = modello;
            this.marca = marca;
            this.descrizione = descrizione;
            this.costruttore = costruttore;
            this.velocitaAttuale = 0;
            this.posizioneAttuale = 0;
            this.attivato = 0;
            this.velocitaMassima = velocitaMassima;
            this.spostamentoMassimo = spostamentoMassimo;
            this.allarme = 0;
            this.fineCorsaMassimo = 0;
            this.fineCorsaMinimo = 1;
            //se ho una valvola è possibile che questa possa avere una configurazione per decidere in quanto tempo devo compiere una rotazione
            this.tempoRotazione = tempoDiRotazione;
            this.gradiMassimi = gradiMassimoSpostamento;
            this.tempoRotazioneMassimo = tempoRotazioneMassimo;//indica il numero massimo di secondi per effettuare una rotaziione
            this.tempo_s = 1;

        }

        public void AvvioMotore()
        {
            //per i motori che non hanno limiti di rotazione e per cui non mi interessa sapere il posizionamento finale vado a gestire solo 
            // la regolazione di velocita
            if (attivato == 1 && allarme == 0)
            {
                if (spostamentoMassimo == -1)
                {

                    double velocitaAttuale_Rad_Sec = CheckVelocita(this.velocitaAttuale);
                    double velocitaMassima_Rad_Sec = CheckVelocita(this.velocitaMassima);
                    double velocitaRichiesta_Rad_Sec = CheckVelocita(this.velocitaRichiesta);

                    //Gestione_Motore_Senza_Finecorsa(CheckVelocita(this.velocitaAttuale), CheckVelocita(this.velocitaMassima), CheckVelocita(velocitaRichiesta));
                    Gestione_Motore_Senza_Finecorsa(velocitaAttuale_Rad_Sec, velocitaMassima_Rad_Sec, velocitaRichiesta_Rad_Sec);
                }
                //se ho un motore di cui voglio controllare la posizione allora devo supporre la velocita sempre costante e la presenza di finecorsa
                else Gestione_Motore_Con_Finecorsa();
            }
        }
        private void Gestione_Motore_Senza_Finecorsa(double velocitaAttuale_Rad_Sec, double velocitaMassima_Rad_Sec, double velocitaRichiesta_Rad_Sec)
        {//converto le velocita in radianti al secondo
            double accelerazioneAngolare;
            if (velocitaRichiesta_Rad_Sec <= velocitaMassima_Rad_Sec)
            {

                accelerazioneAngolare = (velocitaMassima_Rad_Sec - 0) / tempo_s;

                double accelerazioneAngolare_rad_s = (accelerazioneAngolare * 2 * Math.PI) / 60;
                double x;
                if (velocitaRichiesta_Rad_Sec >= velocitaAttuale_Rad_Sec) {
                    x = (velocitaAttuale_Rad_Sec + (accelerazioneAngolare_rad_s * tempo_s));
                    if (x > velocitaRichiesta_Rad_Sec) { x = velocitaRichiesta_Rad_Sec; }
                }
                else { x = (velocitaAttuale_Rad_Sec - (accelerazioneAngolare_rad_s * tempo_s));
                    if (x < velocitaRichiesta_Rad_Sec) { x = velocitaRichiesta_Rad_Sec; }
                }


                double velocitaFinale_Rad_S;

                if (x >= 0 && x <= velocitaMassima_Rad_Sec) { velocitaFinale_Rad_S = x; }
                else if (x > velocitaMassima_Rad_Sec) { velocitaFinale_Rad_S = velocitaMassima_Rad_Sec; }
                else { velocitaFinale_Rad_S = 0; }
                //il controllore richiede la velocita in giri al minuto perciò li converto
                this.velocitaAttuale = (velocitaFinale_Rad_S * 60) / (2 * Math.PI);
                double perditaCarico = 0.07 * velocitaAttuale;
                velocitaEffettiva = velocitaAttuale - perditaCarico;
            }

        }
        private void Gestione_Motore_Con_Finecorsa() {
            double velocitaAttuale_Rad_Sec = (this.gradiMassimi / tempoRotazione) * (Math.PI / 180);
            double velocitaMassimae_Rad_Sec = (this.gradiMassimi / tempoRotazioneMassimo) * (Math.PI / 180);
            double velocitaRichiesta_Rad_Sec = (this.gradiMassimi / tempoRotazioneRichiesto) * (Math.PI / 180);
            if (fineCorsaMinimo == 1 && fineCorsaMassimo == 0)
            {//per effettuare a priori un check sulle velocita
                Gestione_Motore_Senza_Finecorsa(velocitaAttuale_Rad_Sec, velocitaMassimae_Rad_Sec, velocitaRichiesta_Rad_Sec);
                if (posizioneAttuale <= posizioneRichiesta && posizioneRichiesta+posizioneAttuale <= gradiMassimi) {
                    //double gradi_al_secondo = velocitaAttuale_Rad_Sec * (180 / Math.PI);
                   double gradi_al_secondo = gradiMassimi / tempoRotazione; 
                    posizioneAttuale += gradi_al_secondo;
                   

                }
                if (fineCorsaMinimo == 0 && fineCorsaMassimo == 1) {

                    Gestione_Motore_Senza_Finecorsa(velocitaAttuale_Rad_Sec, velocitaMassimae_Rad_Sec, velocitaRichiesta_Rad_Sec);
                    if (posizioneAttuale >= posizioneRichiesta && posizioneAttuale-posizioneRichiesta > 0)
                    {
                        double gradi_al_secondo = gradiMassimi / tempoRotazione;
                        //double gradi_al_secondo = velocitaAttuale_Rad_Sec * (180 / Math.PI);
                        posizioneAttuale -= gradi_al_secondo;
                        
                    }

                }
                if (posizioneAttuale >= gradiMassimi)
                {
                    posizioneAttuale = gradiMassimi;
                    fineCorsaMassimo = 1;
                    fineCorsaMinimo = 0;
                }
                else if (posizioneAttuale <= 0) {
                    posizioneAttuale = 0;
                    fineCorsaMassimo = 0;
                    fineCorsaMinimo = 1;
                }


            }
            
        }
        public double CheckVelocita(double velocitaDaControllare)
        {
            double risultato;
            double velocitaDaControllare_Rad_Min = (velocitaDaControllare * 2 * Math.PI);
            double velocitaDaControllare_Rad_Sec = velocitaDaControllare_Rad_Min / 60;
            double velocitaMassima_Rad_Min = (this.velocitaMassima * 2 * Math.PI);
            double velocitaMassima_Rad_Sec = velocitaMassima_Rad_Min / 60;
            if (velocitaDaControllare_Rad_Sec > 0 && velocitaDaControllare_Rad_Sec < velocitaMassima_Rad_Sec)
            {
                risultato = velocitaDaControllare_Rad_Sec;
            }
            else if (velocitaDaControllare_Rad_Sec <= 0) { risultato = 0; }
            else { risultato = velocitaMassima_Rad_Sec; }
            return risultato;
        }
    } 
}
