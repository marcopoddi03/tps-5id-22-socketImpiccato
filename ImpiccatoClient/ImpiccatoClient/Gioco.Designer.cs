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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnInviaPar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInviaLett
            // 
            this.btnInviaLett.Location = new System.Drawing.Point(408, 144);
            this.btnInviaLett.Name = "btnInviaLett";
            this.btnInviaLett.Size = new System.Drawing.Size(71, 24);
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
            this.domUpLettera.Location = new System.Drawing.Point(408, 118);
            this.domUpLettera.Name = "domUpLettera";
            this.domUpLettera.ReadOnly = true;
            this.domUpLettera.Size = new System.Drawing.Size(71, 20);
            this.domUpLettera.TabIndex = 4;
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParola.Location = new System.Drawing.Point(75, 144);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(115, 37);
            this.labelParola.TabIndex = 6;
            this.labelParola.Text = "PAROLA";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(532, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 214);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "GIOCO DELL\'IMPICCATO";
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(355, 201);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(124, 20);
            this.txtParola.TabIndex = 10;
            // 
            // btnInviaPar
            // 
            this.btnInviaPar.Location = new System.Drawing.Point(408, 227);
            this.btnInviaPar.Name = "btnInviaPar";
            this.btnInviaPar.Size = new System.Drawing.Size(71, 23);
            this.btnInviaPar.TabIndex = 11;
            this.btnInviaPar.Text = "INVIA";
            this.btnInviaPar.UseVisualStyleBackColor = true;
            this.btnInviaPar.Click += new System.EventHandler(this.btnInviaPar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // Gioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(658, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInviaPar);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelParola);
            this.Controls.Add(this.btnInviaLett);
            this.Controls.Add(this.domUpLettera);
            this.Name = "Gioco";
            this.Text = "Gioco";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gioco_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInviaLett;
        private System.Windows.Forms.DomainUpDown domUpLettera;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnInviaPar;
        private System.Windows.Forms.Label label1;
    }
}