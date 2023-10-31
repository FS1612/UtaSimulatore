using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using testUta.elementi_termodinamici;

namespace UnitTestUta
{
    [TestClass]
    public class TestMiscelatore
    {
        [TestMethod]
        public void TestRicircoloChiuso()
        {
            Miscelatore m = new Miscelatore(12.600, 12, 20, 30, 50, 14000, 1.6, 1, 200, 300, 0);
            m.GestioneTemperature();
            m.GestioneUmidita();
            Assert.AreEqual(12,m.temperatura_finale);
            Assert.AreEqual(30,(int) m.umidita_finale);
        }
        [TestMethod]
        public void TestRicircoloAperto()
        {
            Miscelatore m = new Miscelatore(12.600, 12, 20, 30, 50, 14000, 1.6, 1, 200, 300, 1);
            m.GestioneTemperature();
            m.GestioneUmidita();
            Assert.IsTrue( m.temperatura_finale>12);
            Assert.IsTrue( m.umidita_finale>30);// da verificare se effettivamente aumenta
        }
    }
}
