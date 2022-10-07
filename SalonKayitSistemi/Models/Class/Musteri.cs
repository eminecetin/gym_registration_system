using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalonKayitSistemi.Models.Class
{
    public class Musteri
    {
        [Key]
        public int musteri_id { get; set; }
        public string TCKimlikNo { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public string Email { get; set; }
        public string Cinsiyet { get; set; }
        public float Boy { get; set; }
        public int Kilo { get; set; }
        public int Yas { get; set; }
        public string TelNo { get; set; }
        public ICollection<SporDali> MusteriSporDali { get; set; }
        
    }
}