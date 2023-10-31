using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUta.Sensori
{
    public interface InterfacciaSensori
    {
        string nome  { get; set; }
        string costruttore { get; set; }
        string marca { get; set; }
        string modello { get; set; }
        string unitaMisura { get; set; }
        double rangeMassimo { get; set; }
        double rangeMinimo { get; set; }
        double valoreAttuale { get; set; }
        string descrizione { get; set; }
    }
}
