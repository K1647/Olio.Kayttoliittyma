using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Pesukone
    {
        public bool OnkoPäällä { get; set; }
        public bool OnkoHanaAuki { get; set; }
        public float Lämpötila { get; set; }
        //pesuaika voi olla välillä 30-120min
        float pesuaika;
        string pesuohjelma;
        public float PesuAika
        {
            get { return pesuaika; }
            set
            {
                pesuaika = value;
                if (pesuaika < 30 || pesuaika > 120)
                {
                    pesuaika = 0;
                }
            }
        }
        //pesuohjelman voi valita kolmesta
        public string PesuOhjelma
        {
            get { return pesuohjelma; }
            set
            {
                pesuohjelma = value;
                int x = Convert.ToInt32(pesuohjelma);
                switch (x)
                {
                    case 1: pesuohjelma = "Tehopesu";
                        break;
                    case 2: pesuohjelma = "Normaali";
                        break;
                    case 3: pesuohjelma = "Pikapesu";
                        break;
                    default: pesuohjelma = "Et valinnut ohjelmaa";
                        break;
                }
            }
        }
    }
}
