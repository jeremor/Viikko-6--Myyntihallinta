using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Myyntihallinta.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult AsiakasValinta(int? asiakas_id, string etunimi, string sukunimi)
        {
            if (asiakas_id.HasValue)
            {
                return RedirectToAction("Tiedot", "Asiakas", new { id = asiakas_id });
            }
            return RedirectToAction("TiedotNimellä", "Asiakas", new { sukunimi, etunimi });

        }

        //[AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int id)
        {
            return RedirectToAction("Tiedot", "Asiakas", new { id });
            
        }

        public ActionResult About()
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