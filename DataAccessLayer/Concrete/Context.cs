using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=SirketDegerlendirmeintegrated security=true");

        }

        public DbSet<Egitim> Egitimler { get; set; }
        public DbSet<GirisBilgisi> GirisBilgileri{ get; set; }
        public DbSet<Kisi> Kisiler{ get; set; }
        public DbSet<KisiDegerlendirme> KisiDegerlendirmeleri{ get; set; }
        public DbSet<Kriter> Kriterler{ get; set; }
        public DbSet<KriterPuan> KriterPuanlari{ get; set; }
        public DbSet<Meslek> Meslekler{ get; set; }
        public DbSet<MeslekKriter> MeslekKriterler{ get; set; }

    }
}
