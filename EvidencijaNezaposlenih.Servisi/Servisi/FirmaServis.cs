using EvidencijaNezaposlenih.Repozitorijum.Domeni.DTO;
using EvidencijaNezaposlenih.Repozitorijum.Domeni.Original;
using EvidencijaNezaposlenih.Repozitorijum.Interface;
using EvidencijaNezaposlenih.Servisi.Interfejsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaNezaposlenih.Servisi.Servisi
{
    public class FirmaServis : IFirmaServis
    {
        private readonly IFirmaRepozitorijum _repozitorijum;

        public FirmaServis(IFirmaRepozitorijum repo)
        {
            _repozitorijum = repo;
        }
        public async Task<FirmaPrikaz> DajPoPibAsync(object PIB)
        {
            var firma = await _repozitorijum.DajPoId(PIB);

            if (firma == null)
            {
                return null; // ili nešto drugo ako firma ne postoji
            }

            var firmaDTO = new FirmaPrikaz
            {
                Naziv = firma.Naziv,
                Adresa = firma.Adresa,
                BrojTelefona = firma.BrojTelefona,
                OdgovornoLice = firma.OdgovornoLice
            };

            return firmaDTO;
        }

        public async Task<IEnumerable<FirmaPrikaz>> DajSveAsync()
        {
            var firme = await _repozitorijum.DajSveAsync();

            var firmeZaPrikaz = firme.Select(firma => new FirmaPrikaz
            {
                Naziv = firma.Naziv,
                Adresa = firma.Adresa,
                BrojTelefona = firma.BrojTelefona,
                OdgovornoLice = firma.OdgovornoLice
            });

            return firmeZaPrikaz;
        }

        public Task DodajFirmu(Firma firma) => _repozitorijum.Dodaj(firma);

        public Task Obrisi(object PIB)
        {
            return _repozitorijum.Obrisi(PIB);
        }
    }
}
