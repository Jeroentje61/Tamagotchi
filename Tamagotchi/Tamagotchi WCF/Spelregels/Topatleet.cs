﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tamagotchi_WCF.Spelregels
{
    public class Topatleet : ISpelregel
    {
        public Tamagotchi ExecuteSpelregel(Tamagotchi tmg)
        {
            if (tmg.Health < 20)
            {
                //TODO
                //JE KAN NIET DOOD
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