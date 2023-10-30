using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUta
{
    public class Costanti
    {  //soazio da bordo sx per commenti(separtori di sezione) 2 tab
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ///////////// stringhe per confronti////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        public const string stagioneCalda = "stagione calda";
        public const string stagioneFredda = "stagione fredda";
        public const string batteriaFredda = "batteria fredda";
        public const string batteriaFreddaUmidificatrice = "batteria fredda umidificatrice";
        public const string batteriaCalda = "batteria calda";
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////Gestione ///////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        public const double temperaturaEsterna = 20; //[°C]
        public const double umiditaEsterna = 20; //[%]
        public const double pressioneEsterna = 250; //[Pa]
        public const double costanteStefanBoltzmann = 5.67e-8; //[W/(M^2*K^4)]
        public const double calore_Specifico_Acqua = 4186;// [J/kg*K]
        public const double calore_Specifico_Aria_VolumeCostante = 0.717  ;// [J/g*K]
        public const double calore_Specifico_Aria_PressioneCostante = 1005  ;// [J/Kg*K]
        public const double massa_Molecolare_Aria = 28.96;//[ g/mol]
        public const double costante_Gas = 8.314;//[ J/(mol·K)] //pressione in Pa, volume in M^3 e temperatura in K
        public const double tempoSimulazione = 1; //[s] 
        public const double flussoMandata = 14000; //[m^3/h] 
        public const double flussoRipresa = 12600; //[m^3/h] 
        public const double velocitaAriaMandata = 1.67; //[m/s] 
        public const double velocitaAriaRiipresa = 1.50; //[m/s] 

        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////Parametri Generali Batteria/////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        public const double aperturaMassimaValvola = 100; //
        public const double batteria_airflow = 14000; //[m^3/h]
        public const double coefficienteConvezioneAria = 20;//[W/(m^2*K)]

        /*le batterie ricevono sempre acqua indipendentemente dal periodo dell'anno,
          a variare sono i parametri relativi alla velocità, al flusso dell'acqua
          e la capacita del radiatore.
          freddo= parametri relativi alla batteria durante il periodo invernale
          caldo= parametri relativi alla batteria durante il periodo estivo
          le batterie sono attive per gestire al meglio l'umidità*/


        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////Batteria Calda////////////////////////////////// 
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        public const double batteriaCalda_velocitaAria = 2.10; //[m/s]
        public const double batteriaCalda_capacitaFreddo = 37500; //[W]
        public const double batteriaCalda_capacitaCaldo = 23910; //[W]
           /*i valori massimi sono ottenuti come valore medio *2*/
        public const double batteriaCalda_flussoMassimo_Caldo = 1.142; //[l/s]
        public const double batteriaCalda_flussoMassimo_Freddo = 1.142; //[l/s]
        public const double batteriaCalda_velocitaMassimaAcqua_Freddo = 3.08; //[m/s]
        public const double batteriaCalda_velocitaMassimoAcqua_Caldo = 1.88; //[m/s]
        public const double batteriaCalda_polliciTubatura = 25;//[mm]
        public const double batteriaCalda_diametroValvola = 20;//[mm] diametro
        public const double batteriaCalda_TemperaturaAcquaIngresso = 45;//[°C]
        public const double batteriaCalda_TemperaturaAcquaUscita = 35;//[°C]
        public const double batteriaCalda_PerditaPressione = 53;//[PA]
        public const double batteriaCalda_MassimaPerditaPressione =18;//[PA]
        public const double batteriaCalda_Spessore = 270;//[MM]
        public const double batteriaCalda_Area = 1.16;//[M^2]
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////Batteria Fredda///////////////////////////////// 
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        public const double batteriaFredda_velocitaAria = 2.12; //[m/s]
        public const double batteriaFredda_capacitaFreddo = 30130; //[W]
        public const double batteriaFredda_capacitaCaldo = 47500; //[W]
            /*i valori massimi sono ottenuti come valore medio *2*/
        public const double batteriaFredda_flussoMassimo_Caldo = 2.880; //[l/s]
        public const double batteriaFredda_flussoMassimo_Freddo = 2.27; //[l/s]
        public const double batteriaFredda_velocitaMassimaAcqua_Freddo = 2.12; //[m/s]
        public const double batteriaFredda_velocitaMassimaAcqua_Caldo = 1.68; //[m/s]
        public const double batteriaFredda_polliciTubatura = 45;//[mm] diametro
        public const double batteriaFredda_diametroValvola = 32;//[mm] diametro
        public const double batteriaFredda_TemperaturaAcquaIngresso = 13;//[°C]
        public const double batteriaFredda_TemperaturaAcquaUscita = 18;//[°C]
        public const double batteriaFredda_PerditaPressione = 53;//[PA]
        public const double batteriaFredda_MassimaPerditaPressione = 53;//[PA]
        public const double batteriaFredda_Spessore = 490;//[MM]
        public const double batteriaFredda_Area = 2.89;//[M^2]
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        //////////////////Batteria Fredda Umidificatrice//////////////////////// 
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        public const double batteriaFredda_Umidificatrice_flussoMassimo = 7.634;//[l/s]
        public const double batteriaFredda_Umidificatrice_velocitaMassimaAcqua = 2.46;//[m/s]
        public const double batteriaFredda_Umidificatrice_TemperaturaAcquaIngresso = 6;//[°C]
        public const double batteriaFredda_Umidificatrice_TemperaturaAcquaUscita = 11;//[°C]
        public const double batteriaFredda_Umidificatrice_velocitaAria = 2.13; //[m/s]
        public const double batteriaFredda_Umidificatrice_capacita = 79.89; //[kw]
        public const double batteriaFredda_Umidificatrice_PerditaPressione_Secco = 111;//[PA]
        public const double batteriaFredda_Umidificatrice_PerditaPressione_Umido = 72;//[PA]
        public const double batteriaFredda_Umidificatrice_Spessore = 1210;//[MM]
        public const double batteriaFredda_Umidificatrice_Area = 7.51;//[M^2]
        public const double batteriaFredda_Umidificatrice_diametroValvola = 50;//[MM]



        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        //////////////////Valvola/////////////////////////////////////////////// 
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        //public const double valvola_Ccoefficiente_Flusso = 1;
        //public const double valvola_Differenza_Pressione_BatteriaFredda_Freddo = 61440; //[Pa]
        //public const double valvola_Differenza_Pressione_BatteriaFredda_Caldo = 32180; //[Pa]
        //public const double valvola_Differenza_Pressione_BatteriaCalda_Caldo = 35840; //[Pa]
        //public const double valvola_Differenza_Pressione_BatteriaCalda_Freddo = 79840; //[Pa]

        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        //////////////////Ventola/////////////////////////////////////////////// 
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        //public const double ventola_FattoreK_adimensionale = 170;
        //public const double ventola_Diametro = 14.9; //[M]
        public const double ventolaMandata_SezioneTrasversale = 1.60; //[M^2] 1080[mm]*1090[mm]
        public const double ventolaRitorno_SezioneTrasversale = 1.0152; //[M^2] 1080[mm]*940[mm]
        //public const double ventolaMandata_EfficienzaPressione = 0.577; //pressione massima generata/n.giri per generare la pressione massima
        //parametri di interpolazione
        public  double[] ventola_Rpm = {0,520,1050,1575,2155,2427,2620 };
        public double[] ventola__Psf = {0,75,270,600,1080,1400,1600};
        public  double[] ventola__Flusso = { 0, 1500, 3000, 4900, 6200, 7000, 14000 };//[m3/h]


        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////Recuperatore  ////////////////////////////////// 
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        public const double Recuperatore_Efficienza_Termica = 0.7;//[%]
        public const double Recuperatore_Efficienza_Umidita = 0.68;//[%]
    }
}
