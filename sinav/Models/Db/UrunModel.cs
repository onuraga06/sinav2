using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sinav.Models.Db
{
    public class UrunModel
    {
        public int Urunid { get; set; }
        public string UrunAd { get; set; }
        public int Kategoriid { get; set; }
        public decimal Fiyat { get; set; }
        public string UrunAciklama { get; set; }
        public string UrunResim { get; set; }
        public string KategoriAd { get; set; }
        
        public Urunler urunler { get; set; }
        public List<Urunler> urunList { get; set; }


        public  Kategori kategori { get; set; }
        public  List<Kategori> katList { get; set; }
    }
}