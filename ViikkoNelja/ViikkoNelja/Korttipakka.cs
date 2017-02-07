using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoNelja
{
    class Kortit
    {
        public List<Kortti> korttipakka = new List<Kortti>();
        public Kortit()
        {
        }
        public List<Kortti> Korttipakka()
        {
            for (int i = 1; i < 14; i++)
            {
                korttipakka.Add(new Kortti("Pata", i));
            }
            for (int i = 1; i < 14; i++)
            {
                korttipakka.Add(new Kortti("Hertta", i));
            }
            for (int i = 1; i < 14; i++)
            {
                korttipakka.Add(new Kortti("Ruutu", i));
            }
            for (int i = 1; i < 14; i++)
            {
                korttipakka.Add(new Kortti("Risti", i));
            }
            return korttipakka;
        }
        public List<Kortti> Sekoita()
        {
            int x = korttipakka.Count;
            Random rnd = new Random();
            while (x > 1)
            {
                int y = rnd.Next(0, x);
                x--;
                Kortti arvo = korttipakka[y];
                korttipakka[y] = korttipakka[x];
                korttipakka[x] = arvo;
            }
            return korttipakka;
        }
    }
    class Kortti
    {
        public string Maa { get; set; }
        public int Arvo { get; set; }
        public Kortti(string maa, int arvo)
        {
            Maa = maa;
            Arvo = arvo;
        }
        public string TulostaKortti()
        {
            return "- " + Maa + " " + Arvo;
        }
    }
}
