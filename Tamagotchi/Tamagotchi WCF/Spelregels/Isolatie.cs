using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tamagotchi_WCF.Spelregels
{
    public class Isolatie : ISpelregel
    {
        public Tamagotchi ExecuteSpelregel(Tamagotchi tmg)
        {
            TimeSpan Difference = DateTime.Now - tmg.LastAcces;
            int HoursPassed = (int)Difference.TotalHours;
            tmg.Health += (HoursPassed * 5);
            Topatleet rule = new Topatleet();
            rule.ExecuteSpelregel(tmg);
            if (tmg.Health >= 100) { tmg.Health = 100; Crazy crazy = new Crazy(); tmg = crazy.ExecuteSpelregel(tmg); }
            
            return tmg;
        }
    }
}