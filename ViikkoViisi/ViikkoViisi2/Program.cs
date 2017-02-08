using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoViisi2
{
    interface ICalculator
    {
        int Add(int number1, int number2);
        int Multiply(int number1, int number2);
        int Division(int number1, int number2);
        int Reduction(int number1, int number2);
    }
    public class Calculator : ICalculator
    {

        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        public int Multiply(int n1, int n2)
        {
            return n1*n2;
        }
        public int Division(int n1, int n2)
        {
            return n1/n2;
        }
        public int Reduction(int n1, int n2)
        {
            return n1 - n2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //TestaaNoppa();
            //Tehtava2();
            //Tehtava3();
            Tehtava5();
        }
        static void TestaaNoppa()
        {
            int maara;
            T1 noppa = new T1();
            Console.Write("Monta keraa noppaa heitetään: ");
            maara = int.Parse(Console.ReadLine());

            for (int i = 0; i < maara; i++)
            {
                noppa.Heita();
            }

            Console.WriteLine("Heitit {0} kertaa noppaa. Keskiarvo on: {1}", maara, noppa.Keskiarvo());
            noppa.lista.Sort();

            var apu = noppa.lista.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

            foreach (var b in apu)
            {
                Console.WriteLine("- {0} luku tuli näin monta kertaa {1}", b.Key, b.Value);
            }
        }
        static void Tehtava2()
        {
            List<T2> tuote = new List<T2>();
            tuote.Add(new T2("Karhu III", 1.3));
            tuote.Add(new T2("Maito", 1.2));
            tuote.Add(new T2("Sipsit", 2.6));
            tuote.Add(new T2("Jäätelö", 0.9));
            tuote.Add(new T2("Makarooni", 0.15));
            tuote.Add(new T2("Karhu 24-Pack", 26.2));

            Console.WriteLine("Tuotteet korissa: ");
            foreach (T2 x in tuote)
            {
                Console.WriteLine(x.PrintData());
            }

        }
        static void Tehtava3()
        {
            List<Alkio> kalamies = new List<Alkio>();
            List<Alkio> kalamies2 = new List<Alkio>();
            try
            {
                kalamies.Add(new Kala("Hauki", 50, 6));
                kalamies.Add(new Kala("Ahven", 12, 0.7));
                kalamies.Add(new Kala("Särki", 10, 0.6));
                kalamies.Add(new Kalastaja("Esko", "0409636241"));
                kalamies.Add(new Kalapaikka("Jyväsjärvi", "Jyväskylä"));

                kalamies2.Add(new Kala("Siika", 40, 2));
                kalamies2.Add(new Kala("Ahven", 18, 1.5));
                kalamies2.Add(new Kala("Särki", 11, 0.7));
                kalamies2.Add(new Kalastaja("Tauno", "0509112221"));
                kalamies2.Add(new Kalapaikka("Vähäjärvi", "Alavus"));

                foreach (Alkio a in kalamies)
                {
                    Console.WriteLine(a.ToString());
                }
                Console.WriteLine("\n/*************************************/\n");
                foreach (Alkio b in kalamies2)
                {
                    Console.WriteLine(b.ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        static void Tehtava5()
        {
             try
            {
                double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
                Console.WriteLine("Sum: " + ArrayCalcs.Sum(array));
                Console.WriteLine("Ave: " + Math.Round(ArrayCalcs.Average(array),2));
                Console.WriteLine("Min: " + ArrayCalcs.Min(array));
                Console.WriteLine("Max: " + ArrayCalcs.Max(array));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
