using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tamagotchi_WCF.Spelregels
{
    public class Slaaptekort : ISpelregel
    {
        public Tamagotchi ExecuteSpelregel(Tamagotchi tmg)
        {
            if (tmg.Sleep >= 100)
            {
                tmg.Alive = false;
            }
           
            return tmg;
        }


    }
}