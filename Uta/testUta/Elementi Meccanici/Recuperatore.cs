using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace testUta.Elementi_Meccanici
{
    public class Recuperatore
    {
        double efficienzaTemperatura=Costanti.Recuperatore_Efficienza_Termica;
        double efficienzaUmidita=Costanti.Recuperatore_Efficienza_Umidita;
        double flussoMandata = Costanti.flussoMandata;
        double flussoRipresa = Costanti.flussoRipresa;
        double allarme;//valore booleano
        double stato;//valore booleano
        double avviamento;//valore booleano
        double tempRipresa;//rappresenta il valore della temperatura dell'aria di ripresa
        double umiditaRipresa;//rappresenta il valore della umidita dell'aria di ripresa
        double umiditaMandata;//rappresenta il valore della umidita dell'aria di mandata
        double tempMandata;//rappresenta il valore della temperatura dell'aria di mandata
        Timer timer = new Timer();
        public Recuperatore(double avviamento,double tempoSimulazione, double temperaturaRipresa, double umiditaRipresa)
        {
            this.avviamento = avviamento;
            this.stato = 0;
            this.allarme = 0;
            this.tempRipresa = temperaturaRipresa;
            this.umiditaRipresa = umiditaRipresa;
            
            this.timer.Interval = tempoSimulazione;
            
            this.timer.Enabled = true;
            this.timer.Elapsed += Timer_Elapsed;
        }
        public delegate void TempRitornoCambiata();
        public event TempRitornoCambiata TempRitornoCambiataCambiata;
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (this.avviamento == 1 && this.allarme == 0)
            {

                this.stato = 1;

                   this.tempMandata =  (efficienzaTemperatura * this.tempRipresa);

                this.umiditaMandata = (this.umiditaRipresa * this.efficienzaUmidita) ;
            }
            
        }

        private void OnTempRitornoCambiata()
        {
            
            this.tempMandata = this.tempMandata + (efficienzaTemperatura * this.tempRipresa);
        }

        public double Get_TemperaturaRipresa() { return this.tempRipresa; }
        public double Get_TemperaturaMandata() { return this.tempMandata; }
        public void Set_TemperaturaRipresa(double temp) { this.tempRipresa = temp; }
        public double Get_UmiditaRipresa() { return this.umiditaRipresa; }
        public void Set_UmiditaRipresa(double umidita) {  this.umiditaRipresa=umidita; }
        public double Get_UmiditaMandata() { return this.umiditaMandata; }
        public double Get_Avviamento() { return this.avviamento; }
        public double Get_Stato() { return this.stato; }
        public double Get_Allarme() { return this.allarme; }
        public void Set_Allarme() { if (this.allarme == 1) {this. allarme = 0; } else { this.allarme = 1; } }
        public void Set_Avviamento(double avviamento) { this.avviamento = avviamento; }
    }
}
