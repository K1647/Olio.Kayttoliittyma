using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava5
{
    class Program
    {
        static void Main(string[] args)
        {
            LisääOpiskelija();
        }
        public static void LisääOpiskelija()
        {
            int apu;
            Console.Write("Montaa opiskelijaa lisätään? > ");
            apu = Convert.ToInt32(System.Console.ReadLine());
            var opiskelijat = new List<Opiskelija> { };
            string nimi, luokka;
            int ikä;
            string input;
            for (int i = 0; i < apu; i++)
            {
                Console.Write("Syötä opiskelijan {0} nimi :", i + 1);
                nimi = Console.ReadLine();
                opiskelijat.Add(new Opiskelija(nimi));
                Console.Write("Syötä opiskelijan {0} ikä :", i + 1);
                input = Console.ReadLine();
                int.TryParse(input, out ikä);
                opiskelijat[i].Age = ikä;
                Console.Write("Syötä opiskelijan {0} luokka :", i + 1);
                luokka = Console.ReadLine();
                opiskelijat[i].Class = luokka;
                Console.Write("Syötä opiskelijan {0} aikasempi koulutus :", i + 1);
                opiskelijat[i].Education = Console.ReadLine();
            }
            foreach (Opiskelija op in opiskelijat)
            {
                Console.WriteLine("\n Nimi: {0} \n Ikä: {1} \n Koulutus: {2} \n Luokka: {3} \n", op.Name, op.Age, op.Education, op.Class);
            }
        }
    }
}
