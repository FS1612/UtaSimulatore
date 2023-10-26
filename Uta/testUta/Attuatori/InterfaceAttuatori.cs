using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testUta.Attuatori
{
    public interface InterfaceAttuatori
    {
        
        string nome { get; set; }
        string descrizione { get; set; }
        string costruttore { get; set; }
        string marca { get; set; }
        string modello { get; set; }
        int attivato { get; set; }//booleano
        double posizioneAttuale { get; set; }//sia stati booleani sia analogici
        int allarme { get; set; }//booleano
        double velocitaRichiesta { get; set; }
        double posizioneRichiesta { get; set; }
        double velocitaAttuale { get; set; }
        double velocitaMassima { get; set; }//in giri al secondo
        double spostamentoMassimo { get; set; }//in gradi
        int fineCorsaMassimo { get; set; }//booleani
        int fineCorsaMinimo { get; set; }//booleani
        double tempoRotazione { get; set; }
        double tempoRotazioneRichiesto { get; set; }
        double tempoRotazioneMassimo { get; set; }//sec
        double gradiMassimi { get; set; }





    }
}
