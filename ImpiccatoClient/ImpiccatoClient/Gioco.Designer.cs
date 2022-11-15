namespace ImpiccatoClient
{
    partial class Gioco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnInviaLett = new System.Windows.Forms.Button();
            this.domUpLettera = new System.Windows.Forms.DomainUpDown();
            this.labelParola = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelErrori = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInviaLett
            // 
            this.btnInviaLett.Location = new System.Drawing.Point(441, 131);
            this.btnInviaLett.Name = "btnInviaLett";
            this.btnInviaLett.Size = new System.Drawing.Size(75, 36);
            this.btnInviaLett.TabIndex = 5;
            this.btnInviaLett.Text = "INVIA";
            this.btnInviaLett.UseVisualStyleBackColor = true;
            this.btnInviaLett.Click += new System.EventHandler(this.btnInviaLett_Click);
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
            this.domUpLettera.Location = new System.Drawing.Point(460, 103);
            this.domUpLettera.Name = "domUpLettera";
            this.domUpLettera.ReadOnly = true;
            this.domUpLettera.Size = new System.Drawing.Size(56, 20);
            this.domUpLettera.TabIndex = 4;
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParola.Location = new System.Drawing.Point(172, 103);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(70, 25);
            this.labelParola.TabIndex = 6;
            this.labelParola.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelErrori
            // 
            this.labelErrori.AutoSize = true;
            this.labelErrori.Location = new System.Drawing.Point(369, 198);
            this.labelErrori.Name = "labelErrori";
            this.labelErrori.Size = new System.Drawing.Size(13, 13);
            this.labelErrori.TabIndex = 7;
            this.labelErrori.Text = "0";
            // 
            // Gioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 264);
            this.Controls.Add(this.labelErrori);
            this.Controls.Add(this.labelParola);
            this.Controls.Add(this.btnInviaLett);
            this.Controls.Add(this.domUpLettera);
            this.Name = "Gioco";
            this.Text = "Gioco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInviaLett;
        private System.Windows.Forms.DomainUpDown domUpLettera;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelErrori;
    }
}