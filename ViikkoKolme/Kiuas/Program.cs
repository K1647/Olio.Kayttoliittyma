using JAMK.IT; //helpottaa meidän luokkien löytämistä
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ViikkoKolme
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestaaKius();
            //TestaaPesukone();
            //TestaaTelevisio();
            TestaaVehicle();  
            //TestaaTietokone();
        }

        //Tehtävä1 Kiuas-luokan testaus

        static void TestaaKius()
        {
            //luodaan kiuas olio
            Kiuas kiuas = new Kiuas();
            //pistetään kiuas läpenemään ja asetetaan lämpö&kosteutta
            kiuas.OnkoPäällä = true;
            kiuas.Lämpötila = 90;
            kiuas.Kosteus = 50;
            //näytetään konsolilla
            Console.WriteLine("Kiuas on päällä {0}", kiuas.OnkoPäällä);
            Console.WriteLine("Kiukaan lämpötila {0}", kiuas.Lämpötila);
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Kosteus);
            //mitä tapahtuu jos kosteus yli rajojen
            kiuas.Kosteus = 101;
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Kosteus);
        }

        static void TestaaPesukone()
        {
            //luodaan pesukone olio
            Pesukone pesukone = new Pesukone();
            //pistetään pesukone päälle, laitetaan pesun kesto&ohjelma
            pesukone.OnkoPäällä = true;
            pesukone.PesuAika = 90;
            pesukone.OnkoHanaAuki = true;
            //pesuohjelmia on 1 = Tehopesu 2 = Normaali 3 = Pikapesu
            pesukone.PesuOhjelma = "1";
            //näytetään konsolilla
            Console.WriteLine("Pesukone on päällä {0}", pesukone.OnkoPäällä);
            Console.WriteLine("Vesihana auki {0}", pesukone.OnkoHanaAuki);
            Console.WriteLine("Pesun kesto {0}min", pesukone.PesuAika);
            Console.WriteLine("Pesuohjelma on {0}", pesukone.PesuOhjelma);
        }
        static void TestaaTelevisio()
        {
            //luodaan televisio olio
            Televisio televisio = new Televisio();
            //pistetään televisio päälle
            televisio.OnkoPäällä = true;
            televisio.OnkoPiuhaKiinni = true;
            televisio.VoluumiTaso = 100;
            //tvkanavia tv1 = 1 tv2 = 2 mtv3 = 3 nelonen = 4 sub = 5
            televisio.TvKanva = "1";
            //näytetään konsolilla
            Console.WriteLine("Televisio on päällä {0}", televisio.OnkoPäällä);
            Console.WriteLine("Piuhat on kiinni {0}", televisio.OnkoPiuhaKiinni);
            Console.WriteLine("Voluumitaso {0}", televisio.VoluumiTaso);
            Console.WriteLine("TV-kanava on {0}", televisio.TvKanva);
        }

        static void TestaaVehicle()
        {
            Vehicle auto = new Vehicle("Toyoya", 190, 4);
            Vehicle auto2 = new Vehicle("Ford", 40, 2);

            auto.PrintData();
            auto2.PrintData();

        }

        static void TestaaTietokone()
        {
            Tietokone asus = new Tietokone(true, true, "Asus", "4core 4.2Ghz", "Asus GTX1080");
            Tietokone acer = new Tietokone(true, false, "Acer", "2core 2.2Ghz", "Potato");

            asus.PrintData();
            acer.PrintData();

        }
    }
}
