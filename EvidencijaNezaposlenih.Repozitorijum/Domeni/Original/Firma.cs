using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaNezaposlenih.Repozitorijum.Domeni.Original
{
    public class Firma
    {
        [Key]
        public int PIB {  get; set; }
        public string Naziv {  get; set; }
        public string Adresa {  get; set; }
        public string BrojTelefona {  get; set; }
        public string OdgovornoLice {  get; set; }
    }
}
//Padajuci cb-naziv firme, pored dat pocetka/kraja ispod toga plus dugme koje kopira gornji red.