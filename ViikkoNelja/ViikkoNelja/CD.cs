
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoNelja
{
    class CD
    {
        public List<string> Kappaleet = new List<string>();
        public string Albumi { get; set; }
        public string Artisti { get; set; }

        public CD(string albumi, string artisti)
        {
            Albumi = albumi;
            Artisti = artisti;
        }
        public void LisaaKappale(string kappale, string kesto)
        {
            string s = "- " + kappale + ", " + kesto;
            Kappaleet.Add(s);
        }
        string TulostaKappaleet()
        {
            string apu = "";
            for (int i = 0; i < Kappaleet.Count; i++)
            {
                apu += " " + Kappaleet[i] + "\n";
            }
            return apu;
        }
        public string TulostaCD()
        {
            return "CD:n data:\n" + "- Albumi: " + Albumi + "\n- Artisti: " + Artisti + "\n- Kappaleet:\n" + TulostaKappaleet();
        }
    }
}
