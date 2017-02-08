using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoKolme2
{
    class Vahvistin
    {
        int voltaso;
        public int Voluumi
        {
            get { return voltaso; }
            set
            {

                if (value < 0)
                {
                    voltaso = 0;
                }
                else if (value > 100)
                {
                    voltaso = 100;
                }
                else
                {
                    voltaso = value;
                }
            }
        }
    }
}
