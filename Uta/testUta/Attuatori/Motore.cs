using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testUta.Attuatori
{
    internal class Motore : InterfaceAttuatori
    { 
        public string nome { get; set; }
        public string descrizione { get; set; }
        public string costruttore { get; set; }
        public string marca { get; set; } 
        public string modello { get; set; }
        public int attivato { get; set; }
        public double stato { get; set; }
        public int allarme { get; set; }
        public double richiesta { get; set; }

       
    }
}
