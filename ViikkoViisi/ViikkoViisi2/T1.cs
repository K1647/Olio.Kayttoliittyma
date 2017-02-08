using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoViisi2
{
    class T1
    {
        public List<int> lista = new List<int>();
        int arvottuLuku;
        float summa = 0;
        float maara = 0;
        Random rand = new Random();

        public void Heita()
        {
            arvottuLuku = rand.Next(1, 7);
            summa += arvottuLuku;
            maara++;
            lista.Add(arvottuLuku);
        }

        public float Keskiarvo()
        {
            return summa / maara;
        }
    }
}
