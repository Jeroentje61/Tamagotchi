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
                tmg.Munchies = true;
            }
            else
            {
                tmg.Munchies = false;
            }
           
            return tmg;
        }
    }
}