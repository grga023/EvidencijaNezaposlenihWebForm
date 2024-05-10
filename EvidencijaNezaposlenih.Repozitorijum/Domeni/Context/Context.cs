using EvidencijaNezaposlenih.Repozitorijum.Domeni.Original;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaNezaposlenih.Repozitorijum.Domeni.Context
{
    public class Context : DbContext
    {
        public DbSet<Nezaposleni> Nezaposleni { get; set; }
        public DbSet<Firma> Firme { get; set; }
        public DbSet<RadniOdnos> RadniOdnosi { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RadniOdnos>().HasKey(x => new { x.PIB, x.ID_N });
            base.OnModelCreating(modelBuilder);
        }
    }
}
