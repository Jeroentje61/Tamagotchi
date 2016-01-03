using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tamagotchi_WCF.Actions
{
    public class Workout : IAction
    {
        private int _timespan = 60;
        private string _message = "Je Tamagotchi doet een workout. Dit duurt 60 seconden.";
        public int TimeSpan
        {
            get { return _timespan; }
        }

        public string Act(Tamagotchi tmg)
        {
            //set cooldown op 60 seconden.
            //health - 5;
            return _message;
        }
    }
}