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
        bool indovinata;

        public Parola()
        {
            nErrori = 0;
            indovinata = false;
        }
       
        public string p()
        {
            string s = new string(parola);
            return s;
        }
        public int Errori
        {
            get { return nErrori; }
            set { nErrori = value; }
        }
        public bool Indovinata
        {
            get { return indovinata; }
            set { indovinata = value; }     
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
                if (!parola.Contains('-'))
                    indovinata = true;
            }
        }
    }
    
}
