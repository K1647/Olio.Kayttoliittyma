using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat
{
    class Vko2
    {
        //Toisen viikon tehtävät mahdollista käynnistää yhden paikasta
        public static void Main2()
        {
            //Tehtava1();
            //Tehtava2();
            //Tehtava3();
            //Tehtava4();
            //Tehtava5();
            //Tehtava6();
            //Tehtava7();
            //Tehtava8();
            //Tehtava9();
            //Tehtava10();
            //Tehtava11();
            //Tehtava12();
            //Tehtava13();
            //Tehtava14();
            //Tehtava15();
        }

        public static void Tehtava1()
        {
            //Alustetaan muuttujat
            int luku;
            string[] luvut= new string[4];
            Console.Write("Anna Luku > ");
            luku = int.Parse(Console.ReadLine());
            luvut[1] = "yksi";
            luvut[2] = "kaksi";
            luvut[3] = "kolme";

            //valintatapa toimimaan switchillä
            switch (luku)
            {
                case 1:
                    Console.WriteLine("Annoit luvun " + luvut[luku]);
                    break;
                case 2:
                    Console.WriteLine("Annoit luvun " + luvut[luku]);
                    break;
                case 3:
                    Console.WriteLine("Annoit luvun " + luvut[luku]);
                    break;
                default:
                    Console.WriteLine("Invalid number you have just given to software -Yoda");
                    break;
            }
            Console.ReadLine();
            //valmis
        }

        public static void Tehtava2()
        {
            int luku;
            Console.Write("Anna pistemaara > ");
            luku = int.Parse(Console.ReadLine());

            if (luku >= 0 && luku <= 1)
            {
                Console.WriteLine("Koulunumero on 0");
            }
            if (luku >= 2 && luku <= 3)
            {
                Console.WriteLine("Koulunumero on 1");
            }
            if (luku >= 4 && luku <= 5)
            {
                Console.WriteLine("Koulunumero on 2");
            }
            if (luku >= 6 && luku <= 7)
            {
                Console.WriteLine("Koulunumero on 3");
            }
            if (luku >= 8 && luku <= 9)
            {
                Console.WriteLine("Koulunumero on 4");
            }
            if (luku >= 10 && luku <= 12)
            {
                Console.WriteLine("Koulunumero on 5");
            }
            Console.Read();
        }

        public static void Tehtava3()
        {
            double luku, summa, keskiarvo;
            double[] luvut = new double[3];
            Console.Write("Anna kolme lukua joista saat summan ja keskiarvon > ");
            for (int apuluku = 0; apuluku <= 2; apuluku++)
            {
                luku = double.Parse(Console.ReadLine());
                luvut[apuluku] = luku;
            }
            summa = luvut[0] + luvut[1] + luvut[2];
            keskiarvo = (luvut[0] + luvut[1] + luvut[2]) / 3;
            Console.WriteLine("Antamien arvojen summa: " + summa + "\n" + 
                              "ja keskiarvo: " + keskiarvo);
            Console.Read();
            //valmis
        }

        public static void Tehtava4()
        {
            int luku;
            Console.Write("Anna ikasi > ");
            luku = int.Parse(Console.ReadLine());
            if (luku < 18)
            {
                Console.WriteLine("Alaikainen");
            }
            else if (luku >= 18 && luku <= 65)
            {
                Console.WriteLine("Aikuinen");
            }
            else
            {
                Console.WriteLine("Seniori");
            }
            Console.Read();
            //valmis
        }

        public static void Tehtava5()
        {
            double sekunnit;
            Console.Write("Anna sekunnit > ");
            sekunnit = double.Parse(Console.ReadLine());
            TimeSpan aika = TimeSpan.FromSeconds(sekunnit);
            string str = aika.ToString(@"hh\:mm\:ss\:fff");
            Console.WriteLine(" Antamasi sekunttiaika voidaan ilmaista muodossa: " + aika + " tunnit:minuutit:sekunnit");
            Console.Read();
            //valmis
        }

        public static void Tehtava6()
        {
            double matka, kulutus, hinta;
            Console.Write("Anna matka > ");
            matka = double.Parse(Console.ReadLine());
            kulutus = matka * 7.02 / 100;
            hinta = kulutus * 1.595;
            hinta = Math.Round(hinta, 2); //pyöristykset
            kulutus = Math.Round(kulutus, 2);
            Console.WriteLine("Bensaa kuluu " + kulutus + " litraa, " +
                              "kustannus " + hinta + " euroa");
            Console.Read(); //valmis
        }

        public static void Tehtava7()
        {
            int vuosi;
            Console.Write("Anna vuosi > ");
            vuosi = int.Parse(Console.ReadLine());
            if (vuosi % 4 == 0)
            {
                Console.WriteLine("Vuosi on karkausvuosi");
            }
            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi");
            }
            Console.Read();
            //valmis
        }

        public static void Tehtava8()
        {
            int luku;
            int[] luvut = new int[3];
            for (int i = 0; i <= 2; i++)
            {
                Console.Write("Anna luku > ");
                luku = int.Parse(Console.ReadLine());
                luvut[i] = luku;
            }
            int maxValue = luvut.Max();
            Console.WriteLine("Suurin luku on " + maxValue);
            Console.Read();
            //valmis
        }

        public static void Tehtava9()
        {
            var list = new List<int>();
            int luku;
            int i = 0, summa = 0;
            do
            {
                Console.Write("Anna luku > ");
                list.Add(luku = int.Parse(Console.ReadLine()));
            } while (luku != 0);
            int[] luvut = list.ToArray();
            for (int x = 0; x < luvut.Length; x++)
            {
                summa += luvut[x];
            }
            Console.WriteLine("Lukujen summa on " + summa);
            Console.Read();
            //valmis
        }

        public static void Tehtava10()
        {
            int[] luvut = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for (int i = 0; i <= luvut.Length - 1; i++)
            {
                if (luvut[i] % 2 == 0)
                {
                    Console.WriteLine("HEP");
                }
            }
            Console.Read();
            //valmis
        }

        public static void Tehtava11()
        {
            int luku, rivinro, sarakenro;
            Console.Write("Anna luku > ");
            luku = int.Parse(Console.ReadLine());

            for (rivinro = 1; rivinro <= luku; rivinro++)
            {
                for (sarakenro = 1; sarakenro <= rivinro; sarakenro++)
                {
                    if (rivinro == sarakenro)
                    {
                        Console.WriteLine(new string('*', rivinro));
                    }
                }
            }
            Console.Read();
            //valmis
        }

        public static void Tehtava12()
        {
            int luku;
            int[] luvut = new int[5];
            
            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Anna luku > ");
                luku = int.Parse(Console.ReadLine());
                luvut[i] = luku;
            }
            Console.Write("Luvut ovat ");
            for (int i = 4; i >= 0; i--)
            {
                if (i > 0)
                {
                    Console.Write(luvut[i] + ", ");
                }
                else
                {
                    Console.Write(luvut[i]);
                }
            }           
            Console.Read();
            //valmis
        }

        public static void Tehtava13()
        {
            int luku;
            int[] luvut = new int[5];
            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Anna luku > ");
                luku = int.Parse(Console.ReadLine());
                luvut[i] = luku;
            }
            int sum = luvut.Sum();
            int max = luvut.Max();
            int min = luvut.Min();
            sum = sum - (min + max);
            Console.WriteLine("Kokonaispisteet ovat " + sum);
            
            Console.Read();
            //valmis
        }

        public static void Tehtava14()
        {
            int luku;
            int[] luvut = new int[6];

            do
            {
                Console.Write("Anna luku > ");
                luku = int.Parse(Console.ReadLine());
                if (luku == 0)
                {
                    luvut[0] += 1;
                }
                else if (luku == 1)
                {
                    luvut[1] += 1;
                }
                else if (luku == 2)
                {
                    luvut[2] += 1;
                }
                else if (luku == 3)
                {
                    luvut[3] += 1;
                }
                else if (luku == 4)
                {
                    luvut[4] += 1;
                }
                else if (luku == 5)
                {
                    luvut[5] += 1;
                }
                else
                {
                    Console.WriteLine("Arvosanat:");
                }
            } while (luku <= 5);

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i + ":" + new string('*', luvut[i]));
            }

            Console.Read();
            //valmis
        }

        public static void Tehtava15()
        {
            int luku;
            Console.Write("Anna luku > ");
            luku = int.Parse(Console.ReadLine());

            for (int i = 0; i < luku-2; i++)
            {
                Console.WriteLine(new string(' ', luku-i) + new string('*', i+(i+1)));
                if (i == luku-3)
                {
                    Console.WriteLine(new string(' ', luku) + "*" + "\n" + new string(' ', luku) + "*");
                }
            }
         
            Console.Read();
            //valmis
        }
    }
}
