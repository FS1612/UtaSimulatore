
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 607);
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
    }
}

