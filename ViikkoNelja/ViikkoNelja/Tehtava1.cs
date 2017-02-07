using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoNelja
{
    class Rengas
    {
        public string Valmistaja { get; set; }
        public string Malli { get; set; }
        public string RengasKoko { get; set; }
        public Rengas()
        {
        }
        public Rengas(string valmistaja, string malli, string rengaskoko)
        {
            Valmistaja = valmistaja;
            Malli = malli;
            RengasKoko = rengaskoko;
        }
        public override string ToString()
        {
            return "Valmistaja: " + Valmistaja + " Malli:" + Malli + " rengas koko:" + RengasKoko;
        }
    }
    class Auto
    {
        public string Merkki { get; set; }
        public string AutoMalli { get; set; }
        public int RenkaidenLkm { get; }
        public List<Rengas> Renkaat { get; }
        private int lkmRenkaat = 0;
        private const int maxRenkaat = 4;
        public Auto()
        {
            Renkaat = new List<Rengas>();
        }

        public void LisääRengas(Rengas rengas)
        {
            if (lkmRenkaat < maxRenkaat)
            {
                Renkaat.Add(rengas);
                lkmRenkaat++;
                Console.WriteLine("Rengas {0} lisätty ajoneuvoon {1}", rengas.Malli, Merkki);
            }
            else
            {
                Console.WriteLine("No room for a new tyres..., sorry!");
            }
        }
        public override string ToString()
        {
            string s = "Pirssissä: " + Merkki + " malli:" + AutoMalli + "\nrenkaat:";
            foreach (Rengas r in Renkaat)
            {
                if (r != null) s += "\n-" + r.ToString();
            }
            return s;
        }
    }
}
