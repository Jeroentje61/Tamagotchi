﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tamagotchi_WCF.Spelregels
{
    public class Munchies : ISpelregel
    {
        public Tamagotchi ExecuteSpelregel(Tamagotchi tmg)
        {
            if (tmg.Boredom > 80)
            {
                //TODO
                //HUNGER x2
            }
            using (var context = new TmgContext())
            {
                context.Entry(tmg).State = EntityState.Modified;
                context.SaveChanges();
            }
            return tmg;
        }
    }
}