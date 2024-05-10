using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaNezaposlenih.Repozitorijum.Domeni.Original
{
    public class RadniOdnos
    {
        [Key]
        public int RadniOdnosId { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }

        [ForeignKey("Firma")]
        public int PIB {  get; set; }
        public Firma Firma { get; set; }

        [ForeignKey("Nezaposleni")]
        public string ID_N { get; set; }
        public Nezaposleni Nezaposleni { get; set; }
    }
}
