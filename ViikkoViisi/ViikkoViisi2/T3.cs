using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoViisi2
{
    abstract class Alkio
    {
        public string Nimi { get; set; }
    }
    class Kalastaja : Alkio
    {   
        public string PuhNro { get; set; }

        public Kalastaja(string nimi, string puhelin)
        {
            Nimi = nimi;
            PuhNro = puhelin;
        }
        public override string ToString()
        {
            return Nimi + ", " + PuhNro;
        }
    }
    class Kala : Alkio
    {
        public float Pituus { get; set; }
        public double Paino { get; set; }

        public Kala(string nimi, float pituus, double paino)
        {
            Nimi = nimi;
            Pituus = pituus;
            Paino = paino;
        }

        public override string ToString()
        {
            return Nimi + ", " + Pituus + "cm, " + Paino + "kg";
        }
    }
    class Kalapaikka : Alkio
    {
        public string Paikka { get; set; }

        public Kalapaikka(string nimi, string paikka)
        {
            Nimi = nimi;
            Paikka = paikka;
        }

        public override string ToString()
        {
            return Nimi + ", " + Paikka;
        }
    }
}
