using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tamagotchi_WCF.Spelregels
{
    public class Honger : ISpelregel
    {
        public Tamagotchi ExecuteSpelregel(Tamagotchi tmg)
        {
            TimeSpan Difference = DateTime.Now - tmg.LastAcces;
            int HoursPassed = (int)Difference.TotalHours;
            tmg.Hunger += (HoursPassed * 5);
            if (tmg.Hunger >= 100) { tmg.Hunger = 100; Voedseltekort tekort = new Voedseltekort(); tmg = tekort.ExecuteSpelregel(tmg); }
            
            return tmg;
        }
    }
}