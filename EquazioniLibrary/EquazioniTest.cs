using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public static class EquazioniTest
    {
        public static int Fattoriale(int num)
        {
            int fattoriale=1;
            
            for(int i = num;i>0;i--)
            {
              fattoriale = fattoriale * i;
            }
            return fattoriale;
        }
    }
}
