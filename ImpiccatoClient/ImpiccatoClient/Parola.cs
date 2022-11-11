using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpiccatoClient
{
    public class Parola
    {
        int length;
        char[] parola;
        public Parola(int length)
        {
            parola = new char[length];
            this.length = length;
            for (int i = 0; i < length; i++)
                parola[i]= '-';
        }
        public string p()
        {
            string s = new string(parola);
            return s;
        }
        public void l(int lenght)
        {
            this.length = lenght;
        }
        public void AggiornaParola(string s)
        {
            char[] m = s.ToCharArray();
            for(int i=0;i<m.Length;i++)
            {
                if(i!=0)
                {
                    parola[m[i]] = m[0];
                }
            }
            string o = new string(parola);
            MessageBox.Show(o);
        }
    }
    
}
