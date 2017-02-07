using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoNelja
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestaaAutolleRenkaat();
            //TestaaJaakaappi();
            //TestaaNisakas();
            //TestaaCs();
            //TestaaHenkRek();
            //TestaaCD();
            TestaaPakka();
        }
        static void TestaaPakka()
        {
            Kortit pakka = new Kortit();
            pakka.Korttipakka();
            Console.WriteLine("Pakan kortit:");
            for (int i = 0; i < pakka.korttipakka.Count; i++)
            {
                Console.WriteLine(pakka.korttipakka[i].TulostaKortti());
            }
            pakka.Sekoita();
            Console.WriteLine("Pakka on nyt sekoitettu:");
            for (int i = 0; i < pakka.korttipakka.Count; i++)
            {
                Console.WriteLine(pakka.korttipakka[i].TulostaKortti());
            }
        }
        static void TestaaHenkRek()
        {
            //muutama testihenkilö
            Henkilot poppoo = new Henkilot();
            Henkilo hlo = new Henkilo { Etunimi = "Jack", Sukunimi = "Russel", Hetu = "051270-123A" };
            Henkilo hlo1 = new Henkilo { Etunimi = "Jack1", Sukunimi = "Russel1", Hetu = "011270-123B" };
            Henkilo hlo2 = new Henkilo { Etunimi = "Jack2", Sukunimi = "Russel2", Hetu = "111270-123C" };
            Henkilo hlo3 = new Henkilo { Etunimi = "Jack3", Sukunimi = "Russel3", Hetu = "211270-123D" };
            //lisätää henkilot poppooseen
            poppoo.LisaaHenkilo(hlo);
            poppoo.LisaaHenkilo(hlo1);
            poppoo.LisaaHenkilo(hlo2);
            poppoo.LisaaHenkilo(hlo3);
            //poppoo näytölle
            foreach (Henkilo h in poppoo.HenkiloLista)
            {
                Console.WriteLine("{0}", h.ToString());
            }
            //TODO kysy käyttäjältä hetu ja sitä vastaavaa henkilö haetaan
            Console.Write("\nAnna henkilön hetu jota haet > ");
            string s = Console.ReadLine();
            Console.WriteLine(poppoo.HaeHenkiloHetulla(s));
        }
        static void TestaaCD()
        {
            CD starinsight = new CD("Messera","Star Insight");
            starinsight.LisaaKappale("Limbo","3:38");
            starinsight.LisaaKappale("Emanuela", "3:53");
            starinsight.LisaaKappale("My Time Is Out", "3:31");
            starinsight.LisaaKappale("Night With Fever", "4:08");
            starinsight.LisaaKappale("Frozen Rose", "3:14");
            starinsight.LisaaKappale("Signs of Victory", "3:24");
            starinsight.LisaaKappale("Oath", "3:49");
            starinsight.LisaaKappale("Raven and Hell", "3:49");
            starinsight.LisaaKappale("Poem of Misery", "4:44");
            Console.WriteLine(starinsight.TulostaCD());
        }
        static void TestaaAutolleRenkaat()
        {
            // create tyre
            Rengas tyre1 = new Rengas { Valmistaja = "Nokia", Malli = "Hakkapeliitta", RengasKoko = "205R16" };
            // create a car
            Auto kaara = new Auto { Merkki = "Porsche", AutoMalli = "911" };
            Console.WriteLine("Luotu uusi pirssi {0} {1}", kaara.Merkki, kaara.AutoMalli);
            kaara.LisääRengas(tyre1);
            kaara.LisääRengas(tyre1);
            kaara.LisääRengas(tyre1);
            kaara.LisääRengas(tyre1);
            Console.WriteLine(kaara.ToString());
        }
        static void TestaaJaakaappi()
        {
            Jaakaappi helkama = new Jaakaappi { Merkki = "Helkama" };
            KaappiSisalto kalja = new KaappiSisalto { Valmistaja = "Olvi", Tuote = "Keskiolut", Koko = 0.33 };
            KaappiSisalto parisevaa = new KaappiSisalto { Valmistaja = "Euroshopper", Tuote = "Energy Drink", Koko = 0.5 };
            KaappiSisalto pizzaa = new KaappiSisalto { Valmistaja = "Saarioinen", Tuote = "Jauhelihapitsa" };
            Console.WriteLine("Jääkaapissa {0} ei ole mitään valon lisäksi", helkama.Merkki);
            helkama.LisääTarvike(kalja);
            helkama.LisääTarvike(kalja);
            helkama.LisääTarvike(kalja);
            helkama.LisääTarvike(kalja);
            helkama.LisääTarvike(kalja);
            helkama.LisääTarvike(parisevaa);
            helkama.LisääTarvike(parisevaa);
            helkama.LisääTarvike(pizzaa);
            helkama.LisääTarvike(pizzaa);
            Console.WriteLine(helkama.ToString());

        }
        static void TestaaNisakas()
        {
            Ihminen jaakko = new Ihminen("Jaakko", 75, 180, 21);
            Vauva enna = new Vauva("Libero", "Enna", 14,  60, 2);
            Aikuinen esko = new Aikuinen("BMW M3", "Esko", 90, 170, 59);

            Console.WriteLine("{0}n vaipan merkki on {1}, pituus on {2}, paino on {3} ja ikä on {4}", enna.Nimi, enna.Vaippa, enna.Pituus, enna.Paino, enna.Ikä);
            Console.WriteLine("{0}n auton merkki on {1}, hän on {2} vuotias, pituudelta {3} ja painoltaan {4}", esko.Nimi, esko.Auto, esko.Ikä, esko.Pituus, esko.Paino);
            Console.WriteLine("{0}n paino on {1}, pituus on {2} ja hän on {3} vuotias", jaakko.Nimi, jaakko.Paino, jaakko.Pituus, jaakko.Ikä);
            Console.WriteLine("{0} huutaa {1}", jaakko.Nimi, jaakko.Liiku());
            Console.WriteLine("{0} sanoo {1}", esko.Nimi, esko.Liiku());
            Console.WriteLine("{0} ei osaa vielä sanoa '{1}'", enna.Nimi, enna.Liiku());

        }
        static void TestaaCs()
        {
            CounterT allu = new CounterT("BOT allu", 100, "USP-S", "Default");
            CounterT taco = new CounterT("BOT TACO", 100, "USP-S", "Default");
            CounterT s1mple = new CounterT("BOT s1mple", 100, "P2000", "Default");
            CounterT flusha = new CounterT("BOT flusha", 100, "USP-S", "Default");
            CounterT pashabiceps = new CounterT("BOT pashabiceps", 100, "USP-S", "Default");
            Terrorist seized = new Terrorist("BOT seized", 100, "Glock", "Default");
            Terrorist guardian = new Terrorist("BOT GuardiaN", 100, "Glock", "Default");
            Terrorist jw = new Terrorist("BOT JW", 100, "Glock", "Default");
            Terrorist fallen = new Terrorist("BOT FalleN", 100, "Glock", "Default");
            Terrorist olof = new Terrorist("BOT olofmeister", 100, "Glock", "Default");
            Console.WriteLine("CT");
            Console.WriteLine(allu.ToString());
            Console.WriteLine(taco.ToString());
            Console.WriteLine(s1mple.ToString());
            Console.WriteLine(flusha.ToString());
            Console.WriteLine(pashabiceps.ToString());
            Console.WriteLine("T");
            Console.WriteLine(seized.ToString());
            Console.WriteLine(guardian.ToString());
            Console.WriteLine(jw.ToString());
            Console.WriteLine(fallen.ToString());
            Console.WriteLine(olof.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(allu.AFK());

        }
    }
}
