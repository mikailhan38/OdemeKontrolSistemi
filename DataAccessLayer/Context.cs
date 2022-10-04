using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Context:DbContext
    {
        public DbSet<malik> Malikler { get; set; }
        public DbSet<Parsel> Parseller { get; set; }
        public DbSet<kullanici> Kullanicilar { get; set; }
        public DbSet<odeme> Odemeler { get; set; }
        public DbSet<islemler> Islemlers { get; set; }
    }
}
