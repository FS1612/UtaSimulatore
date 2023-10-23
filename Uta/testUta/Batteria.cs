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
        double batteria_airflow =Costanti.batteria_airflow; 
        double coefficienteConvezioneAria = Costanti.coefficienteConvezioneAria;
        //double batteriaCalda_velocitaAria = Costanti.batteriaCalda_velocitaAria;
        //double batteriaCalda_capacitaFreddo = Costanti.batteriaCalda_capacitaFreddo;
        //double batteriaCalda_capacitaCaldo = Costanti.batteriaCalda_capacitaCaldo;
        //double batteriaCalda_flussoCaldo = Costanti.batteriaCalda_flussoMassimo_Caldo;
        //double batteriaCalda_flussoFreddo = Costanti.batteriaCalda_flussoMassimo_Freddo;
        //double batteriaCalda_velocitaAcquaFreddo = Costanti.batteriaCalda_velocitaMassimaAcqua_Freddo;
        //double batteriaCalda_velocitaAcquaCaldo = Costanti.batteriaCalda_velocitaMassimoAcqua_Caldo;
        //double batteriaCalda_polliciTubatura = Costanti.batteriaCalda_polliciTubatura;
        //double batteriaCalda_diametroValvola = Costanti.batteriaCalda_diametroValvola;
        //double batteriaCalda_TemperaturaAcquaIngresso = Costanti.batteriaCalda_TemperaturaAcquaIngresso;
        //double batteriaCalda_TemperaturaAcquaUscita = Costanti.batteriaCalda_TemperaturaAcquaUscita;
        //double batteriaCalda_PerditaPressione = Costanti.batteriaCalda_PerditaPressione;
        //double batteriaCalda_MassimaPerditaPressione = Costanti.batteriaCalda_MassimaPerditaPressione;
        //double batteriaCalda_Spessore = Costanti.batteriaCalda_Spessore;
        //double batteriaCalda_Area = Costanti.batteriaCalda_Area;
        //double batteriaFredda_velocitaAria = Costanti.batteriaFredda_velocitaAria;
        //double batteriaFredda_capacitaFreddo = Costanti.batteriaFredda_capacitaFreddo;
        //double batteriaFredda_capacitaCaldo = Costanti.batteriaFredda_capacitaCaldo;
        //double batteriaFredda_flussoCaldo = Costanti.batteriaFredda_flussoMassimo_Caldo;
        //double batteriaFredda_flussoFreddo = Costanti.batteriaFredda_flussoMassimo_Freddo;
        //double batteriaFredda_velocitaAcquaFreddo = Costanti.batteriaFredda_velocitaMassimaAcqua_Freddo;
        //double batteriaFredda_velocitaAcquaCaldo = Costanti.batteriaFredda_velocitaMassimaAcqua_Caldo;
        //double batteriaFredda_polliciTubatura = Costanti.batteriaFredda_polliciTubatura;
        //double batteriaFredda_diametroValvola = Costanti.batteriaFredda_diametroValvola;
        //double batteriaFredda_TemperaturaAcquaIngresso = Costanti.batteriaFredda_TemperaturaAcquaIngresso;
        //double batteriaFredda_TemperaturaAcquaUscita = Costanti.batteriaFredda_TemperaturaAcquaUscita;
        //double batteriaFredda_PerditaPressione = Costanti.batteriaFredda_PerditaPressione;
        //double batteriaFredda_MassimaPerditaPressione = Costanti.batteriaFredda_MassimaPerditaPressione;
        //double batteriaFredda_Spessore = Costanti.batteriaFredda_Spessore;
        //double batteriaFredda_Area = Costanti.batteriaFredda_Area;
        //double batteriaFredda_Umidificatrice_flusso = Costanti.batteriaFredda_Umidificatrice_flussoMassimo;
        //double batteriaFredda_Umidificatrice_TemperaturaAcquaIngresso = Costanti.batteriaFredda_Umidificatrice_TemperaturaAcquaIngresso;
        //double batteriaFredda_Umidificatrice_TemperaturaAcquaUscita = Costanti.batteriaFredda_Umidificatrice_TemperaturaAcquaUscita;
        //double batteriaFredda_Umidificatrice_velocitaAria  = Costanti.batteriaFredda_Umidificatrice_velocitaAria ;
        //double batteriaFredda_Umidificatrice_capacita  = Costanti.batteriaFredda_Umidificatrice_capacita;
        //double batteriaFredda_Umidificatrice_PerditaPressione_Secco = Costanti.batteriaFredda_Umidificatrice_PerditaPressione_Secco;
        //double batteriaFredda_Umidificatrice_PerditaPressione_Umido = Costanti.batteriaFredda_Umidificatrice_PerditaPressione_Umido;
        //double batteriaFredda_Umidificatrice_Spessore  = Costanti.batteriaFredda_Umidificatrice_Spessore ;
        //double batteriaFredda_Umidificatrice_Area = Costanti.batteriaFredda_Umidificatrice_Area;






        double tEsterna = Costanti.temperaturaEsterna;
        double uEsterna = Costanti.umiditaEsterna;
        double costante_StefanBoltzmann = Costanti.costanteStefanBoltzmann;
        double calore_Specifico_Acqua = Costanti.calore_Specifico_Acqua;
        double calore_Specifico_Aria = Costanti.calore_Specifico_Aria_VolumeCostante;
        double calore_Specifico_Aria_pressioneCostante = Costanti.calore_Specifico_Aria_PressioneCostante;
        double massa_Molecolare_Aria = Costanti.massa_Molecolare_Aria;
        double costante_Gas = Costanti.costante_Gas;
        public Timer timer = new Timer();
        string stagione;
        string tipoBatteria;
        double tempoSimulazione;
        double tIniziale;
        double tFinale;
        double testerna;
        double uIniziale;
        double uFinale;
        double pIniziale;
        double pFinale;
        Valvola valvola;
        double area;
        double perditaPressione;
        //double aperturaValvola;
        double potenza=0;
        public Batteria(double tempoSimulazione/*, string tipoBatteria, string stagione*/, double area, double pressione_attuale,double temperatura_attuale, double umidita_attuale,Valvola valvola,double perditaPressione,double potenza)   
        {// i parametri iniziali sono quelli di inizio simulazione=> saranno calcolati da un sensore posto prima della batteria
            //quelli finali saranno rilevati da un sensore diverso
            this.tempoSimulazione = tempoSimulazione;
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
            this.potenza = potenza;
            //i timer accettano solo tempi in millisecondi
            timer.Interval = tempoSimulazione*1000;
            timer.Enabled = true;
            timer.Elapsed += Timer_Elapsed;
            
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {//le batterie sono sempre attive a cambiare sono solo i parametri di funzionamento 
         //if (this.tipoBatteria.Equals(Costanti.batteriaCalda))
         //{
         //    //if (this.stagione.Equals(Costanti.stagioneCalda))
         //    //{

            //        //double flusso_effettivo = this.valvola.Get_Flusso_attuale();
            //        //double delta_T = calcoloScambiTermici(batteriaCalda_Area, batteriaCalda_TemperaturaAcquaIngresso, flusso_effettivo);
            //    //}
            //    //else if (this.stagione.Equals(Costanti.stagioneFredda))
            //    //{
            //    //    double flusso_effettivo = this.valvola.Get_Flusso_attuale();
            //    //    double delta_T = calcoloScambiTermici(batteriaCalda_Area, batteriaCalda_TemperaturaAcquaIngresso, flusso_effettivo);
            //    //}
            //}
            //else if (this.tipoBatteria.Equals(Costanti.batteriaFredda))
            //{
            //    //if (this.stagione.Equals(Costanti.stagioneCalda))
            //    //{
            //    //double flusso_effettivo = this.valvola.Get_Flusso_attuale();
            //    //double delta_T = calcoloScambiTermici(batteriaFredda_Area, batteriaFredda_TemperaturaAcquaIngresso, flusso_effettivo);
            //    //}
            //    //else if (this.stagione.Equals(Costanti.stagioneFredda))
            //    //{
            //    //    double flusso_effettivo = this.valvola.Get_Flusso_attuale();
            //    //    double delta_T = calcoloScambiTermici(batteriaFredda_Area, batteriaFredda_TemperaturaAcquaIngresso, flusso_effettivo);
            //    //}
            //}
            //else if (this.tipoBatteria.Equals(Costanti.batteriaFreddaUmidificatrice))
            //{
            //    double flusso_effettivo = this.valvola.Get_Flusso_attuale();
            //    double delta_T = calcoloScambiTermici(batteriaFredda_Umidificatrice_Area, batteriaFredda_Umidificatrice_TemperaturaAcquaIngresso, flusso_effettivo);
            //}
            aggiorna();

        }
        public void aggiorna()
        {
            double flusso_effettivo = this.valvola.Get_Flusso_attuale(); ;
            double temperaturaAcqua=this.valvola.Get_Temperatura_Acqua();
            double app= this.valvola.Get_Apertura(); 
            double potenza_effettiva = this.potenza * this.valvola.Get_Apertura();
            //switch (tipoBatteria)
            //{
            //    case Costanti.batteriaCalda when flusso_effettivo > 0.0:
            //        calcoloScambiTermici(batteriaCalda_Area, batteriaCalda_TemperaturaAcquaIngresso, flusso_effettivo);
            //        CalcoloVariazioneUmidità();

            //        this.pFinale -= this.batteriaCalda_PerditaPressione;
            //        break;
            //    case Costanti.batteriaFredda when flusso_effettivo > 0.0:
            //        calcoloScambiTermici(batteriaFredda_Area, batteriaFredda_TemperaturaAcquaIngresso, flusso_effettivo);
            //        this.pFinale -= this.batteriaFredda_PerditaPressione;
            //        CalcoloVariazioneUmidità();
            //        break;
            //    case Costanti.batteriaFreddaUmidificatrice when flusso_effettivo > 0.0:
            //        calcoloScambiTermici(batteriaFredda_Umidificatrice_Area, batteriaFredda_Umidificatrice_TemperaturaAcquaIngresso, flusso_effettivo);
            //        CalcoloVariazioneUmidità();

            //        break;
            //    case Costanti.batteriaCalda when flusso_effettivo == 0.0:
            //        this.pFinale -= this.batteriaCalda_PerditaPressione;

            //        this.tFinale = this.tIniziale;
            //        this.uFinale = this.uIniziale;
            //        break;
            //    case Costanti.batteriaFredda when flusso_effettivo == 0.0:
            //        this.pFinale -= this.batteriaFredda_PerditaPressione;
            //        this.tFinale = this.tIniziale;
            //        this.uFinale = this.uIniziale;

            //        break;
            //    case Costanti.batteriaFreddaUmidificatrice when flusso_effettivo == 0.0:
            //        break;
            //    default:
            //        this.tFinale = this.tIniziale;
            //        this.uFinale = this.uIniziale;

            //        break;
            //}
            //if (flusso_effettivo > 0)
            if (this.valvola.Get_Apertura() > 0)
            {
                if (pFinale > pIniziale - perditaPressione) {  
                    this.pFinale -= this.perditaPressione;
                }
                calcoloScambiTermici(this.area, temperaturaAcqua, flusso_effettivo, potenza_effettiva);
                CalcoloVariazioneUmidità();
            }
            else
            {
                if (pFinale > pIniziale - perditaPressione)
                    this.pFinale -= this.perditaPressione;
                
            }

        }

        private void calcoloScambiTermici(double area, double tacquaIngresso, double flusso_acqua, double pot)
        {//le temperature vanno espresse tutte in Kelvin per cui vanno convertite poichè le ricevo in gradi Celsius

            double tIniziale_Kelvin = tIniziale + 273.15;
            double TemperaturaAcquaIngresso_Kelvin = tacquaIngresso + 273.15;
            double flusso_M3_s = batteria_airflow / 3600;
            //con la formula sopra trovo il volume per ogni secondo. se il tempo di simulazione cambia, deve cambiare anche il volume per cui moltiplico il volume appena trovato per il tempo

            double volume_tempo = flusso_M3_s * tempoSimulazione;//[m^3]
            double moli = (pIniziale * volume_tempo) / (costante_Gas * tIniziale_Kelvin);

            double massa_aria = moli * massa_Molecolare_Aria;//[g]
                                                             //per tener conto della valvola che aumenta o diminuisce il flusso d'acqua a temperatura t nella batteria devo moltiplicare il calore per il flusso effettivo
                                                             //lo scambio termico avviene sia per convezione sia per irraggiamento
                                                             //per la convezione uso la legge di raffreddamento di Newton Q=hA(T_acqua_radiatore-Testerna)
                                                             //Q=flusso di calore in watt
                                                             //h=coefficiente di convezione aria(W/m^2*K)
                                                             //A=area radiatore
                                                             //double Q_convezione = (coefficienteConvezioneAria * area * (TemperaturaAcquaIngresso_Kelvin - tIniziale_Kelvin))* flusso_acqua;
                                                             //per lo scambio per irraggiamento ho la formula per l'irraggiamento
                                                             //Q=sigma*A*(T_acqua_radiatore^4-T_attuale^4)
                                                             //sigma è la costante di Boltzmann
                                                             // double Q_irraggiamento = (costante_StefanBoltzmann * area * (Math.Pow(TemperaturaAcquaIngresso_Kelvin, 4) - Math.Pow(tIniziale_Kelvin, 4)))*flusso_acqua;
                                                             //per calcolare la temperatura finale uso la formula seguente: T_finale=t_iniziale+Delta_Conv+Delta_irraggiamento
                                                             //il delta di convezione si calcola=> Q_conv/(massa_Aria*calore_specifico_aria)
                                                             // massa aria=>moli⋅Massa_molecolare_aria
                                                             //per le moli uso la legge dei gas perfetti=> PV=nRT da cui n=PV/RT      
                                                             //double delta_convezione = Q_convezione / (massa_aria * calore_Specifico_Aria);
                                                             //calcolo l'irraggiamento
                                                             //double delta_irraggiamento = Q_irraggiamento / (massa_aria * calore_Specifico_Aria);
                                                             // i delta sono considerati in base al tempo [K/s] perciò per rimuovere questa dipendenza li moltiplico per il tempo di simulazione

            //double tFinale_Kelvin= tIniziale_Kelvin + (delta_convezione * tempoSimulazione) +(delta_irraggiamento * tempoSimulazione); 
            //tFinale=tFinale_Kelvin-273.15;
            // this.potenza = Q_convezione + Q_irraggiamento;

            //Q=m*cp*DT
            //double massa_aria_chili = massa_aria * 1000;
            //double DeltaT = pot / (batteria_airflow*1.2 * calore_Specifico_Aria_pressioneCostante);
            //double deltaT_tempo = DeltaT * tempoSimulazione;
            //this.tFinale += (deltaT_tempo);
            double rho = 1.2;
            double Pacqua = (flusso_acqua / 3600) * 10;
            //double Delta = flusso_acqua / (batteria_airflow * rho * calore_Specifico_Aria_pressioneCostante);
            //this.tFinale = Delta + tIniziale;
            double DeltaT= (Pacqua*3600) / (flusso_M3_s * rho * calore_Specifico_Aria_pressioneCostante);
            double DeltaT_Celsius= DeltaT-273.15;
            this.tFinale = this.tFinale + DeltaT_Celsius;

        }
        private void CalcoloVariazioneUmidità()
        {
            // per questo calcolo uso l'equazione della legge di Clausius-Clapeyron ossia ln(P2 / P1) = - (ΔHvap / R) * (1 / T2 - 1 / T1)
            //in particolare una sua derivazione UR2 / UR1 = (P2 / P1) * exp[ΔHvap / R * (1 / T1 - 1 / T2)]
            //da cui=>UR2={(P2 / P1) * exp[ΔHvap / R * (1 / T1 - 1 / T2)]}*UR1
            double ΔHvap= 40700; //[J/mol] 

            //converto le temperature in kelvin
            double tIniziele_Kelvin = this.tIniziale + 273.15;
            double tFinalee_Kelvin =this.tFinale + 273.15;

            // Calcolo la pressione di vapore iniziale (P1)
            double P1 = Math.Exp(ΔHvap / (this.costante_Gas * tIniziele_Kelvin));
            // Calcolo la pressione di vapore finale(P2) a temperatura T2
            double P2 = P1 * Math.Exp((ΔHvap /this.costante_Gas) * ((1 / tIniziele_Kelvin) - (1 / tFinalee_Kelvin)));
            
            this.uFinale = (P2 / P1) * this.uIniziale;
            //this.uFinale = this.uFinale * this.pIniziale/this.pFinale;
            
        }
        public double GetPotenza() { return this.potenza; }
        public double Get_Temperatura_Finale() { return this.tFinale; }
        public double Get_Umidita_Finale() { return this.uFinale; }
        public double Get_Pressione_Finale() { return this.pFinale; }
        public double Get_Pressione_Iniziale() { return this.pIniziale; }
        public double Get_Umidita_Iniziale() { return this.uIniziale; }
        public Valvola Get_Valvola() { return this.valvola; }
    }
}
