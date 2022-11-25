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
        public Gioco(ref SocketClient client, ref Parola parola)
        {
            InitializeComponent();
            this.client = client;
            this.parola = parola;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            int err;
            labelParola.Text = parola.p();
            err = parola.e() + 1;
            if(err<10)
                pictureBox1.Image = Image.FromFile("./img/impiccato"+ err.ToString() + ".jpg");
            else
            {
                pictureBox1.Image = Image.FromFile("./img/impiccato" + err.ToString() + ".jpg");
                MessageBox.Show("Hai perso!");                
                client.endSocket();
                timer1.Stop();
            }
        }

        private void Gioco_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.endSocket();
        }
    }
}
