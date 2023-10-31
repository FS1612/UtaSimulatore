using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using testUta.Attuatori;

namespace UnitTestUta
{
    [TestClass]
    public class TestMotore
    {
        Motore m_noFineCorsa = new Motore("", "", "", "", "", 2000, -1, 0, 0, 0);
        Motore m_FineCorsa = new Motore("", "", "", "", "", 2000, 1, 150, 90, 150);
        [TestMethod]
        public void TestMotoreSpento()
        {
            
            Assert.AreEqual(0, m_noFineCorsa.attivato);
            Assert.AreEqual(0, m_noFineCorsa.velocitaAttuale);
            
        }
        [TestMethod]
        public void TestMotorePienoCarico()
        { 
            Assert.AreEqual(0, m_noFineCorsa.attivato);
            Assert.AreEqual(0, m_noFineCorsa.velocitaAttuale);
            m_noFineCorsa.velocitaRichiesta = 2000;
            m_noFineCorsa.attivato = 1;
            m_noFineCorsa.AvvioMotore();
            Assert.AreEqual(1, m_noFineCorsa.attivato);
            double velocita_Rad_Sec = (2000 * 2 * Math.PI)/60;
            Assert.AreEqual(velocita_Rad_Sec, m_noFineCorsa.CheckVelocita(2000));
            
            Assert.AreNotEqual(0, m_noFineCorsa.velocitaAttuale);

        }
        [TestMethod]
        public void TestMotoreCaricoSuperioreSoglia()
        {
            Assert.AreEqual(0, m_noFineCorsa.attivato);
            Assert.AreEqual(0, m_noFineCorsa.velocitaAttuale);
            m_noFineCorsa.velocitaRichiesta = 3000;
            m_noFineCorsa.attivato = 1;
            m_noFineCorsa.AvvioMotore();
            Assert.AreEqual(1, m_noFineCorsa.attivato);
            double velocita_Rad_Sec = (2000 * 2 * Math.PI) / 60;
            Assert.AreEqual(velocita_Rad_Sec, m_noFineCorsa.CheckVelocita(3000));
            Assert.AreNotEqual(0, m_noFineCorsa.velocitaAttuale);
        }
        [TestMethod]
        public void TestMotoreFineCorsa()
        {
        
            Assert.AreEqual(0, m_FineCorsa.attivato);
            Assert.AreEqual(0, m_FineCorsa.velocitaAttuale);
            m_FineCorsa.velocitaRichiesta = 2000;
            m_FineCorsa.attivato = 1;
            m_FineCorsa.posizioneRichiesta = 45;
            m_FineCorsa.AvvioMotore();
            Assert.AreEqual(1, m_FineCorsa.attivato);
            double velocita_Rad_Sec = (2000 * 2 * Math.PI) / 60;
            Assert.AreEqual(velocita_Rad_Sec, m_FineCorsa.CheckVelocita(3000));

            Assert.AreNotEqual(0, m_FineCorsa.posizioneAttuale);
        }
        
    }
}
