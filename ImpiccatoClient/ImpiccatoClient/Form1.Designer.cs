namespace ImpiccatoClient
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
            this.btnInizia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.domUpLettera = new System.Windows.Forms.DomainUpDown();
            this.btnInvia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInizia
            // 
            this.btnInizia.Location = new System.Drawing.Point(56, 33);
            this.btnInizia.Name = "btnInizia";
            this.btnInizia.Size = new System.Drawing.Size(118, 36);
            this.btnInizia.TabIndex = 0;
            this.btnInizia.Text = "INIZIA";
            this.btnInizia.UseVisualStyleBackColor = true;
            this.btnInizia.Click += new System.EventHandler(this.btnInizia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // domUpLettera
            // 
            this.domUpLettera.Items.Add("A");
            this.domUpLettera.Items.Add("B");
            this.domUpLettera.Items.Add("C");
            this.domUpLettera.Items.Add("D");
            this.domUpLettera.Items.Add("E");
            this.domUpLettera.Items.Add("F");
            this.domUpLettera.Items.Add("G");
            this.domUpLettera.Items.Add("H");
            this.domUpLettera.Items.Add("I");
            this.domUpLettera.Items.Add("J");
            this.domUpLettera.Items.Add("K");
            this.domUpLettera.Items.Add("L");
            this.domUpLettera.Items.Add("M");
            this.domUpLettera.Items.Add("N");
            this.domUpLettera.Items.Add("O");
            this.domUpLettera.Items.Add("P");
            this.domUpLettera.Items.Add("Q");
            this.domUpLettera.Items.Add("R");
            this.domUpLettera.Items.Add("S");
            this.domUpLettera.Items.Add("T");
            this.domUpLettera.Items.Add("U");
            this.domUpLettera.Items.Add("V");
            this.domUpLettera.Items.Add("W");
            this.domUpLettera.Items.Add("X");
            this.domUpLettera.Items.Add("Y");
            this.domUpLettera.Items.Add("Z");
            this.domUpLettera.Location = new System.Drawing.Point(358, 253);
            this.domUpLettera.Name = "domUpLettera";
            this.domUpLettera.Size = new System.Drawing.Size(56, 20);
            this.domUpLettera.TabIndex = 2;
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(430, 243);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(75, 36);
            this.btnInvia.TabIndex = 3;
            this.btnInvia.Text = "INVIA";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 336);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.domUpLettera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInizia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInizia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown domUpLettera;
        private System.Windows.Forms.Button btnInvia;
    }
}

