using System;
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
                tmg.TopAtleet = true;
            }
            else
            {
                tmg.TopAtleet = false;
            }
         
            return tmg;
        }
    }
}