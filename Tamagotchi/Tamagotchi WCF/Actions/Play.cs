using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tamagotchi_WCF.Actions
{
    public class Play : IAction
    {
        private int _timespan = 30;
        private string _message = "Je Tamagotchi is aan het spelen. Dit duurt 30 seconden.";
        public int TimeSpan
        {
            get { return _timespan; }
        }

        public string Act(Tamagotchi tmg, out Tamagotchi tamg)
        {
            //set cooldown op 30 seconden.
            //boredom - 10;
            using (var context = new TmgContext())
            {
                tmg.Boredom -= 10;
                if (tmg.Boredom < 0) tmg.Boredom = 0;
                if (tmg.Boredom <= 80) { Spelregels.Munchies munchies = new Spelregels.Munchies(); tmg = munchies.ExecuteSpelregel(tmg); }
                tmg.LastAcces = DateTime.Now;
                tmg.AccesGranted = DateTime.Now.AddSeconds(TimeSpan);              
            }
            tamg = tmg;
            return _message;
        }
    }
}