using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tamagotchi_WCF.Spelregels
{
    public class Verveling : ISpelregel
    {
        public Tamagotchi ExecuteSpelregel(Tamagotchi tmg)
        {
            TimeSpan Difference = DateTime.Now - tmg.LastAcces;
            int HoursPassed = (int)Difference.TotalHours;
            tmg.Boredom += (HoursPassed * 15);
            if (tmg.Boredom >= 100) { tmg.Boredom = 100; }
            if (tmg.Boredom >= 80) { Munchies munchies = new Munchies(); tmg = munchies.ExecuteSpelregel(tmg); }
           
            return tmg;
        }
    }
}