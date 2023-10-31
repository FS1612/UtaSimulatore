using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testUta.Sensori.Sensori_Digitali;

namespace testUta.Elementi_Meccanici
{
    public class Filtro
    {
        public string nome { set; get; }
        public string produttore { set; get; }
        public string marca { set; get; }
        public string modello { set; get; }
        public double perditaPressioneFiltroPulito { set; get; }
        public double perditaPressioneAttuale { set; get; }
        public double perditaPressioneFiltroSporco { set; get; }
        public double Co2Iniziale { set; get; }
        public double flusso { set; get; }
        public double tempo_s { set; get; }
        public SensoreDigitale SensoreDigitale { set; get; }
        public Filtro(string nome,string produttore, string marca, string modello,double pressioneFiltroPulito,double pressioneFiltroSporco,double co2Iniziale,double flussoAria) { 
            this.nome = nome;
            this.produttore = produttore;
            this.marca = marca;
            this.modello = modello; 
            this.perditaPressioneFiltroPulito = pressioneFiltroPulito;
            this.perditaPressioneAttuale = pressioneFiltroPulito;
            this.perditaPressioneFiltroSporco = pressioneFiltroSporco;
            this.Co2Iniziale = co2Iniziale;
            this.flusso = flussoAria;
            this.tempo_s = 1;
            this.SensoreDigitale = new SensoreDigitale("", "", "", pressioneFiltroSporco);
        }
        public void Aggiorna()
        {
            double flusso_M3_S = flusso / 3600;
            double carico_inquinanti = tempo_s * flusso_M3_S * Co2Iniziale/1000000;
            double k_sporcamento = 0.1;
            perditaPressioneAttuale += k_sporcamento*carico_inquinanti;
            SensoreDigitale.VerificaValore(perditaPressioneAttuale);

        }
    }
}
