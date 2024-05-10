using EvidencijaNezaposlenih.Repozitorijum.Domeni.DTO;
using EvidencijaNezaposlenih.Repozitorijum.Domeni.Original;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaNezaposlenih.Servisi.Interfejsi
{
    public interface INezaposleniServis
    {
        Task<Nezaposleni> DajPoId(object PK);
        Task<IEnumerable<Nezaposleni>> DajSveAsync();
        Task<Nezaposleni> Dodaj(Nezaposleni obj);
        Nezaposleni Izmeni(Nezaposleni obj);
        Task<Nezaposleni> Obrisi(object PK);
        List<NezaposleniPogled> PrikaziPoViewu(string nazivViewa);
        void Sacuvaj();
        void TrigerujStoredProcedureZaDodavanje(string nazivProcedure, object o);
    }
}
