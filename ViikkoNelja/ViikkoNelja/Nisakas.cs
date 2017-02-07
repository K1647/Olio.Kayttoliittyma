using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoNelja
{
    abstract class Nisakas
    {
        public int Ikä { get; set; }

        public Nisakas(int ikä)
        {
            Ikä = ikä;
        }

        public abstract string Liiku();
    }
    class Ihminen : Nisakas
    {

        public float Paino { get; set; }
        public float Pituus { get; set; }
        public string Nimi { get; set; }

        public Ihminen(string nimi, float paino, float pituus, int ikä)
            : base(ikä)
        {
            Paino = paino;
            Pituus = pituus;
            Nimi = nimi;
        }

        public override string Liiku()
        {
            return "liikun";
        }

        public void Kasva()
        {
            Ikä++;
        }
    }
    class Vauva : Ihminen
    {
        public string Vaippa { get; set; }

        public Vauva(string vaippa, string nimi, float paino, float pituus, int ikä)
            : base(nimi, paino, pituus, ikä)
        {
            Vaippa = vaippa;
        }

        public override string Liiku()
        {
            return "konttaan";
        }
    }
    class Aikuinen : Ihminen
    {
        public string Auto { get; set; }

        public Aikuinen(string auto, string nimi, float paino, float pituus, int ikä)
            : base(nimi, paino, pituus, ikä)
        {
            Auto = auto;
        }

        public override string Liiku()
        {
            return "kävelen";
        }
    }
}
