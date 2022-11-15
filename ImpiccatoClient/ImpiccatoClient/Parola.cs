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
        int nErrori;

        public Parola()
        {
            nErrori = 0;
        }
       
        public string p()
        {
            string s = new string(parola);
            return s;
        }
        public int e()
        {
            return nErrori;
        }
        public void l(int l)
        {
            length = l;
            parola = new char[length];
            for (int i = 0; i < length; i++)
            {
                parola[i] = '-';
            }
        }
        public void AggiornaParola(string s)
        {
            char[] m = s.ToCharArray();
            if (m.Length == 1)
                nErrori++;
            else
            {
                for (int i = 0; i < m.Length; i++)
                {
                    if (i != 0)
                    {
                        parola[Convert.ToInt32(m[i].ToString())] = m[0];
                    }
                }
            }            
        }
    }
    
}
