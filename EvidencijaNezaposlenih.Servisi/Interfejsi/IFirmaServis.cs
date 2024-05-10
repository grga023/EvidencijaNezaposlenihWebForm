using EvidencijaNezaposlenih.Repozitorijum.Domeni.DTO;
using EvidencijaNezaposlenih.Repozitorijum.Domeni.Original;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaNezaposlenih.Servisi.Interfejsi
{
    public interface IFirmaServis
    {
        Task<IEnumerable<FirmaPrikaz>> DajSveAsync();
        Task<FirmaPrikaz> DajPoPibAsync(object PIB);
        Task DodajFirmu(Firma firma);
        Task Obrisi(object Pib);
    }
}
