using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoKolme2
{
    class Hissi
    {
        int kerros;
        public int Kerros
        {
            get { return kerros; }
            set
            {
                
                if (value < 1)
                {
                    kerros = 1;
                }
                else if (value > 5)
                {
                    kerros = 5;
                }
                else
                {
                    kerros = value;
                }
            }
        }
    }
}
