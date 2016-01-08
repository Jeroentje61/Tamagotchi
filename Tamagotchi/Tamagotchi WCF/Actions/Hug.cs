using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tamagotchi_WCF.Actions
{
    public class Hug : IAction
    {
        private int _timespan = 60;
        private string _message = "Je Tamagotchi is aan het knuffelen. Dit duurt 60 seconden.";
        public int TimeSpan
        {
            get { return _timespan; }
        }

        public string Act(Tamagotchi tmg)
        {
            
            using (var context = new TmgContext())
            {
                tmg.Health -= 10;
                if (tmg.Health < 0) tmg.Health = 0;
                tmg.Crazy = false;
                tmg.LastAcces = DateTime.Now;
                tmg.AccesGranted = DateTime.Now.AddSeconds(60);
                context.Entry(tmg).State = EntityState.Modified;
                context.SaveChanges();
            }

            return _message;
        }
    }
}