using Myyntihallinta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Myyntihallinta.Controllers
{
    public class AsiakasController : Controller
    {
        // GET: Asiakas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tiedot(int id = 1)
        {
            MyyntiDBEntities db = new MyyntiDBEntities();
            var asiakas = from a in db.Asiakkaat where a.asiakas_id == id select a;

            return View(asiakas.FirstOrDefault());
        }
        public ActionResult TilausHistoria(int id = 1)
        {
            List<TilaushistoriaRivi> rivit = new List<TilaushistoriaRivi>();
            MyyntiDBEntities db = new MyyntiDBEntities();

            var historia = from t in db.Tilaukset
                           where t.asiakas_id == id
                           orderby t.tilausPvm
                           select t;
            foreach (var item in historia)
            {
                foreach (var tr in item.TilausRivi)
                {
                    rivit.Add(new TilaushistoriaRivi() { Pvm = item.tilausPvm, Tuote = tr.Tuote.nimi, Lkm = tr.tilausLkm, Laskutus = tr.tilausLkm * tr.ahinta - tr.alennus });
                }
            }
            var asiakas = db.Asiakkaat.Find(id);
            ViewBag.Asiakas = asiakas;
            return View(rivit);
        }
        
        public ActionResult TilaustenLukumaara(int? id)
        {
            MyyntiDBEntities db = new MyyntiDBEntities();

            var maara = from a in db.Tilaukset
                        where a.asiakas_id == id
                        select a.tilaus_id;

            var lkm = maara.Count();
            return Content(lkm.ToString());
        }
    }
}