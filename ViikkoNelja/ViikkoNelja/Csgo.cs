using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoNelja
{
    abstract class Default
    {
        public string Ase { get; set; }
        public string Puukko { get; set; }
        public Default(string ase, string puukko)
        {
            Ase = ase;
            Puukko = puukko;
        }
        public abstract string AFK();
    }
    class Pelaaja : Default
    {
        public int Elämä { get; set; }
        public Pelaaja(int elämä, string ase, string puukko)
            : base(ase, puukko)
        {
            Elämä = elämä;
        }
        public override string AFK()
        {
            return " AFKAA TAAS";
        }

    }
    class CounterT : Pelaaja
    {
        public string Name { get; set; }

        public CounterT(string nimi, int elämä, string ase, string puukko)
            : base(elämä, ase, puukko)
        {
            Name = nimi;
        }
        public override string AFK()
        {
            return Name + " AFKAA TAAS CT:SSÄ";
        }
        public override string ToString()
        {
            return "Pelaaja " + Name + " " + Elämä + "hp " + Ase + " ja puukko " + Puukko;
        }
    }
    class Terrorist : Pelaaja
    {
        public string Name { get; set; }

        public Terrorist(string nimi, int elämä, string ase, string puukko)
            : base(elämä, ase, puukko)
        {
            Name = nimi;
        }
        public override string AFK()
        {
            return Name + " AFKAA TAAS T:SSÄ";
        }
        public override string ToString()
        {
            return "Pelaaja " + Name + " " + Elämä + "hp " + Ase + " ja puukko " + Puukko;
        }
    }
}
