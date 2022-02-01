using sinav.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sinav.Controllers
{
    public class HakkimizdaController : Controller
    {
        sinavDbEntities db = new sinavDbEntities();
        public ActionResult Hakkimizda()
        {
            List<HakkimizdaModel> hList = db.Hakkimizda.Select(x => new HakkimizdaModel
            {
                Personelid = x.Personelid,
                Ad = x.Ad,
                Görev = x.Görev,
                Resim = x.Resim,
                Aciklama = x.Aciklama,


            }).ToList();

            return View(hList);

        }
    }
}