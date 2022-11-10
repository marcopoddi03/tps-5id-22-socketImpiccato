using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;


namespace ImpiccatoClient
{
    public class SocketClient
    {
        Socket sender;
        bool connected;
        string connectedTo;

        public SocketClient()
        {
            connected = false;
        }
        public void Connect()
        {
            IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, 5000);
            sender = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);
            try
            {
                sender.Connect(remoteEP);
                connected = true;
                connectedTo = sender.RemoteEndPoint.ToString();
                MessageBox.Show("CONNESSO AL SERVER!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void SendMsg(string s)
        {
            byte[] msg = Encoding.ASCII.GetBytes(s);
            int bytesSent = sender.Send(msg);
        }

        public string ReceiveMsg()
        {
            string msgRec;
            //while (true)
           // { 
                byte[] bytes = new byte[1024];
                int bytesRec = sender.Receive(bytes);
                msgRec="Echoed test = {0}" +
                Encoding.ASCII.GetString(bytes, 0, bytesRec);

           // }
           return msgRec;
        }

    }
}