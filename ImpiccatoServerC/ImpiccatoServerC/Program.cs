using System.IO;

SocketServer server = new SocketServer();
server.Connect();
string parola;
Random rnd = new Random();
StreamReader sr = new StreamReader("parole.txt");
string line;
for(int i=0;i< rnd.Next(1, 1000);i++)
{
    line=sr.ReadLine();
}
parola = sr.ReadLine();
Console.WriteLine(parola + parola.Length);
server.SendMsg(parola.Length.ToString());
Console.WriteLine("lunghezza parola inviata");
