using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sinav.Models.Db
{
    public class TarihceModel
    {
        //public int id { get; set; }
        //public string Baslik { get; set; }
        //public string Aciklama { get; set; }
        //public string Resim { get; set; }
        
        public List<Ozellikler> oList { get; set; }
        public List<Tarihce> tList { get; set; }
    }
}