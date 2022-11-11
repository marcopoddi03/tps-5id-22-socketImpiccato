﻿using System;
using System.IO;
using System.Threading;

namespace ImpiccatoConsoleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            SocketServer server = new SocketServer();
            Thread t1;
            //t1 = new Thread(new ThreadStart(server.ReceiveMsg));
            string parola;
            Random rnd = new Random();
            StreamReader sr = new StreamReader("parole.txt");
            string line;
            for (int i = 0; i < rnd.Next(1, 1000); i++)
            {
                line = sr.ReadLine();
            }
            parola = sr.ReadLine();
            Console.WriteLine("parola scelta: "+ parola);
            server.Connect();
            server.SendMsg(parola.Length.ToString());
            Console.WriteLine("lunghezza parola inviata");
            Console.WriteLine("Aspetto lettere");
            //t1.Start();
            string s;
            while(true)
            {
                s = server.ReceiveMsg();
                Console.WriteLine("Controllo se la lettera è presente..");
                if (parola.Contains(Convert.ToChar(s.ToLower())))
                {
                    Console.WriteLine("Presente");
                    server.SendMsg("1");
                }
                else
                {
                    Console.WriteLine("Non presente");
                    server.SendMsg("2");
                }

            }

        }
    }
}
