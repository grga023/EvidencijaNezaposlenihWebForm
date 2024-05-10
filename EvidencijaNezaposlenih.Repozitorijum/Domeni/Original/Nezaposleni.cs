using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaNezaposlenih.Repozitorijum.Domeni.Original
{
    public class Nezaposleni
    {
        [Key]
        public string ID_N { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        public string JMBG { get; set; }
        public List<RadniOdnos> RadniOdnos { get; set; }
    }
}
