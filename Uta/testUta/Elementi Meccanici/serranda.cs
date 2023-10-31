using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testUta.Attuatori;

namespace testUta.Elementi_Meccanici
{
    public class serranda : Motore
    {
        public serranda(string nome, string modello, string marca, string costruttore, string descrizione) : base(nome, modello, marca, costruttore, descrizione, 50, 1, 120,360, 120)
        {

        }
    }
}
