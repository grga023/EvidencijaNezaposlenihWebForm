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
        public int PIB {  get; private set; }

        public NezaposleniDodajFirma (DateTime datumPocetka, DateTime datumzavrsetka, int pIB)
        {
            this.datumPocetka = datumPocetka;
            this.datumZavrsetka = datumzavrsetka;
            PIB = pIB;
        }
    }
}
