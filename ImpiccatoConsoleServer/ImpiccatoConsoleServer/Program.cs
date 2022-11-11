using System;

namespace ImpiccatoConsoleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            string parola = "ciao";
            Random rnd = new Random();
            /*StreamReader sr = new StreamReader("parole.txt");
            string line;
            for (int i = 0; i < rnd.Next(1, 1000); i++)
            {
                line = sr.ReadLine();
            }
            parola = sr.ReadLine();*/
            Console.WriteLine(parola + parola.Length);
            SocketServer server = new SocketServer();
            server.Connect();
            server.SendMsg(parola.Length.ToString());
            Console.WriteLine("lunghezza parola inviata");
            Console.ReadLine();
        }
    }
}
