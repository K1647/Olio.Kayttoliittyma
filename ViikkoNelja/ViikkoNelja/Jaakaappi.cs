using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoNelja
{
    class KaappiSisalto
    {
        public string Valmistaja { get; set; }
        public string Tuote { get; set; }
        public double Koko { get; set; }
        public KaappiSisalto()
        {
        }
        public KaappiSisalto(string valmistaja, string tuote, double koko)
        {
            Valmistaja = valmistaja;
            Tuote = tuote;
            Koko = koko;
        }
        public override string ToString()
        {
            return "Valmistaja: " + Valmistaja + " Tuote: " + Tuote + " Koko: " + Koko + "l";
        }
    }
    class Jaakaappi
    {
        public string Merkki { get; set; }
        public int TarvikkeidenLkm { get; }
        public List<KaappiSisalto> Tarvikkeet { get; }
        private int lkmTarvikkeet = 0;
        private const int maxTarvikkeet = 15;
        public Jaakaappi()
        {
            Tarvikkeet = new List<KaappiSisalto>();
        }

        public void LisääTarvike(KaappiSisalto tarvike)
        {
            if (lkmTarvikkeet < maxTarvikkeet)
            {
                Tarvikkeet.Add(tarvike);
                lkmTarvikkeet++;
                Console.WriteLine("Elintarvike {0} lisätty jääkaappiin {1}", tarvike.Tuote, Merkki);
            }
            else
            {
                Console.WriteLine("No room for a new supply..., sorry!");
            }
        }
        public override string ToString()
        {
            string s = "Jääkaapissa: " + Merkki + "\nelintarvikkeita: ";
            foreach (KaappiSisalto r in Tarvikkeet)
            {
                if (r != null) s += "\n-" + r.ToString();
            }
            return s;
        }
    }
}
