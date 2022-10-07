using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalonKayitSistemi.Models.Class
{
    public class CalismaSekli
    {
        [Key]
        public int Calisma_id { get; set; }
        public string Calisma_sekli { get; set; }
        
    }
}