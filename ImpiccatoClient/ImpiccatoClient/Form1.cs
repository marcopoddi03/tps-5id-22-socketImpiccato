using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpiccatoClient
{
    public partial class Form1 : Form
    {
        SocketClient client;
        int lengthParola;
        Parola parola;
        Gioco fGioco;
        public Form1()
        {
            InitializeComponent();
            parola = new Parola(0);
            client =new SocketClient(ref parola);
        }

        private void btnInizia_Click(object sender, EventArgs e)
        {
            client.Connect();
            lengthParola = Convert.ToInt32(client.ReceiveWord());
            parola.l(lengthParola);
            fGioco = new Gioco(ref client, ref parola);
            fGioco.Show();
        }

    }
}
