using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TamagotchiWeb.Models;

namespace TamagotchiWeb.Controllers
{
    public class HomeController : Controller
    {
        ServiceReference1.ITamagotchiService service = new ServiceReference1.TamagotchiServiceClient();
        ServiceReference1.Tamagotchi tmg;
        public ActionResult Index()
        {
           // ViewBag.Hunger = Url.Content("~/Content/Images/Hunger.png");
           // ViewBag.Sleep = Server.MapPath("~") + @"Content\Images\Sleep.png";
            //ViewBag.Boredom = Server.MapPath("~") + @"Content\Images\Boredom.png";
          //  ViewBag.Health = Server.MapPath("~") + @"Content\Images\Health.png";        

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
            return RedirectToAction(Naam);
        }
        [HttpPost]
    public ActionResult Tamagotchi(string TamagotchiID)
        {
            ViewBag.Naam = TamagotchiID;
            ViewBag.Hunger = service.ChooseTamagotchi(TamagotchiID).Hunger;
            ViewBag.Sleep = service.ChooseTamagotchi(TamagotchiID).Sleep;
            ViewBag.Boredom = service.ChooseTamagotchi(TamagotchiID).Boredom;
            ViewBag.Health = service.ChooseTamagotchi(TamagotchiID).Health;

            ViewBag.StatusImg = "~/Content/Images/Hunger.png";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}