using sinav.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sinav.Controllers
{
    public class İletisimController : Controller
    {
        // GET: İletisim

        sinavDbEntities db = new sinavDbEntities();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(İletisim ek)
        {

            db.Entry(ek).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("Index", "Home");

        }
    }
}