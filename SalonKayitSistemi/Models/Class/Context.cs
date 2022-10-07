using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SalonKayitSistemi.Models.Class
{
    public class Context: DbContext
    {
        public DbSet<Antrenor> Antrenors { get; set; }
        public DbSet<CalismaSekli> CalismaSeklis { get; set; }
        public DbSet<EkHizmet> ekHizmets { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<SporDali> SporDalis { get; set; }

    }
}