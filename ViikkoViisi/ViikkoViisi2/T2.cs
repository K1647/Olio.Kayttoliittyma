using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoViisi2
{
    class T2
    {
        string Nimi { get; set; }
        double Hinta { get; set; }

        public T2(string nimi, double hinta)
        {
            Nimi = nimi;
            Hinta = hinta;
        }

        public string PrintData()
        {
            return "-Tuote : " + Nimi + " " + Hinta + "e";
        }
    }
}
