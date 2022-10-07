using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalonKayitSistemi.Models.Class
{
    public class SporDali
    {
        [Key]
        public int sporDali_id { get; set; }
        public string spor_cesiti { get; set; }
       
        public Musteri MusteriSporDali { get; set; }
        public Antrenor AntrenorSporDali { get; set; }
    }
}