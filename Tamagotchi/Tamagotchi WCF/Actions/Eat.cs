using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tamagotchi_WCF.Actions
{
    public class Eat : IAction
    {
        private int _timespan = 30;
        private string _message = "Je Tamagotchi is aan het eten. Dit duurt 30 seconden.";

        public Eat()
        {
            
        }

        public int TimeSpan
        {
            get { return _timespan; }
        }

        public string Act(Tamagotchi tmg)
        {
            //set cooldown op 30 seconden.
            //hunger wordt 0;
            using (var context = new TmgContext())
            {
                tmg.Hunger = 0;
                tmg.LastAcces = DateTime.Now;
                tmg.AccesGranted = DateTime.Now.AddSeconds(TimeSpan);
           
            }            
            
            return _message;
        }
    }
}