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
            stats[0] = 50;
            stats[1] = 100;
            stats[2] = 50;
            stats[3] = 10;

            return stats;
        }

        public string PerformAction(string action)
        {
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
            return actie.Act();
        }

        public List<string> GetTamagotchis()
        {
            List<string> lijst = new List<string>();
            using (var context = new TmgContext())
            {
                List<Tamagotchi> temp = context.Tamagotchis.ToList();
                foreach (Tamagotchi item in temp)
                {
                    lijst.Add(item.Naam);
                }
            }

            return lijst;
        }

        public string ChooseTamagotchi(string name)
        {
            throw new NotImplementedException();
        }

        public string CreateTamagotchi(string name)
        {
            name.ToLower();
            if (name == "nee") return "Je hebt ervoor gekozen geen Tamagotchi aan te maken";
            using (var context = new TmgContext())
            {
                context.Tamagotchis.Add(new Tamagotchi()
                {
                    Naam = name,
                    Hunger = 0,
                    Sleep = 0,
                    Boredom = 0,
                    Health = 0                    
                });
                context.SaveChanges();
                return ("Je Tamagotchi " + name + " is aangemaakt!");
            }

        }
    }
}
