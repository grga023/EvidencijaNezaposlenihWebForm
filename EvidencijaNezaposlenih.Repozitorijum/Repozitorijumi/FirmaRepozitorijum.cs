using EvidencijaNezaposlenih.Repozitorijum.Domeni.Context;
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
    public class FirmaRepozitorijum : IFirmaRepozitorijum
    {
        private readonly Context _context;

        public FirmaRepozitorijum(Context context)
        {
            _context = context;
        }

        public async Task<Firma> DajPoId(object PK)
        {
            var id = (int)PK;
            return await _context.Firme.FindAsync(id);
        }

        public async Task<IEnumerable<Firma>> DajSveAsync()
        {
            return await _context.Firme.ToListAsync();
        }

        public async Task<Firma> Dodaj(Firma obj)
        {
            _context.Firme.Add(obj);
            return obj;
        }

        public Firma Izmeni(Firma obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            return obj;
        }

        public async Task<Firma> Obrisi(object PK)
        {
            var id = (int)PK;
            var firma = await _context.Firme.FindAsync(id);
            if (firma != null)
            {
                _context.Firme.Remove(firma);
            }
            return firma;
        }

        public void Sacuvaj()
        {
            _context.SaveChanges();
        }
        public List<Firma> PrikaziPoViewu(string nazivViewa)
        {
            throw new NotImplementedException();
        }

        public void TrigerujStoredProcedure(string nazivProcedure, object o)
        {
            throw new NotImplementedException();
        }
    }
}
