using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalonKayitSistemi.Models.Class
{
    public class EkHizmet
    {
        [Key]
        public int hizmet_id { get; set; }
        public string hizmet_secimi { get; set; }
       
     
    }
}