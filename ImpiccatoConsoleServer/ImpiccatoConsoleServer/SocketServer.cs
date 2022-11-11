using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ImpiccatoConsoleServer
{
    public class SocketServer
    {
        bool connected;
        Socket handler;
        public SocketServer()
        {
            connected = false;
        }

        public bool Conn()
        {
            return connected;
        }
        public void Connect()
        {
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);
            Socket listener = new Socket(ipAddress.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp);
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);
                handler = listener.Accept();
                connected = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void SendMsg(string s)
        {
            byte[] msg = Encoding.ASCII.GetBytes(s);
            handler.Send(msg);
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
                    int bytesRec = handler.Receive(bytes);

                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    
                    if (data.IndexOf("<EOF>") > -1)
                    {
                        break;
                    }

                }
                Console.WriteLine("Lettera ricevuta: " + data.Substring(0, data.Length - 4));
            }
        }
    }
}
