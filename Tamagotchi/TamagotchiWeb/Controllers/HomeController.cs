using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TamagotchiWeb.Models;

namespace TamagotchiWeb.Controllers
{
    public class HomeController : Controller
    {
        ServiceReference1.ITamagotchiService service = new ServiceReference1.TamagotchiServiceClient();
        public ActionResult Index()
        {
           // ViewBag.Hunger = Url.Content("~/Content/Images/Hunger.png");
           // ViewBag.Sleep = Server.MapPath("~") + @"Content\Images\Sleep.png";
            //ViewBag.Boredom = Server.MapPath("~") + @"Content\Images\Boredom.png";
          //  ViewBag.Health = Server.MapPath("~") + @"Content\Images\Health.png";        
            
               List<String> TamagotchiList = new List<String>();
            foreach(string item in service.GetTamagotchis()){
                TamagotchiList.Add(item);
            }
            ViewBag.Tamagotchis = TamagotchiList;
            return View();
        }

    [HttpPost]
        public ActionResult Add(string Name)
        {
            
            service.CreateTamagotchi(Name);
            return RedirectToAction("Add");
        }
        public ActionResult Tamagotchi()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}