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
            string parola;
            Random rnd = new Random();
            bool gioco = true;
            StreamReader sr = new StreamReader("parole.txt");
            string line;
            Console.WriteLine("SERVER GIOCO DELL'IMPICCATO");
            Console.WriteLine("Aspetto client...");
            server.Connect();
            Console.WriteLine("Client connesso!");
            for (int i = 0; i < rnd.Next(1, 1000); i++)
            {
                line = sr.ReadLine();
            }
            parola = sr.ReadLine().ToUpper();            
            server.SendMsg(parola.Length.ToString());
            Console.WriteLine("Parola scelta e lunghezza parola inviata!" + parola);
            char[] arr=parola.ToCharArray();
            string par;
            string s;
            int k;
            while(gioco)
            {
                Console.WriteLine("\nAspetto lettera o parola...");
                par = "";
                s = server.ReceiveMsg();
                if(s.Length==1)
                {
                    par = par + Convert.ToChar(s.ToUpper());
                    Console.WriteLine("Controllo se la lettera " + par + " è presente...");
                    k = 0;
                    foreach (char c in arr)
                    {
                        if (c == Convert.ToChar(s.ToUpper()))
                            par = par + k.ToString();
                        k++;
                    }
                    server.SendMsg(par);
                    Console.WriteLine("Risultato mandato");
                }
                else
                {
                    if (s == "Exit1")
                    {
                        Console.WriteLine("Complimenti hai vinto! Arrivederci!\n");
                        gioco=false;
                    }
                    else if (s == "Exit0")
                    {
                        Console.WriteLine("Mi dispiace hai perso, la parola era " + parola+". Arrivederci!\n");
                        gioco = false;
                    }
                    else if(s.ToUpper()==parola)
                    {
                        Console.WriteLine("Controllo se la parola "+ s.ToUpper() +" è corretta...");
                        server.SendMsg("Ok");
                        Console.WriteLine("Risultato mandato");
                    }
                    else
                    {
                        Console.WriteLine("Controllo se la parola " + s.ToUpper() + " è corretta...");
                        server.SendMsg("No");
                        Console.WriteLine("Risultato mandato");
                    }
                    
                }           
            }
            server.endSocket();
        }
    }
}
