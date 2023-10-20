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
        double stato { get; set; }//sia stati booleani sia analogici
        int allarme { get; set; }//booleano
        double richiesta { get; set; }
        


    }
}
