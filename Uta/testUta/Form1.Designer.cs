
namespace testUta
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textTAttuale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textAperturaValvola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPotenza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTempo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textFlusso = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textAggiornamento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textPIniziale = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textPAttuale = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textUAttuale = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textUiniziale = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textTemperaturaMandata = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textTempRipresa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textUmiditamandata = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textUmiditaRipresa = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textTAttuale
            // 
            this.textTAttuale.Location = new System.Drawing.Point(431, 95);
            this.textTAttuale.Name = "textTAttuale";
            this.textTAttuale.Size = new System.Drawing.Size(100, 20);
            this.textTAttuale.TabIndex = 0;
            this.textTAttuale.TextChanged += new System.EventHandler(this.textTAttuale_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tattuale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apertura Valvola";
            // 
            // textAperturaValvola
            // 
            this.textAperturaValvola.Location = new System.Drawing.Point(431, 137);
            this.textAperturaValvola.Name = "textAperturaValvola";
            this.textAperturaValvola.Size = new System.Drawing.Size(100, 20);
            this.textAperturaValvola.TabIndex = 2;
            this.textAperturaValvola.TextChanged += new System.EventHandler(this.textAperturaValvola_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Potenza Attuale";
            // 
            // textPotenza
            // 
            this.textPotenza.Location = new System.Drawing.Point(431, 181);
            this.textPotenza.Name = "textPotenza";
            this.textPotenza.Size = new System.Drawing.Size(100, 20);
            this.textPotenza.TabIndex = 4;
            this.textPotenza.TextChanged += new System.EventHandler(this.textPotenza_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tempo di misurazione";
            // 
            // textTempo
            // 
            this.textTempo.Location = new System.Drawing.Point(431, 58);
            this.textTempo.Name = "textTempo";
            this.textTempo.Size = new System.Drawing.Size(100, 20);
            this.textTempo.TabIndex = 6;
            this.textTempo.TextChanged += new System.EventHandler(this.textTempo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Flusso Attuale";
            // 
            // textFlusso
            // 
            this.textFlusso.Location = new System.Drawing.Point(431, 217);
            this.textFlusso.Name = "textFlusso";
            this.textFlusso.Size = new System.Drawing.Size(100, 20);
            this.textFlusso.TabIndex = 8;
            this.textFlusso.TextChanged += new System.EventHandler(this.textFlusso_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aggiorna";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.aggiorna);
            // 
            // textAggiornamento
            // 
            this.textAggiornamento.Location = new System.Drawing.Point(677, 134);
            this.textAggiornamento.Name = "textAggiornamento";
            this.textAggiornamento.Size = new System.Drawing.Size(100, 20);
            this.textAggiornamento.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pressione Iniziale";
            // 
            // textPIniziale
            // 
            this.textPIniziale.Location = new System.Drawing.Point(431, 257);
            this.textPIniziale.Name = "textPIniziale";
            this.textPIniziale.Size = new System.Drawing.Size(100, 20);
            this.textPIniziale.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Pressione Attuale";
            // 
            // textPAttuale
            // 
            this.textPAttuale.Location = new System.Drawing.Point(431, 296);
            this.textPAttuale.Name = "textPAttuale";
            this.textPAttuale.Size = new System.Drawing.Size(100, 20);
            this.textPAttuale.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Umidita Attuale";
            // 
            // textUAttuale
            // 
            this.textUAttuale.Location = new System.Drawing.Point(431, 379);
            this.textUAttuale.Name = "textUAttuale";
            this.textUAttuale.Size = new System.Drawing.Size(100, 20);
            this.textUAttuale.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Umidita Iniziale";
            // 
            // textUiniziale
            // 
            this.textUiniziale.Location = new System.Drawing.Point(431, 340);
            this.textUiniziale.Name = "textUiniziale";
            this.textUiniziale.Size = new System.Drawing.Size(100, 20);
            this.textUiniziale.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(306, 543);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Temperatura Mandata";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textTemperaturaMandata
            // 
            this.textTemperaturaMandata.Location = new System.Drawing.Point(432, 536);
            this.textTemperaturaMandata.Name = "textTemperaturaMandata";
            this.textTemperaturaMandata.Size = new System.Drawing.Size(100, 20);
            this.textTemperaturaMandata.TabIndex = 26;
            this.textTemperaturaMandata.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(330, 504);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "temperatura ripresa";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textTempRipresa
            // 
            this.textTempRipresa.Location = new System.Drawing.Point(432, 497);
            this.textTempRipresa.Name = "textTempRipresa";
            this.textTempRipresa.Size = new System.Drawing.Size(100, 20);
            this.textTempRipresa.TabIndex = 24;
            this.textTempRipresa.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(330, 460);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Umidita mandata";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // textUmiditamandata
            // 
            this.textUmiditamandata.Location = new System.Drawing.Point(432, 453);
            this.textUmiditamandata.Name = "textUmiditamandata";
            this.textUmiditamandata.Size = new System.Drawing.Size(100, 20);
            this.textUmiditamandata.TabIndex = 22;
            this.textUmiditamandata.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(330, 421);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "umidita Ripresa";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // textUmiditaRipresa
            // 
            this.textUmiditaRipresa.Location = new System.Drawing.Point(432, 414);
            this.textUmiditaRipresa.Name = "textUmiditaRipresa";
            this.textUmiditaRipresa.Size = new System.Drawing.Size(100, 20);
            this.textUmiditaRipresa.TabIndex = 20;
            this.textUmiditaRipresa.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Aggiorna";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.aggiornaUmidita);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(551, 494);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Aggiorna";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.aggiornaTemperatura);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(677, 379);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Avvia";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.aggiornaAvviamento);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 607);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textTemperaturaMandata);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textTempRipresa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textUmiditamandata);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textUmiditaRipresa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textUAttuale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textUiniziale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textPAttuale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textPIniziale);
            this.Controls.Add(this.textAggiornamento);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textFlusso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textTempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPotenza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAperturaValvola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTAttuale);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTAttuale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAperturaValvola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPotenza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTempo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textFlusso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textAggiornamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPIniziale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPAttuale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textUAttuale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textUiniziale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textTemperaturaMandata;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textTempRipresa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textUmiditamandata;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textUmiditaRipresa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

