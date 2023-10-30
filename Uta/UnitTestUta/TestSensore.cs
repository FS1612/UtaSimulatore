using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using testUta.Sensori.Sensori_Analogici;

namespace UnitTestUta
{
    [TestClass]
    public class TestSensore
    {
        [TestMethod]
        public void TestAggiornamentoMisuraValoreConsentito()
        {
            SensoreAnalogico sensore = new SensoreAnalogico(-20, 80, 0.5, "produttore", "sensore analogico", "unita", "sensore", 12);
            sensore.aggiornaMisurazione();
            Assert.AreEqual(12.5, sensore.valoreAttuale," l'aggiornamento doveva essere di 0.5");
        }
        [TestMethod]
        public void TestAggiornamentoMisuraValoreSuperioreMassimo()
        {
            SensoreAnalogico sensore = new SensoreAnalogico(-20, 80, 0.5, "produttore", "sensore analogico", "unita", "sensore", 80);
            sensore.aggiornaMisurazione(); 
            Assert.AreEqual(79.5, sensore.valoreAttuale, " il valore supera il massimo consentito, non doveva aumentare");

        }
        [TestMethod]
        public void TestAggiornamentoMisuraValoreInferioreMinimo()
        {
            SensoreAnalogico sensore = new SensoreAnalogico(-20, 80, 0.5, "produttore", "sensore analogico", "unita", "sensore", -20);
            sensore.aggiornaMisurazione();
            Assert.AreEqual(-19.5, sensore.valoreAttuale, " doveva aumentare di 0.5 perchè non si può superare il valore minimo");
        }
        [TestMethod]
        public void TestResetSensore()
        {
            SensoreAnalogico sensore = new SensoreAnalogico(-20, 80, 0.5, "produttore", "sensore analogico", "unita", "sensore", -20);
            sensore.ResettaSensore();
            Assert.AreEqual(sensore.valoreAttuale,-20,"il sensore è stato resettato, i valori devono tornare alla base" );
            Assert.AreEqual(sensore.valoreVariazione,0,"il sensore è stato resettato, i valori devono tornare alla base" );
        }
    }
}
