using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Timers;
using testUta.Attuatori;

namespace testUta.Elementi_Meccanici
{
    public class Mandata
    {
        Timer timer = new Timer(1000);
        double[] psf = { 0, 75, 270, 600, 1080, 1400, 1600 };
        double[] rpm = { 0, 520, 1050, 1575, 2155, 2427, 2620 };
        double[] flusso = { 0, 1500, 3000, 4900, 6200, 7000, 14000 };
        double pressioneAttuale;
        public Mandata()
        {
            //serranda

            // poiche la ventola deve generare il flusso d'aria di tutta la mandata lo instanzio all'inizio
            Motore motore = new Motore("motore figo", "1234", "nuova", "io", "motore per fare un po tutto", 2818, -1, 150, 90, 150);
            Ventilatore ventola = new Ventilatore(0, motore, 1.6, psf, rpm, flusso);
            this.pressioneAttuale = ventola.pressioneGenerata;

            //filtro 1

            //filtro 2


            //sensore temperatura


            //sensore umidita 

            //recuperatore

            //termostato Antigelo

            //serranda bypass
            //in questa sezione va inserito il miscelatore in modo che possa effettuare le miscelazioni d'aria se necessario

            //sensore temperatura post-recupero

            //batteria riscaldamento
            //Batteria riscaldamento=new Batteria( 1.16,this.pressioneAttuale,)
            //batteria raffreddamento

            //umidificatore

            // sensore temperatura post umidificazione

            //batteria post riscaldo

            //sensore temperatura post-riscaldo


            this.timer.Enabled = true;
            this.timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            
        }

        
    }
}
