using System;
using System.Collections.Generic;
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

        public string Act()
        {
            //set cooldown op 30 seconden.
            //boredom - 10;
            return _message;
        }
    }
}