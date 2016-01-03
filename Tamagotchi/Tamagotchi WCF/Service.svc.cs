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
        private Tamagotchi _curTamagotchi { get; set; }

        public int[] GetStatusses()
        {
            int[] stats = new int[4];
            stats[0] = _curTamagotchi.Hunger;
            stats[1] = _curTamagotchi.Sleep;
            stats[2] = _curTamagotchi.Boredom;
            stats[3] = _curTamagotchi.Health;

            return stats;
        }

        public string PerformAction(string action)
        {
            _curTamagotchi = new Tamagotchi();
            List<Tamagotchi> tamagotchis = new List<Tamagotchi>();
            using (var context = new TmgContext())
            {
                tamagotchis = context.Tamagotchis.ToList();
            }
            bool found = false;
            foreach (Tamagotchi item in tamagotchis)
            {
                if (item.Naam.Equals("Yolo"))
                {
                    found = true;
                    _curTamagotchi = item;
                }
            }

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
            else if (_curTamagotchi != null)
            {
                return actie.Act(_curTamagotchi);
            }
            else return "Geen Tamagotchi geselecteerd";
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
            _curTamagotchi = new Tamagotchi();
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
                    _curTamagotchi = item;
                }
            }
            if (found) return ("Je speelt nu met " + name + ".");
            else { return "Deze Tamagotchi bestaat niet..."; }

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
