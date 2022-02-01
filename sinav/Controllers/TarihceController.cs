using sinav.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sinav.Controllers
{
    public class TarihceController : Controller
    {
        sinavDbEntities db = new sinavDbEntities();
       
        public ActionResult Index()
        {
            TarihceModel tmodel = new TarihceModel();
            tmodel.oList = db.Ozellikler.ToList();
            tmodel.tList = db.Tarihce.ToList();

            return View(tmodel);
        }
    }
}