using EvidencijaNezaposlenih.Repozitorijum.Domeni.Original;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaNezaposlenih.Repozitorijum.Domeni.DTO
{
    public class NezposleniDodaj
    {
        public string Ime { get; private set; }
        public string Prezime { get; private set; }
        public DateTime DatumRodjenja { get; private set; }
        public string Adresa { get; private set; }
        public string BrojTelefona { get; private set; }
        public string JMBG { get; private set; }
        public List<NezaposleniDodajFirma> NezaposleniDodajFirma { get; private set; }

        public NezposleniDodaj(string Ime, string Prezime, DateTime DatumRodjenja, string Adresa, string BrojTelefona, string JMBG, List<NezaposleniDodajFirma> NezaposleniDodajFirma)
        {
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.JMBG = JMBG;
            this.DatumRodjenja = DatumRodjenja;
            this.Adresa = Adresa;
            this.BrojTelefona = BrojTelefona;
            this.NezaposleniDodajFirma = NezaposleniDodajFirma;
        }
    }


}
