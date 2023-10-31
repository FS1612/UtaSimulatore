using MathNet.Numerics.Interpolation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using testUta.Attuatori;

namespace testUta.Elementi_Meccanici
{
    public class Ventilatore
    {
        double []psf;
        double[] rpm;
        double[] flusso ;//[m3/h]
        public double pressioneFinale { get; set; }
        public double pressioneIniziale { get; set; }
        public double velocitàAttuale { get; set; }
        public double pressioneGenerata { get; set; }
        public double velocitaAria { get; set; }
        double sezioneTrasversale;
        Motore M;
        public double flusso_m3_h { get; set; }
        public Ventilatore(double pressioneIniziale, Motore motore,  double sezione, double[] psf, double[] rpm, double[] flusso)
        {
            this.psf = psf;
            this.rpm = rpm;
            this.flusso = flusso;
            this.velocitàAttuale = 0;
            this.M = motore;
            this.pressioneFinale = pressioneIniziale;
            this.pressioneIniziale = pressioneIniziale;

            this.sezioneTrasversale = sezione;
        }



        public void Aggiorna(double velocita)
        {//in giri al secondo
            velocitàAttuale = velocita;
            var interpolaFlusso_Rpm = CubicSpline.InterpolateNatural(rpm, flusso);
            var interpolaRpm_Psf = CubicSpline.InterpolateNatural(rpm, psf);
            this.flusso_m3_h = interpolaFlusso_Rpm.Interpolate(velocita);
            this.pressioneGenerata = interpolaRpm_Psf.Interpolate(velocita);
            this.pressioneFinale= this.pressioneGenerata-pressioneIniziale;
            velocitaAria = (this.flusso_m3_h / 3600) / sezioneTrasversale;
        }
    }
}
