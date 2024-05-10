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
        private readonly INezaposleniRepozitorijum _repozitorijum;

        public NezaposleniServis(INezaposleniRepozitorijum repo)
        {
            _repozitorijum = repo;
        }

        public Task<Nezaposleni> DajPoId(object PK)
        {
            return _repozitorijum.DajPoId(PK);
        }

        public Task<IEnumerable<Nezaposleni>> DajSveAsync()
        {
            return _repozitorijum.DajSveAsync();
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

        public Task<Nezaposleni> Dodaj(Nezaposleni obj)
        {
            string ID_N = GenerisiRandomID();

            if (_repozitorijum.DajPoId(ID_N) != null)
                throw new ArgumentException("Existing");

            foreach(var firma in obj.RadniOdnos)

            obj.ID_N = GenerisiRandomID();
            return _repozitorijum.Dodaj(obj);
        }

        public Nezaposleni Izmeni(Nezaposleni obj)
        {
            return _repozitorijum.Izmeni(obj);
        }

        public Task<Nezaposleni> Obrisi(object PK)
        {
            return _repozitorijum.Obrisi(PK);
        }

        public List<NezaposleniPogled> PrikaziPoViewu(string nazivViewa)
        {
            return _repozitorijum.PrikaziPoViewu(nazivViewa);
        }

        public void Sacuvaj()
        {
            _repozitorijum.Sacuvaj();
        }

        public void TrigerujStoredProcedureZaDodavanje(string nazivProcedure, object o)
        {
            _repozitorijum.TrigerujStoredProcedure(nazivProcedure, o);
        }
    }
}
