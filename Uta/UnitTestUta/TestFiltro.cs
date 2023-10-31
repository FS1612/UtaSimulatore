using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using testUta.Elementi_Meccanici;

namespace UnitTestUta
{
    [TestClass]
    public class TestFiltro
    {
        Filtro f = new Filtro("", "", "", "", 100, 125, 0, 14000);
        [TestMethod]
        public void TestValorinelRange()
        {
            
            Assert.AreEqual(0, f.SensoreDigitale.valoreAttuale);
            //aggiungo c02
            f.Co2Iniziale = 200;
            f.Aggiorna();
            
            Assert.AreEqual(0, f.SensoreDigitale.valoreAttuale);

        }
        [TestMethod]
        public void TestValoreTroppoAlto()
        {
            
            f.Co2Iniziale = 2000000000;
            f.Aggiorna();
            
            Assert.AreEqual(1, f.SensoreDigitale.valoreAttuale);

        }
    }
}
