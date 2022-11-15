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
       
        public string p()
        {
            string s = new string(parola);
            return s;
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
            for (int i=0;i<m.Length;i++)
            {
                if(i!=0)
                {
                    parola[Convert.ToInt32(m[i].ToString())] = m[0];
                }
            }
            MessageBox.Show("3");
            string o = new string(parola);
            MessageBox.Show(o);
        }
    }
    
}
