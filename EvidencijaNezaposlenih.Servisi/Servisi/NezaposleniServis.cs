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
    public class NezaposleniServis : INezaposleniServis
    {
        private readonly INezaposleniRepozitorijum _nezaposleniRepozitorijum;
        private readonly IFirmaRepozitorijum _firmaRepozitorijum;

        public NezaposleniServis(INezaposleniRepozitorijum nezaposleniRepozitorijum, IFirmaRepozitorijum firmaRepozitorijum)
        {
            _nezaposleniRepozitorijum = nezaposleniRepozitorijum;
            _firmaRepozitorijum = firmaRepozitorijum;
        }

        public Task<Nezaposleni> DajPoId(object PK)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Nezaposleni>> DajSveAsync()
        {
            throw new NotImplementedException();
        }

        private string GenerisiRandomID()
        {
            string billNumberToControll;
            string billNumber;

            Random generator = new Random();
            int dig = generator.Next(1, 1000);
            //lending zero
            string First = dig.ToString("000");
            int dig2 = generator.Next(1, 1000000000);
            int dig3 = generator.Next(1, 10000);
            string Second = dig2.ToString("000000000") + dig3.ToString("0000");

            billNumberToControll = First + Second;
            long numberBody = long.Parse(billNumberToControll);

            long controlNumber = 98 - ((numberBody * 100) % 97);
            string controlString = controlNumber.ToString("00");

            billNumber = First + "-" + Second + "-" + controlString;

            //if (!_validationservice.isvalidbillnumber(billnumber))
            //{
            //    generaterandombillnumber();
            //}

            return billNumber;
        }
        public async Task Dodaj(NezposleniDodaj obj)
        {
            var ID_N = GenerisiRandomID();
            var nezaposlni = await _nezaposleniRepozitorijum.DajPoId(ID_N);

            if (nezaposlni == null)
                throw new ArgumentException("System error try again");

            Nezaposleni nezaposleniZaDodati = new Nezaposleni
            {
                ID_N = ID_N,
                Adresa = obj.Adresa,
                BrojTelefona = obj.BrojTelefona,
                DatumRodjenja = obj.DatumRodjenja,
                Ime = obj.Ime,
                Prezime = obj.Prezime
            };

            List<RadniOdnos> radniOdnosi = new List<RadniOdnos>();

            foreach (var item in obj.NezaposleniDodajFirma)
            {
                if (item.Naziv == "")
                    break;
                else
                {
                    Firma firma = await _firmaRepozitorijum.DajPoNazivu(item.Naziv);

                    radniOdnosi.Add(new RadniOdnos
                    {
                        ID_N = ID_N,
                        PIB = firma.PIB,
                        DatumPocetka = item.datumPocetka,
                        DatumZavrsetka = item.datumZavrsetka
                    });
                }
            }

            nezaposleniZaDodati.RadniOdnos = radniOdnosi;
            await _nezaposleniRepozitorijum.Dodaj(nezaposleniZaDodati);
            _nezaposleniRepozitorijum.Sacuvaj();
        }

        public Nezaposleni Izmeni(Nezaposleni obj)
        {
            throw new NotImplementedException();
        }

        public Task<Nezaposleni> Obrisi(object PK)
        {
            throw new NotImplementedException();
        }

        public List<NezaposleniPogled> PrikaziPoViewu(string nazivViewa)
        {
            throw new NotImplementedException();
        }

        public void Sacuvaj()
        {
            throw new NotImplementedException();
        }

        public void TrigerujStoredProcedureZaDodavanje(string nazivProcedure, object o)
        {
            throw new NotImplementedException();
        }

        Task INezaposleniServis.DajPoId(object PK)
        {
            throw new NotImplementedException();
        }
    }
}
