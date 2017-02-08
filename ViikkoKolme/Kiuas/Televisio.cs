using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Televisio
    {
        public bool OnkoPäällä { get; set; }
        public bool OnkoPiuhaKiinni { get; set; }
        public float VoluumiTaso { get; set; }
        //pesuaika voi olla välillä 30-120min
        string tvkanava;

        //pesuohjelman voi valita kolmesta
        public string TvKanva
        {
            get { return tvkanava; }
            set
            {
                tvkanava = value;
                int x = Convert.ToInt32(tvkanava);
                switch (x)
                {
                    case 1:
                        tvkanava = "TV1";
                        break;
                    case 2:
                        tvkanava = "TV2";
                        break;
                    case 3:
                        tvkanava = "MTV3";
                        break;
                    case 4:
                        tvkanava = "Nelonen";
                        break;
                    case 5:
                        tvkanava = "Sub";
                        break;
                    default:
                        tvkanava = "Et valinnut kanavaa";
                        break;
                }
            }
        }
    }
}
