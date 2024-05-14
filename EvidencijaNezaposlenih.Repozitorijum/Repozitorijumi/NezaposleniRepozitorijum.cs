using EvidencijaNezaposlenih.Repozitorijum.Domeni.Context;
using EvidencijaNezaposlenih.Repozitorijum.Domeni.DTO;
using EvidencijaNezaposlenih.Repozitorijum.Domeni.Original;
using EvidencijaNezaposlenih.Repozitorijum.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaNezaposlenih.Repozitorijum.Repozitorijumi
{
    public class NezaposleniRepozitorijum : INezaposleniRepozitorijum
    {
        private readonly NezaposleniDbContext _context;
        public NezaposleniRepozitorijum(NezaposleniDbContext context)
        {
            _context = context;
        }

        public async Task<Nezaposleni> DajPoId(object PK)
        {
            // Implementacija dohvatanja entiteta po ID-u
            var id = (string)PK;
            return await _context.Nezaposleni.FindAsync(id);
        }

        public async Task<IEnumerable<Nezaposleni>> DajSveAsync()
        {
            // Implementacija dohvatanja svih entiteta asinhrono
            return await _context.Nezaposleni.ToListAsync();
        }

        public async Task<Nezaposleni> Dodaj(Nezaposleni obj)
        {
            // Implementacija dodavanja novog entiteta
            _context.Nezaposleni.Add(obj);
            return obj;
        }

        public Nezaposleni Izmeni(Nezaposleni obj)
        {
            // Implementacija izmene postojećeg entiteta
            _context.Entry(obj).State = EntityState.Modified;
            return obj;
        }

        public async Task<Nezaposleni> Obrisi(object PK)
        {
            // Implementacija brisanja entiteta po ID-u
            var id = (int)PK;
            var nezaposleni = await _context.Nezaposleni.FindAsync(id);
            if (nezaposleni != null)
            {
                _context.Nezaposleni.Remove(nezaposleni);
            }
            return nezaposleni;
        }

        public List<NezaposleniPogled> PrikaziPoViewu(string nazivViewa)
        {
            string sqlQuery = $"SELECT * FROM {nazivViewa}";
            return _context.Database.SqlQuery<NezaposleniPogled>(sqlQuery).ToList();
        }

        public void Sacuvaj()
        {
            _context.SaveChanges();
        }

        public void TrigerujStoredProcedure(string nazivProcedure, object o)
        {
            throw new NotImplementedException();
        }

        List<Nezaposleni> IRepozitorijum<Nezaposleni>.PrikaziPoViewu(string nazivViewa)
        {
            throw new NotImplementedException();
        }
    }
}
