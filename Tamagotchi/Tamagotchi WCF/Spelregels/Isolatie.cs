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
            TimeSpan Difference = tmg.LastAcces - DateTime.Now;
            int HoursPassed = (int)Difference.TotalHours;
            tmg.Sleep += (HoursPassed * 5);
            tmg.LastAcces = DateTime.Now;
            using (var context = new TmgContext())
            {
                context.Entry(tmg).State = EntityState.Modified;
                context.SaveChanges();
            }
            return tmg;
        }
    }
}