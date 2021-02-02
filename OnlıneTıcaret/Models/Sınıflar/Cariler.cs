using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlıneTıcaret.Models.Sınıflar
{
    public class Cariler
    {
        [Key]
        public int Cariid { get; set; }


        //---------------------------
        [Column(TypeName = "VarChar")]
        [StringLength(30,ErrorMessage = "En Fazla 30 Karakter Girişi Yapabilirsiniz")]
        public string CariAd { get; set; }
        //----------------------------


        //----------------------------
        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        [Required(ErrorMessage = "Bu Alanı Boş Geçemezsiniz!")]
        public string CariSoyad { get; set; }
        //----------------------------


        //----------------------------
        [Column(TypeName = "VarChar")]
        [StringLength(15)]
        public string CariSehir { get; set; }
        //-----------------------------

        //-----------------------------
        [Column(TypeName = "VarChar")]
        [StringLength(50)]
        public string CariMail { get; set; }
        //------------------------------
        public bool Durum { get; set; }

        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}