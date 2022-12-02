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
        Parola parola;

        public SocketClient(ref Parola parola)
        {
            connected = false;
            this.parola = parola;
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void SendMsg(string s)
        {
            byte[] msg = Encoding.ASCII.GetBytes(s+"<EOF>");
            int bytesSent = sender.Send(msg);
        }

        public string ReceiveWord()
        {
            string data;
            byte[] bytes = new byte[1024];
            data = "";
            while (true)
            {
                int bytesRec = sender.Receive(bytes);

                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);

                if (data.IndexOf("<EOF>") > -1)
                {
                    break;
                }

            }
            return data.Substring(0, data.Length - 5);
        }
        public void ReceiveMsg()
        {
            string data;
            byte[] bytes = new byte[1024];
            while (true)
            {
                data = "";
                while (true)
                {
                    int bytesRec = sender.Receive(bytes);

                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);

                    if (data.IndexOf("<EOF>") > -1)
                    {
                        break;
                    }

                }
                if (data.Substring(0, data.Length - 5) == "Ok")
                    parola.Indovinata = true;
                else if (data.Substring(0, data.Length - 5) != "No")                
                    parola.AggiornaParola(data.Substring(0, data.Length - 5));
                
            }
        }

        public void endSocket()
        {
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }

    }
}