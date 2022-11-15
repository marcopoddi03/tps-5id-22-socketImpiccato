using System;
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
            Console.WriteLine("Aspetto client...");
            server.Connect();
            server.SendMsg(parola.Length.ToString());
            Console.WriteLine("lunghezza parola inviata");
            Console.WriteLine("Aspetto lettere");
            //t1.Start();
            char[] arr=parola.ToCharArray();
            string par;
            string s;
            int k;
            while(true)
            {
                par = "";
                s = server.ReceiveMsg();
                par = par + Convert.ToChar(s.ToLower());
                Console.WriteLine("Controllo se la lettera è presente..");
                k = 0;
                foreach(char c in arr)
                {
                    if (c == Convert.ToChar(s.ToLower()))
                        par = par + k.ToString();
                    k++;
                }
                server.SendMsg(par);

            }

        }
    }
}
