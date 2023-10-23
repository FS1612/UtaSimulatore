using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testUta
{
    public partial class Form1 : Form
    {
        double batteriaCalda_velocitaAcquaFreddo = Costanti.batteriaCalda_velocitaMassimaAcqua_Freddo;
        double batteriaCalda_velocitaAcquaCaldo = Costanti.batteriaCalda_velocitaMassimoAcqua_Caldo;
        double batteriaCalda_TemperaturaAcquaIngresso = Costanti.batteriaCalda_TemperaturaAcquaIngresso;
        double batteriaCalda_diametroValvola = Costanti.batteriaCalda_diametroValvola;
        double batteriaCalda_Area = Costanti.batteriaCalda_Area;
        double batteriaCalda_PerditaPressione = Costanti.batteriaCalda_PerditaPressione;
        double batteriaCalda_capacitaCaldo = Costanti.batteriaCalda_capacitaCaldo;
        double batteriaFredda_flussoFreddo = Costanti.batteriaFredda_flussoMassimo_Freddo;
        double batteriaFredda_velocitaAcquaFreddo = Costanti.batteriaFredda_velocitaMassimaAcqua_Freddo;
        double batteriaFredda_diametroValvola = Costanti.batteriaFredda_diametroValvola;
        double batteriaFredda_TemperaturaAcquaIngresso = Costanti.batteriaFredda_TemperaturaAcquaIngresso;
        double batteriaFredda_capacitaFreddo = Costanti.batteriaFredda_capacitaFreddo;
        Batteria bat;
        public Form1()
        {
            InitializeComponent();
             Valvola valv = new Valvola(0, 1, batteriaFredda_velocitaAcquaFreddo, batteriaFredda_TemperaturaAcquaIngresso, batteriaFredda_diametroValvola);
             bat = new Batteria(1, batteriaCalda_Area, 200, 20, 20, valv, batteriaCalda_PerditaPressione,batteriaFredda_capacitaFreddo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textFlusso_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPotenza_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAperturaValvola_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textTAttuale_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textTempo.Invoke((MethodInvoker)(() => textTempo.Text = 1000 + " ms")) ;
            textTAttuale.Invoke((MethodInvoker)(() => textTAttuale.Text = bat.Get_Temperatura_Finale().ToString())) ;
            textAperturaValvola.Invoke((MethodInvoker)(() => textAperturaValvola.Text = bat.Get_Valvola().Get_Apertura().ToString())) ;
            textPotenza.Invoke((MethodInvoker)(() => textPotenza.Text = bat.GetPotenza().ToString())) ;
            textFlusso.Invoke((MethodInvoker)(() => textFlusso.Text = bat.Get_Valvola().Get_Flusso_attuale().ToString())) ;
            textPIniziale.Invoke((MethodInvoker)(() => textPIniziale.Text = bat.Get_Pressione_Iniziale().ToString())) ;
            textUiniziale.Invoke((MethodInvoker)(() => textUiniziale.Text = bat.Get_Umidita_Iniziale().ToString())) ;
            textPAttuale.Invoke((MethodInvoker)(() => textPAttuale.Text = bat.Get_Pressione_Finale().ToString())) ;
            textUAttuale.Invoke((MethodInvoker)(() => textUAttuale.Text = bat.Get_Umidita_Finale().ToString())) ;
        }
        public void Aggiorna()
        {
            
        }

        private void aggiorna(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textAggiornamento.Text))
            {
                double apertura = double.Parse(textAggiornamento.Text);
                bat.Get_Valvola().Set_Apertura_valvola(apertura);
            }
            else
            {
                bat.Get_Valvola().Set_Apertura_valvola(0);
            }
        }
    }
}
