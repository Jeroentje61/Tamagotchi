﻿using System;
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

        public string Act(Tamagotchi tmg)
        {
            //set cooldown op 30 seconden.
            //boredom - 10;
            using (var context = new TmgContext())
            {
                tmg.Boredom -= 10;
                if (tmg.Boredom < 0) tmg.Boredom = 0;
                tmg.LastAcces = DateTime.Now;
                tmg.AccesGranted = DateTime.Now.AddSeconds(30);
                context.Entry(tmg).State = EntityState.Modified;
                context.SaveChanges();
            }
            return _message;
        }
    }
}