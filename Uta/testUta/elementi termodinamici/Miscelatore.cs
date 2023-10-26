using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Timers;

namespace testUta.elementi_termodinamici
{
    public class Miscelatore
    {
        
        double massa_Molecolare_Aria = Costanti.massa_Molecolare_Aria;
        double costante_Gas = Costanti.costante_Gas;
        double airflowMandata = Costanti.batteria_airflow;
        double flusso_ritorno;
        double temperatura_madata;
        double umidita_madata;
        double umidita_ritorno;
        double umidita_finale;
        double temperatura_ritorno;
        double temperatura_finale;
        double flusso_ariaMandata_kg_s;
        double flusso_ariaRitorno_kg_s;
        Timer timer=new Timer();
        public Miscelatore(double tempo, double flusso_ritorno, double temperatura_madata, double temperatura_ritorno, double umidita_madata, double umidita_ritorno)
        {
            this.flusso_ritorno = flusso_ritorno;
            this.umidita_ritorno=umidita_ritorno;
            this.umidita_madata = umidita_madata;
            this.temperatura_madata = temperatura_madata;
            this.temperatura_ritorno = temperatura_ritorno;
            this.timer = new Timer(tempo * 1000);
            this.timer.Enabled = true;
            this.timer.Elapsed += Timer_Elapsed;
            this.umidita_madata = umidita_madata;
            this.umidita_ritorno = umidita_ritorno;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            GestioneTemperature();
            GestioneUmidita();
        }
        public void GestioneTemperature() {
        if(this.flusso_ritorno > 0) {
                //calcolo la temperatura dell'aria in mandata considerando le due masse all'equilibrio
                //Q_ritorno=flusso_ritorno*(T_partenza-T_arrivo)
                //Q_mandata=flusso_mandata*(T_arrivo-T_Partenza)
                //le temperature sono in kelvin
                double T_mandata_Kelvin = this.temperatura_madata + 273.15;
                double T_ritorno_Kelvin = this.temperatura_ritorno + 273.15;
                this.flusso_ariaMandata_kg_s = (this.airflowMandata / 3600) / 0.86;//14000
                this.flusso_ariaRitorno_kg_s = (this.flusso_ritorno / 3600) / 0.86;//12600*apertura serranda
                //Q_ritorno=flusso_ariaRitorno_kg_s*(T_ritorno_Kelvin-x)
                //Q_mandata=flusso_ariaMandata_kg_s*(x-T_mandata_Kelvin)
                //per bilancio termico ho Q_ritorno=Q_mandata
                //=>flusso_ariaRitorno_kg_s*(T_ritorno_Kelvin-x)=flusso_ariaMandata_kg_s*(x-T_mandata_Kelvin)
                //=>x=(flusso_ariaRitorno_kg_s*T_ritorno_Kelvin+flusso_ariaMandata_kg_s*T_mandata_Kelvin)/flusso_ariaMandata_kg_s+flusso_ariaRitorno_kg_s
                double numeratore = flusso_ariaRitorno_kg_s * T_ritorno_Kelvin + flusso_ariaMandata_kg_s * T_mandata_Kelvin;
                double denominatore = flusso_ariaMandata_kg_s + flusso_ariaRitorno_kg_s;
                double x=numeratore/denominatore;
                this.temperatura_finale = x - 273.15;
            }
            else
            {
                this.temperatura_finale = temperatura_madata;
            }
        }
        public void GestioneUmidita()
        {
            if (this.flusso_ritorno > 0)
            {
                //Q_ritorno=flusso_ariaRitorno_kg_s*(U_ritorno-x)
                //Q_mandata=flusso_ariaMandata_kg_s*(x-U_mandata)
                //per bilancio termico ho Q_ritorno=Q_mandata
                //=>flusso_ariaRitorno_kg_s*(U_ritorno-x)=flusso_ariaMandata_kg_s*(x-U_mandata)
                //=>x=(flusso_ariaRitorno_kg_s*U_ritorno+flusso_ariaMandata_kg_s*U_mandata)/flusso_ariaMandata_kg_s+flusso_ariaRitorno_kg_s
                double numeratore = flusso_ariaRitorno_kg_s * this.umidita_ritorno + flusso_ariaMandata_kg_s * this.umidita_madata;
                double denominatore = flusso_ariaMandata_kg_s + flusso_ariaRitorno_kg_s;
                this.umidita_finale = numeratore / denominatore;
            }
            else
            {
                this.umidita_finale = this.umidita_madata;
            }
        }
    }
}
