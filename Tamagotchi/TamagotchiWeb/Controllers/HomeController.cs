using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TamagotchiWeb.Models;
using TamagotchiWeb.ServiceReference1;

namespace TamagotchiWeb.Controllers
{
    public class HomeController : Controller
    {
        ServiceReference1.ITamagotchiService service = new ServiceReference1.TamagotchiServiceClient();
        public ActionResult Index()
        { 
            List<ServiceReference1.Tamagotchi> TamagotchiList = new List<ServiceReference1.Tamagotchi>();
            foreach (ServiceReference1.Tamagotchi item in service.GetTamagotchis())
            {
                TamagotchiList.Add(item);
            }
            ViewBag.Tamagotchis = TamagotchiList;
            return View();
        }

    [HttpPost]
        public ActionResult Add(string Naam)
        {
            service.CreateTamagotchi(Naam);
            return RedirectToAction("Index");
        }
        [HttpPost]
    public ActionResult Tamagotchi(string TamagotchiID)
        {
            ViewBag.Naam = TamagotchiID;
            ViewBag.Hunger = service.ChooseTamagotchi(TamagotchiID).Hunger;
            ViewBag.Sleep = service.ChooseTamagotchi(TamagotchiID).Sleep;
            ViewBag.Boredom = service.ChooseTamagotchi(TamagotchiID).Boredom;
            ViewBag.Health = service.ChooseTamagotchi(TamagotchiID).Health;


            if (service.ChooseTamagotchi(TamagotchiID).Alive == false)
            {
               ViewBag.StatusImg = "http://i1085.photobucket.com/albums/j431/antiwoutertje/4-Death-funeral-grave-gravestone-graveyard-stone-rip-48_zpsk0qhudey.png";
               ViewBag.Status = "Dead";
            }
      else if (ViewBag.Hunger >= ViewBag.Sleep && ViewBag.Hunger >= ViewBag.Boredom && ViewBag.Hunger >= ViewBag.Health){
          ViewBag.StatusImg = "http://i1085.photobucket.com/albums/j431/antiwoutertje/Hunger_zpsejudkerd.png";
          ViewBag.Status = "Hunger";
      }
      else if (ViewBag.Sleep > ViewBag.Hunger && ViewBag.Sleep > ViewBag.Boredom && ViewBag.Sleep > ViewBag.Health)
      {
          ViewBag.StatusImg = "http://i1085.photobucket.com/albums/j431/antiwoutertje/Sleep_zpsdftptpku.png";
          ViewBag.Status = "Sleep";
      }
      else if (ViewBag.Boredom > ViewBag.Hunger && ViewBag.Boredom > ViewBag.Sleep && ViewBag.Boredom > ViewBag.Health)
      {
          ViewBag.StatusImg = "http://i1085.photobucket.com/albums/j431/antiwoutertje/Boredom_zpsjer3tat6.png";
          ViewBag.Status = "Boredom";
      }
      else if (ViewBag.Health > ViewBag.Hunger && ViewBag.Health > ViewBag.Boredom && ViewBag.Health > ViewBag.Sleep)
      {
          ViewBag.StatusImg = "http://i1085.photobucket.com/albums/j431/antiwoutertje/Health_zpsecaamucf.png";
          ViewBag.Status = "Health";
      }
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}