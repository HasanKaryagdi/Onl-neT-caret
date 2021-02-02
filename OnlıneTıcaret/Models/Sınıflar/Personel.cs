using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace OnlıneTıcaret.Models.Sınıflar
{
    public class Personel
    {
        [Key]
        public int Personelid { get; set; }


        //-------------------------------
        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string PersonelAd { get; set; }
        //-------------------------------

        //-------------------------------
        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string PersonelSoyad { get; set; }
        //--------------------------------


        //--------------------------------
        [Column(TypeName = "VarChar")]
        [StringLength(230)]
        public string PersonelGorsel { get; set; }
        //-----------------------------------

        public ICollection<SatisHareket> SatisHarekets { get; set; }

        public int DepartmanID { get; set; }
        public virtual Departman Departman { get; set; }
    }
}