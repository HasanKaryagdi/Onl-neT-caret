using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlıneTıcaret.Models.Sınıflar
{
    public class Class1
    {// 2 tane listeleme formatında property tanımlandı.
        public IEnumerable<Urun> Deger1 { get; set; } // ürünü tut
        public IEnumerable<Detay> Deger2 { get; set; } // detayı tut
    }
}