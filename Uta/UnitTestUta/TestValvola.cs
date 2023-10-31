using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using testUta;

namespace UnitTestUta
{
    [TestClass]
    public class TestValvola
    {
        Valvola valvola = new Valvola(0, 1.2, 50, 20);
        [TestMethod]
        public void TestValvolaChiusa()
        {
            
            Assert.AreEqual(0,valvola.Get_Apertura());
            Assert.AreEqual(0,valvola.Get_Flusso_attuale());
        }
        [TestMethod]
        public void TestCambioApertura()
        {
            valvola.Set_Apertura_valvola(0.5);
            valvola.aggiorna();
            Assert.AreEqual(0.5,valvola.Get_Apertura());
            double metri= 0.02;
            
            double raggio=metri/2;
            double val= Math.PI * Math.Pow(raggio, 2)*valvola.Get_Apertura()*valvola.Get_Velocita_Acqua();
            Assert.AreEqual(val, valvola.Get_Flusso_attuale());
        }
    }
}
