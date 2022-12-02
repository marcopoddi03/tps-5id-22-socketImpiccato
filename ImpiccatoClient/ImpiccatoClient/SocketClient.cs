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
        string connectedTo;
        Parola parola;

        public SocketClient(ref Parola parola)
        {
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
                connectedTo = sender.RemoteEndPoint.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public string ConnTo()
        {
            return connectedTo;
        }
        public void SendMsg(string s)
        {
            try
            {
                byte[] msg = Encoding.ASCII.GetBytes(s + "<EOF>");
                int bytesSent = sender.Send(msg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }            
        }

        public string ReceiveWord()
        {
            string data;
            byte[] bytes = new byte[1024];
            data = "";
            while (true)
            {
                try
                {
                    int bytesRec = sender.Receive(bytes);

                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);

                    if (data.IndexOf("<EOF>") > -1)
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
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
                    try
                    {
                        int bytesRec = sender.Receive(bytes);

                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);

                        if (data.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }                   

                }
                if (data.Substring(0, data.Length - 5) == "Ok")
                    parola.Indovinata = true;
                else if (data.Substring(0, data.Length - 5) == "No")
                    parola.Errori++;
                else
                    parola.AggiornaParola(data.Substring(0, data.Length - 5));
                
            }
        }

        public void endSocket()
        {
            try
            {
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }            
        }

    }
}