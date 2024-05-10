using EvidencijaNezaposlenih.Repozitorijum.Domeni.DTO;
using EvidencijaNezaposlenih.Repozitorijum.Domeni.Original;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaNezaposlenih.Repozitorijum.Interface
{
    public interface INezaposleniRepozitorijum : IRepozitorijum<Nezaposleni>
    {
        List<NezaposleniPogled> PrikaziPoViewu(string nazivViewa);
    }
}
