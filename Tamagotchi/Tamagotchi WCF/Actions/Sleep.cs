﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tamagotchi_WCF.Actions
{
    public class Sleep : IAction
    {
        private int _timespan = 3600;
        private string _message = "Je Tamagotchi is aan het slapen. Dit duurt 2 uur.";
        public int TimeSpan
        {
            get { return _timespan; }
        }

        public string Act(Tamagotchi tmg, out Tamagotchi tamg)
        {
            //set cooldown op 3600 seconden.
            //sleep wordt 0;
            using (var context = new TmgContext())
            {
                tmg.Sleep = 0;
                tmg.LastAcces = DateTime.Now;
                tmg.AccesGranted = DateTime.Now.AddHours(TimeSpan);
            
            }
            tamg = tmg;
            return _message;
        }
    }
}