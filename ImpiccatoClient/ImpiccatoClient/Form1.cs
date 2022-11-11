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

namespace ImpiccatoClient
{
    public partial class Form1 : Form
    {
        SocketClient client;
        Thread t1;
        int lengthParola;
        Parola parola;
        public Form1()
        {
            InitializeComponent();
            parola = new Parola(0);
            client =new SocketClient(ref parola);
            t1 = new Thread(new ThreadStart(client.ReceiveMsg));
        }

        private void btnInizia_Click(object sender, EventArgs e)
        {
            client.Connect();
            lengthParola = Convert.ToInt32(client.ReceiveWord());
            parola.l(lengthParola);
            label1.Text =parola.p();
            t1.Start();
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            client.SendMsg(domUpLettera.SelectedItem.ToString());
        }
    }
}
