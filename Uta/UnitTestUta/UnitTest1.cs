using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using testUta;

namespace UnitTestUta
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void TestBatteriaValvolaChiusa()
        {
        //    Valvola valv = new Valvola(0, 0.1, Costanti.batteriaCalda_velocitaMassimoAcqua_Caldo, Costanti.batteriaCalda_TemperaturaAcquaIngresso, Costanti.batteriaCalda_diametroValvola);
        //    Batteria bat = new Batteria(0.1, Costanti.batteriaCalda_Area,  100, 24, 20, valv,Costanti.batteriaCalda_PerditaPressione);
        ////uso un metodo di appoggio per bypassare il tiimer
        //    bat.aggiorna();
        //    Assert.AreEqual(0, bat.GetPotenza(), " la potenza erogata dovrebbe essere 0");
        //    Assert.AreEqual(20, bat.Get_Umidita_Finale(), "la batteria è spenta, l'umidità non puo cambiare");
        //    Assert.AreEqual(24, bat.Get_Temperatura_Finale(), "la batteria è spenta, la temperatura non puo cambiare");
        //    Assert.AreEqual(100.0 - testUta.Costanti.batteriaCalda_PerditaPressione, bat.Get_Pressione_Finale());


        }
        [TestMethod]
        public void TestBatteriaValvolaAperta()
        {
            //Valvola valv = new Valvola(1, 0.1, Costanti.batteriaCalda_velocitaMassimoAcqua_Caldo, Costanti.batteriaCalda_TemperaturaAcquaIngresso, Costanti.batteriaCalda_diametroValvola);
            //Batteria bat = new Batteria(0.1, Costanti.batteriaCalda_Area, 100, 24, 20, valv, Costanti.batteriaCalda_PerditaPressione);
            //valv.aggiorna();
            //bat.aggiorna();
            //Assert.AreNotEqual(20, bat.Get_Umidita_Finale(), "la batteria è accesa, la temperatura non puo cambiare");
            //Assert.AreEqual(100 - testUta.Costanti.batteriaCalda_PerditaPressione, bat.Get_Pressione_Finale(), "la pressione dovrebbe calare di:" + testUta.Costanti.batteriaCalda_PerditaPressione);
            //Assert.AreNotEqual(0, bat.GetPotenza(), " la potenza erogata dovrebbe essere maggiore di 0");
            //Assert.AreNotEqual(24, bat.Get_Temperatura_Finale(), "la batteria è accesa, la temperatura deve cambiare");
         
            
            

        }
    }
}
