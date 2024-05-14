using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaNezaposlenih.Repozitorijum.Domeni.DTO
{
    public class NezaposleniDodajFirma
    {
        public DateTime datumPocetka { get; private set; }
        public DateTime datumZavrsetka { get; private set; }
        public string Naziv {  get; private set; }

        public NezaposleniDodajFirma (DateTime datumPocetka, DateTime datumzavrsetka, string Naziv)
        {
            this.datumPocetka = datumPocetka;
            this.datumZavrsetka = datumzavrsetka;
            this.Naziv = Naziv;
        }
    }
}
