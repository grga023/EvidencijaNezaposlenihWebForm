using EvidencijaNezaposlenih.Repozitorijum.Domeni.Original;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaNezaposlenih.Repozitorijum.Domeni.Context
{
    public class NezaposleniDbContext : DbContext
    {
        public DbSet<Nezaposleni> Nezaposleni { get; set; }
        public DbSet<Firma> Firme { get; set; }
        public DbSet<RadniOdnos> RadniOdnosi { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RadniOdnos>().HasKey(x => new { x.PIB, x.ID_N });
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
