using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaNezaposlenih.Repozitorijum.Interface
{
    public interface IRepozitorijum <T> where T : class
    {
        Task<T> Obrisi(object PK);
        Task<T> DajPoId(object PK);
        Task<IEnumerable<T>> DajSveAsync();
        Task<T> Dodaj(T obj);
        T Izmeni(T obj);
        void Sacuvaj();

        List<T> PrikaziPoViewu(string nazivViewa);

        void TrigerujStoredProcedure(string nazivProcedure, object obj);

    }
}
