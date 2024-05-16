using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
namespace ykmturr.Models.Sınıflar
{
    public class Context : DbContext
    {
         public DbSet<Admin> Admins { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Anasayfa> Anasayfas { get; set; }
        public DbSet<Corporate> Corporates { get; set; }
        public DbSet<Hakkımızda> Hakkımızdas { get; set; }
        public DbSet<İletisim> İletisims { get; set; }
        public DbSet<Populer> Populers { get; set; }
        public DbSet<Private> Privates { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Panel> Panels { get; set; }
        public DbSet<icon> icons { get; set; }
        public DbSet<Main> Mains { get; set; }
        public DbSet<Fiyat> Fiyats { get; set; }
        public DbSet<Yıldızlar> Yıldızlars { get; set; }
        public DbSet <Yatak> Yataks{ get; set; }


    }
}