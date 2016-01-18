using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tamagotchi_WCF.Spelregels
{
    public class Crazy : ISpelregel
    {
        public Tamagotchi ExecuteSpelregel(Tamagotchi tmg)
        {
            if (tmg.Health >= 100)
            {
                tmg.Crazy = true;
            }
            else
            {
                tmg.Crazy = false;
            }
          
            return tmg;
        }
    }
}