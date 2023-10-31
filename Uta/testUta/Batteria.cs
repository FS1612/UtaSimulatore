using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static System.Resources.ResXFileRef;

namespace testUta
{
    public class Batteria
    {
        double batteria_airflow /*=Costanti.batteria_airflow*/; 
        
          double calore_Specifico_Acqua = Costanti.calore_Specifico_Acqua;
        double calore_Specifico_Aria_pressioneCostante = Costanti.calore_Specifico_Aria_PressioneCostante;
        double costante_Gas = Costanti.costante_Gas;
        double tIniziale;
        double tFinale;
        double uIniziale;
        double uFinale;
        double pIniziale;
        double pFinale;
        Valvola valvola;
        double area;
        double perditaPressione;
        double potenza_effettiva = 0;
        double tAcquaUscita;
        double deltaT;
        public Batteria( double area, double pressione_attuale,double temperatura_attuale, double umidita_attuale,Valvola valvola,double perditaPressione,double airflow,double temp_Uscita_acqua)   
        {// i parametri iniziali sono quelli di inizio simulazione=> saranno calcolati da un sensore posto prima della batteria
            //quelli finali saranno rilevati da un sensore diverso

            batteria_airflow = airflow;
            //da riparametrizzare appena saranno implementati i sensori
            this.tIniziale = temperatura_attuale;
            this.uIniziale = umidita_attuale;
            this.pIniziale = pressione_attuale;
            //this.aperturaValvola = apertura_valvola;
            this.tFinale = tIniziale;
            this.uFinale = uIniziale;
            //this.pIniziale = 100;
            this.pFinale = pressione_attuale;
            this.area = area;
            //this.tipoBatteria = tipoBatteria;
            //this.stagione = stagione;
            this.valvola = valvola;
            this.perditaPressione = perditaPressione;
            //this.potenza = potenza;
            this.tAcquaUscita = temp_Uscita_acqua;

            
        }

       
        public void aggiorna()
        {
            double flusso_effettivo = this.valvola.Get_Flusso_attuale(); ;
            double temperaturaAcqua=this.valvola.Get_Temperatura_Acqua();

            if (this.valvola.Get_Apertura() > 0)
            {
                if (pFinale > pIniziale - perditaPressione) {  
                    this.pFinale -= this.perditaPressione;
                }
                calcoloScambiTermici( temperaturaAcqua, flusso_effettivo, potenza_effettiva);
                CalcoloVariazioneUmidità();
            }
            else
            {
                if (pFinale > pIniziale - perditaPressione)
                    this.pFinale -= this.perditaPressione;
                
            }

        }

        private void calcoloScambiTermici( double tacquaIngresso, double flusso_acqua, double pot)
        {//le temperature vanno espresse tutte in Kelvin per cui vanno convertite poichè le ricevo in gradi Celsius


            double deltaAcqua = this.tAcquaUscita - tacquaIngresso;
            double flusso_aria_kg_s = (this.batteria_airflow / 3600) / 0.86;
            //double flusso_acqua_kg_s = flusso_acqua / 3600;//1 l= 1 kg
            //poiche 1 L= 1 Kg allora l/s=kg/s
            double numeratore = flusso_acqua * this.calore_Specifico_Acqua *deltaAcqua;
            double denominatore = flusso_aria_kg_s * calore_Specifico_Aria_pressioneCostante;
             this.deltaT =Math.Abs(numeratore/denominatore);
            if(tacquaIngresso< this.tAcquaUscita)
            {
                this.tFinale -= deltaT;
            }
            else { this.tFinale += deltaT; }
        }
        private void CalcoloVariazioneUmidità()
        {
            // per questo calcolo uso l'equazione della legge di Clausius-Clapeyron ossia ln(P2 / P1) = - (ΔHvap / R) * (1 / T2 - 1 / T1)
            //in particolare una sua derivazione UR2 / UR1 = (P2 / P1) * exp[ΔHvap / R * (1 / T1 - 1 / T2)]
            //da cui=>UR2={(P2 / P1) * exp[ΔHvap / R * (1 / T1 - 1 / T2)]}*UR1
            double ΔHvap= 40700; //[J/mol] calore latente di vaporizzazione dell'acqua

            //converto le temperature in kelvin
            double tIniziele_Kelvin = this.tFinale-this.deltaT + 273.15;
            double tFinalee_Kelvin =this.tFinale + 273.15;

            // Calcolo la pressione di vapore iniziale (P1)
            double P1 = Math.Exp(ΔHvap / (this.costante_Gas * tIniziele_Kelvin));
            // Calcolo la pressione di vapore finale(P2) a temperatura T2
            double P2 = P1 * Math.Exp((ΔHvap /this.costante_Gas) * ((1 / tIniziele_Kelvin) - (1 / tFinalee_Kelvin)));
            
            this.uFinale = (P2 / P1) * this.uIniziale;
            //this.uFinale = this.uFinale * this.pIniziale/this.pFinale;
            
        }
        public double GetPotenza() { return this.potenza_effettiva; }
        public double Get_Temperatura_Finale() { return this.tFinale; }
        public double Get_Umidita_Finale() { return this.uFinale; }
        public double Get_Pressione_Finale() { return this.pFinale; }
        public double Get_Pressione_Iniziale() { return this.pIniziale; }
        public double Get_Umidita_Iniziale() { return this.uIniziale; }
        public Valvola Get_Valvola() { return this.valvola; }
    }
}
