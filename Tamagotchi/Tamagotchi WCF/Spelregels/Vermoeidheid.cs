using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Tamagotchi_WCF.Spelregels
{
    public class Vermoeidheid : ISpelregel
    {
        public Tamagotchi ExecuteSpelregel(Tamagotchi tmg)
        {
            TimeSpan Difference = DateTime.Now - tmg.LastAcces;
            int HoursPassed = (int)Difference.TotalHours;
            tmg.Sleep += (HoursPassed * 5);
            if (tmg.Sleep >= 100) { tmg.Sleep = 100; Slaaptekort tekort = new Slaaptekort(); tmg = tekort.ExecuteSpelregel(tmg); }
       
            return tmg;
        }
    }
}