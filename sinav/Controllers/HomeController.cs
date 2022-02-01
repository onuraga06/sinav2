using sinav.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sinav.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        sinavDbEntities db = new sinavDbEntities();
        UrunModel urun = new UrunModel();
        public ActionResult Index()
        {
            urun.urunList = db.Urunler.ToList();
            urun.katList = db.Kategori.ToList();

            return View(urun);
        }
        public ActionResult Detay(int id)
        {
            urun.urunler = db.Urunler.Find(id);
            return View(urun);
           
        }
      
    }
}