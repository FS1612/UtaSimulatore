using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using testUta.Attuatori;
using testUta.Elementi_Meccanici;
using testUta.Sensori.Sensori_Digitali;

namespace UnitTestUta
{
    [TestClass]
    public class TestSensoreDigitale
    {
        [TestMethod]
        public void VerificaOutput_CasoBase()
        {
            SensoreDigitale digitale = new SensoreDigitale("io", "digitale", "test digitale", 100);
            digitale.VerificaValore(0);
            Assert.AreEqual(0, digitale.valoreAttuale,"il valore è molto inferiore al limite, il sensore non deve scattare");
        }
        [TestMethod]
        public void VerificaOutput_CasoMaggioreLimite()
        {
            SensoreDigitale digitale = new SensoreDigitale("io", "digitale", "test digitale", 100);
            digitale.VerificaValore(300);
            Assert.AreEqual(1, digitale.valoreAttuale, "il limite viene superato e il sensore deve scattare");
        }
        [TestMethod]
        public void VerificaOutput_CasoVentola()
        {
            Motore m = new Motore("motore figo", "1234", "nuova", "io", "motore per fare un po tutto", 2818, -1, 150, 90, 150);
            double[] psf = { 0, 75, 270, 600, 1080, 1400, 1600 };
            double[] rpm = { 0, 520, 1050, 1575, 2155, 2427, 2620 };
            double[] flusso = { 0, 1500, 3000, 4900, 6200, 7000, 14000 };//[m3/h]
            Ventilatore v = new Ventilatore(0, m, 1.60, psf, rpm, flusso);
            SensoreDigitale digitale = new SensoreDigitale("io", "digitale", "test digitale", 100);
            digitale.VerificaDeltaValori(0,v.pressioneFinale);
            Assert.AreEqual(0, digitale.valoreAttuale, "se il ventilatore è spento le due pressioni devono coincidere");
            m.attivato = 1;
           
            v.Aggiorna(2818);
            digitale.VerificaDeltaValori(0, v.pressioneFinale);

            Assert.AreEqual(1, digitale.valoreAttuale, "il ventilatore è acceso quindi i due valori differiscono");


        }
    }
}
