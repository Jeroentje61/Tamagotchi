using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Tamagotchi_WCF.Actions;

namespace Tamagotchi_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : ITamagotchiService
    {

        public int[] GetStatusses()
        {
            int[] stats = new int[4];
            //stats[0] = _curTamagotchi.Hunger;
            //stats[1] = _curTamagotchi.Sleep;
            //stats[2] = _curTamagotchi.Boredom;
            //stats[3] = _curTamagotchi.Health;

            return stats;
        }

        public string PerformAction(string action, Tamagotchi tmg)
        {
            if (tmg.AccesGranted > DateTime.Now) return ("Je Tamagotchi is nog bezig. Je kan weer iets doen over: " + (tmg.AccesGranted - DateTime.Now));

            action.ToLower();
            IAction actie;
            switch (action)
            {
                case "eat":
                    actie = new Eat();
                    break;
                case "play":
                    actie = new Play();
                    break;
                case "hug":
                    actie = new Hug();
                    break;
                case "workout":
                    actie = new Workout();
                    break;
                case "sleep":
                    actie = new Sleep();
                    break;
                default:
                    actie = null;
                    break;
            }
            if (actie == null) return "onjuiste command";
            return actie.Act(tmg);
        }

        public List<Tamagotchi> GetTamagotchis()
        {
            List<Tamagotchi> lijst = new List<Tamagotchi>();
            using (var context = new TmgContext())
            {
                lijst = context.Tamagotchis.ToList();                
            }
            return lijst;
        }

        public Tamagotchi ChooseTamagotchi(string name)
        {
            Tamagotchi tmg = new Tamagotchi();
            List<Tamagotchi> tamagotchis = new List<Tamagotchi>();
            using (var context = new TmgContext()) 
            { 
                tamagotchis = context.Tamagotchis.ToList();
            }
            bool found = false;
            foreach (Tamagotchi item in tamagotchis)
            {
                if (item.Naam.Equals(name))
                {
                    found = true;
                    tmg = item;
                }
            }
            if (found) return tmg;
            else { return null; }

        }

        public Tamagotchi CreateTamagotchi(string name)
        {
            Tamagotchi tmg = new Tamagotchi();
            if (name == "nee") return null;
            using (var context = new TmgContext())
            {
                context.Tamagotchis.Add(
                    
                    
                tmg =  new Tamagotchi()
                {
                    Naam = name,
                    Hunger = 0,
                    Sleep = 0,
                    Boredom = 0,
                    Health = 0,
                    LastAcces = DateTime.Now,
                    AccesGranted = DateTime.Now

                });
                context.SaveChanges();
                
                return tmg;
            }

        }
    }
}
