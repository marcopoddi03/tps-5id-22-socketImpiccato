using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpiccatoClient
{
    public class Parola
    {
        int length;
        char[] parola;
        public Parola(int length)
        {
            this.length = length;
            for (int i = 0; i < length; i++)
                parola[i]= '-';
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
        }
    }
    
}
