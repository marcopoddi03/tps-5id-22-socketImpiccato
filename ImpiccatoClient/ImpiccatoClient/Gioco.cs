using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;

namespace ImpiccatoClient
{
    public partial class Gioco : Form
    {
        SocketClient client;
        Parola parola;
        Thread t1;
        bool vincita;
        public Gioco(ref SocketClient client, ref Parola parola)
        {
            InitializeComponent();
            this.client = client;
            this.parola = parola;
            vincita = false;
            t1 = new Thread(new ThreadStart(client.ReceiveMsg));
            t1.Start();
            domUpLettera.SelectedIndex = 0;
        }

        private void btnInviaLett_Click(object sender, EventArgs e)
        {
            client.SendMsg(domUpLettera.SelectedItem.ToString());
            domUpLettera.Items.RemoveAt(domUpLettera.SelectedIndex);
            domUpLettera.DownButton();
        }

        private void FineGioco()
        {
            t1.Abort();
            timer1.Stop();
            DialogResult dialogResult;
            if (vincita)
            {
               dialogResult = MessageBox.Show("Hai vinto! Vuoi rigiocare?", "Fine partita", MessageBoxButtons.YesNo);
            }
            else
            {
                dialogResult = MessageBox.Show("Hai perso! Vuoi rigiocare?", "Fine partita", MessageBoxButtons.YesNo);
            }
            if (dialogResult == DialogResult.Yes)
            {
                client.SendMsg("Exit0");
                Application.Restart();
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int err;
            labelParola.Text = parola.p();
            if(parola.Indovinata)
            {
                vincita = true;
                FineGioco();                
            }
            err = parola.Errori + 1;
            if(err<10)
                pictureBox1.Image = Image.FromFile("./img/impiccato"+ err.ToString() + ".jpg");
            else
            {
                pictureBox1.Image = Image.FromFile("./img/impiccato" + err.ToString() + ".jpg");
                FineGioco();
            }
        }

        private void Gioco_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(vincita)
                client.SendMsg("Exit1");
            else
                client.SendMsg("Exit0");
            client.endSocket();
            Application.Exit();
        }

        private void btnInviaPar_Click(object sender, EventArgs e)
        {
            client.SendMsg(txtParola.Text);
        }
    }
}
