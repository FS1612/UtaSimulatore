using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using System.Threading.Tasks;
using System.Timers;

namespace testUta
{
    public  class Valvola
    {Timer timer =new Timer();
        //double coefficiente_Flusso = Costanti.valvola_Ccoefficiente_Flusso;
        //double differenza_Pressione_BatteriaFredda_Freddo = Costanti.valvola_Differenza_Pressione_BatteriaFredda_Freddo;
        //double differenza_Pressione_BatteriaFredda_Caldo = Costanti.valvola_Differenza_Pressione_BatteriaFredda_Caldo;
        //double differenza_Pressione_BatteriaCalda_Caldo = Costanti.valvola_Differenza_Pressione_BatteriaFredda_Caldo;
        //double differenza_Pressione_BatteriaCalda_Freddo = Costanti.valvola_Differenza_Pressione_BatteriaFredda_Caldo;
        //double batteriaFredda_diametroValvola = Costanti.batteriaFredda_diametroValvola;
        //double batteriaCalda_diametroValvola = Costanti.batteriaCalda_diametroValvola;
        //double batteriaCalda_velocitaAcquaFreddo = Costanti.batteriaCalda_velocitaMassimaAcqua_Freddo;
        //double batteriaCalda_velocitaAcquaCaldo = Costanti.batteriaCalda_velocitaMassimoAcqua_Caldo;
        //double batteriaFredda_velocitaAcquaFreddo = Costanti.batteriaFredda_velocitaMassimaAcqua_Freddo;
        //double batteriaFredda_velocitaAcquaCaldo = Costanti.batteriaFredda_velocitaMassimaAcqua_Caldo;
        //double batteriaUmidificatrice_velocitaAcqua = Costanti.batteriaFredda_Umidificatrice_velocitaMassimaAcqua;
        //double batteriaUmidificatrice_diametroValvola = Costanti.batteriaFredda_Umidificatrice_diametroValvola;
        double percentuale_Apertura;
        double tempoSimulazione;
        double flussoAttuale;
        double diametro;
        double velocitaAcqua;
        double temperaturaAcqua;
        //string tipoBatteria;
        //string stagione;
        string funzione;
        double diametro_Metri;
        double raggio;
        double Area_Sezione_Trasversale_Totale;
        double Area_Sezione_Trasversale_Attuale;
        public Valvola(double apertura,double tempoSimulazione,/* string tipoBatteria,string stagione,*/ double velocitaAcqua,double temperaturaAcqua,double diametro)
        {this.tempoSimulazione=tempoSimulazione*1000;
            this.velocitaAcqua = velocitaAcqua;
            this.temperaturaAcqua = temperaturaAcqua;
            this.diametro = diametro;   
            //this.funzione = tipoBatteria + ":" + stagione;
            /*this.stagione = stagione;*/
            this.percentuale_Apertura = apertura;
            this.timer.Interval = tempoSimulazione*1000;
            this.timer.Enabled = true;
            this.timer.Elapsed += Timer_Elapsed;
            //this.tipoBatteria = tipoBatteria;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            aggiorna();
        }
        public void aggiorna()
        {
            //double diametro_Metri;
            //double raggio;
            //double Area_Sezione_Trasversale_Totale;
            //double Area_Sezione_Trasversale_Attuale;
            //calcolo il flusso attuale usando la seguente formula=> Q=apertura_Valvola*coefficiente_Flusso*DeltaPressione
            //flussoAttuale = coefficiente_Flusso * percentuale_Apertura * deltapressione;
            //calcolo il flusso attuale usando la seguente formula=> Q=Area_Sezione_Trasversale*Velocità_Acqua(nella valvola)
            //l'area della sezione trasversale dipende dal diametro della valvola in questo modo =>A=pi*(Diametro/2)^2
            //switch (funzione)
            //{
            //    case Costanti.batteriaCalda + ":" + Costanti.stagioneCalda when percentuale_Apertura > 0:
            //         diametro_Metri = batteriaCalda_diametroValvola / 1000;
            //        raggio = diametro_Metri / 2;
            //        Area_Sezione_Trasversale_Totale = Math.PI * Math.Pow(raggio, 2);
            //        Area_Sezione_Trasversale_Attuale = percentuale_Apertura * Area_Sezione_Trasversale_Totale;
            //        this.flussoAttuale = Area_Sezione_Trasversale_Attuale * batteriaCalda_velocitaAcquaCaldo;
            //        break;
            //    case Costanti.batteriaCalda + ":" + Costanti.stagioneFredda when percentuale_Apertura > 0:
            //         diametro_Metri = batteriaCalda_diametroValvola / 1000;
            //        raggio = diametro_Metri / 2;
            //        Area_Sezione_Trasversale_Totale = Math.PI * Math.Pow(raggio, 2);
            //        Area_Sezione_Trasversale_Attuale = percentuale_Apertura * Area_Sezione_Trasversale_Totale;
            //        this.flussoAttuale = Area_Sezione_Trasversale_Attuale * batteriaCalda_velocitaAcquaFreddo;
            //        break;
            //    case Costanti.batteriaFredda + ":" + Costanti.stagioneCalda when percentuale_Apertura > 0:
            //        diametro_Metri = batteriaFredda_diametroValvola / 1000;
            //        raggio = diametro_Metri / 2;
            //        Area_Sezione_Trasversale_Totale = Math.PI * Math.Pow(raggio, 2);
            //        Area_Sezione_Trasversale_Attuale = percentuale_Apertura * Area_Sezione_Trasversale_Totale;
            //        this.flussoAttuale = Area_Sezione_Trasversale_Attuale * batteriaFredda_velocitaAcquaCaldo;
            //        break;
            //    case Costanti.batteriaFredda + ":" + Costanti.stagioneFredda when percentuale_Apertura > 0:
            //        diametro_Metri = batteriaFredda_diametroValvola / 1000;
            //        raggio = diametro_Metri / 2;
            //        Area_Sezione_Trasversale_Totale = Math.PI * Math.Pow(raggio, 2);
            //        Area_Sezione_Trasversale_Attuale = percentuale_Apertura * Area_Sezione_Trasversale_Totale;
            //        this.flussoAttuale = Area_Sezione_Trasversale_Attuale * batteriaFredda_velocitaAcquaFreddo;
            //        break;
            //    case Costanti.batteriaFreddaUmidificatrice when percentuale_Apertura > 0:
            //        diametro_Metri = batteriaFredda_diametroValvola / 1000;
            //        raggio = diametro_Metri / 2;
            //        Area_Sezione_Trasversale_Totale = Math.PI * Math.Pow(raggio, 2);
            //        Area_Sezione_Trasversale_Attuale = percentuale_Apertura * Area_Sezione_Trasversale_Totale;
            //        this.flussoAttuale = Area_Sezione_Trasversale_Attuale * batteriaUmidificatrice_velocitaAcqua;
            //        break;
            //    default:
            //        this.flussoAttuale = 0;
            //        break;
            //}

            //test
            
            
            
            //calcolo il flusso attuale usando la seguente formula=> Q=apertura_Valvola*coefficiente_Flusso*DeltaPressione
            //flussoAttuale = coefficiente_Flusso * percentuale_Apertura * deltapressione;
            //calcolo il flusso attuale usando la seguente formula=> Q=Area_Sezione_Trasversale*Velocità_Acqua(nella valvola)
            //l'area della sezione trasversale dipende dal diametro della valvola in questo modo =>A=pi*(Diametro/2)^2
            this.diametro_Metri = this.diametro/ 1000;
            this.raggio = diametro_Metri / 2;
            this.Area_Sezione_Trasversale_Totale = Math.PI * Math.Pow(raggio, 2);
            this.Area_Sezione_Trasversale_Attuale = percentuale_Apertura * Area_Sezione_Trasversale_Totale;
            this.flussoAttuale = Area_Sezione_Trasversale_Attuale * this.velocitaAcqua*tempoSimulazione;//[M^3/s]


            
            
        }
        public double Get_Flusso_attuale() { return flussoAttuale; }    
        public void Set_Apertura_valvola(double apertura) { this.percentuale_Apertura = apertura; }
        public double Get_Velocita_Acqua() { return this.velocitaAcqua; }
        public double Get_Temperatura_Acqua() { return this.temperaturaAcqua; }
        public double Get_Apertura() { return this.percentuale_Apertura; }
       
    }
}
