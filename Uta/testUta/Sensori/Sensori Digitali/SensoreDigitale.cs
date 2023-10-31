using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUta.Sensori.Sensori_Digitali
{
    public class SensoreDigitale : InterfacciaSensori
    {
        public string nome { get ; set; }
        public string costruttore { get ; set; }
        public string marca { get; set; }
        public string modello { get; set; }
        public string unitaMisura { get; set; }
        public double valoreAttuale { get; set; }
        public string descrizione { get; set; }
        public double rangeMassimo { get; set; }
        public double rangeMinimo { get; set; }
        public double valoreLimite { get; set; }

        public SensoreDigitale(  string produttore, string modello, string nome,double valoreLimite) {
            rangeMinimo = 0;
            rangeMassimo = 1;
            this.nome = nome;
            this.unitaMisura ="";
            this.marca = marca;
            this.costruttore = produttore;
            this.modello = modello;
            this.valoreAttuale = 0;
            this.valoreLimite = valoreLimite;

        }
        public void VerificaValore(double val)
        {
            
            if (val > valoreLimite) { valoreAttuale = 1; }
            else { valoreAttuale = 0; }
        }
        public void VerificaDeltaValori(double val1, double val2)
        {
            if(val1-val2>valoreLimite|| val2 - val1 > valoreLimite)
            {
                valoreAttuale = 1;
            }
            else { valoreAttuale = 0; }
        }
    }
}
