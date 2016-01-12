using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Tamagotchi_WCF.Actions;
using Tamagotchi_WCF.Spelregels;

namespace Tamagotchi_WCF
{
    public class Service : ITamagotchiService
    {
        private List<ISpelregel> _spelregels;
        public Service()
        {
            _spelregels = new List<Spelregels.ISpelregel>();
            _spelregels.Add(new Honger());
            _spelregels.Add(new Isolatie());
            _spelregels.Add(new Vermoeidheid());
            _spelregels.Add(new Verveling());
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
            string crazy = "";
            if (tmg.Crazy)
            {
                if (!RollTheDice(tmg, out crazy)) return crazy;
            }
            return actie.Act(tmg) + crazy;
        }

        private bool RollTheDice(Tamagotchi tmg, out string crazy)
        {
            Random r = new Random();
            int chance = r.Next(2);
            if (chance == 0)
            {
                crazy = "Je Tamagotchi is Crazy, maar heeft dit maal geluk!";
                return true;
            }
            else if (tmg.TopAtleet)
            {
                crazy = "Doordat je Tamagotchi zo super sportief is, is hij blijven leven!";
                return true;
            }
            else
            {
                crazy = "Je Crazy Tamagotchi is helaas overleden door zijn dolle acties... R.I.P.";
                return false;
            }
        }

        public List<Tamagotchi> GetTamagotchis()
        {
            List<Tamagotchi> lijst = new List<Tamagotchi>();
            using (var context = new TmgContext())
            {
                lijst = context.Tamagotchis.ToList();                
            }
            DoSpelregels(lijst);
            return lijst;
        }

        public void DoSpelregels(List<Tamagotchi> tmgs)
        {
            using (var context = new TmgContext())
            {
                foreach (Tamagotchi tmg in tmgs)
                {
                    if (tmg.Alive)
                    {
                        foreach (ISpelregel spelregel in _spelregels)
                        {
                            spelregel.ExecuteSpelregel(tmg);
                        }
                        tmg.LastAcces = DateTime.Now;
                    }
                    context.Entry(tmg).State = EntityState.Modified;
                }
                context.SaveChanges();
            }            
        }

        public List<Tamagotchi> GetLivingTamagotchis()
        {
                List<Tamagotchi> lijst = new List<Tamagotchi>();
                List<Tamagotchi> templist = GetTamagotchis();
                foreach (Tamagotchi item in templist)
                {
                    if (item.Alive)
                    {
                        lijst.Add(item);
                    }
                }            
            return lijst;
        }

        public Tamagotchi ChooseTamagotchi(string name)
        {
            Tamagotchi tmg = new Tamagotchi();
            List<Tamagotchi> tamagotchis = GetTamagotchis();
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
                    AccesGranted = DateTime.Now,
                    Alive = true,
                    Crazy = false,
                    Munchies = false,
                    TopAtleet = true
                });
                context.SaveChanges();
                
                return tmg;
            }

        }
    }
}
