using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }
        public override string ToString()
        {
            return "\n Nimi: " + Name + " | Nopeus: " + Speed + " | Renkaat: " + Tyres;
        }
        public Vehicle(string nimi, int nopeus, int renkaat)
        {
            Name = nimi;
            Speed = nopeus;
            Tyres = renkaat;
        }

        public void PrintData()
        {
            Console.WriteLine(ToString());
        }
    }
}
