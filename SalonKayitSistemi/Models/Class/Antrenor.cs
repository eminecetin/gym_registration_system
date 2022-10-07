using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalonKayitSistemi.Models.Class
{
    public class Antrenor
    {
        [Key]
        public int Antrenör_id { get; set; }
        public string Antrenör_Adi { get; set; }
        public string Antrenör_Soyadi { get; set; }
        public string Antrenör_Alani { get; set; }
       
        public ICollection<SporDali> AntrenorSporDali { get; set; }
    }
}