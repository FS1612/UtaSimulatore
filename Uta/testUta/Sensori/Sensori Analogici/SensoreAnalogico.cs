using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUta.Sensori.Sensori_Analogici
{
    public  class SensoreAnalogico : InterfacciaSensori
    {
        public string nome { get ; set; }
        public string costruttore { get; set ; }
        public string marca { get; set ; }
        public string modello { get ; set; }
        public string unitaMisura { get; set; }
        public double massimo { get; set; }
        public double minimo { get; set; }
        public double rangeMassimo { get ; set; }
        public double rangeMinimo { get; set; }

        public double valoreAttuale { get ; set; }
        public string descrizione { get; set; }
        public double valoreVariazione { get; set; }
        bool MinRaggiunto { get; set; }
        bool MaxRaggiunto { get; set; }
        private bool StatoAttivazione = false;//all'inizio è spento
        public SensoreAnalogico(double ValMin, double ValMax, double ValoreVariazione, string produttore, string modello, string UnitaMisura,  string nome, double valoreInizio)
        {
            rangeMinimo = ValMin;
            rangeMassimo = ValMax;
            minimo = 0;
            //progressivo++;

            valoreVariazione = ValoreVariazione;

            this.nome = nome;
            this.unitaMisura = UnitaMisura;
            this.marca = marca;
            this.costruttore = produttore;
            this.modello = modello;
            this.valoreAttuale = valoreInizio;
            this.MinRaggiunto = true;
            this.MaxRaggiunto = false;

        }
        public void aggiornaMisurazione()
        {        
                this.SetAvvioSensore();
                ModificaValAttuale();
        }
        public void SetAvvioSensore()
        {
            if (StatoAttivazione)
            {
                StatoAttivazione = false;
            }
            else
            {
                StatoAttivazione = true;
            }
        }
        private void ModificaValAttuale()
        {

            

            // Verifica se è stato raggiunto il limite minimo o massimo
            if (valoreAttuale <= rangeMinimo)
            {
                MinRaggiunto = true;
                MaxRaggiunto = false;
                valoreAttuale =rangeMinimo;
            }
            else if (valoreAttuale >= rangeMassimo)
            {
                MinRaggiunto = false;
                MaxRaggiunto = true;
                valoreAttuale = rangeMassimo;
            }
            if (MinRaggiunto)
            {

                valoreAttuale += (float)valoreVariazione;
            }
            else
            {

                valoreAttuale -= (float)valoreVariazione;
            }
        }
        public void ResettaSensore()
        {
            this.StatoAttivazione = false;
            this.valoreAttuale = this.rangeMinimo;
            this.valoreVariazione = 0;
            this.MaxRaggiunto = false;
            this.MinRaggiunto = true;

        }

    }
}
