using EvidencijaNezaposlenih.Repozitorijum.Domeni.DTO;
using EvidencijaNezaposlenih.Servisi.Interfejsi;
using EvidencijaNezaposlenih.Servisi.Servisi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Unity;

namespace EvidencijaNezaposlenih.Interfejs
{
    public partial class DynamicForm : System.Web.UI.Page
    {
        private  INezaposleniServis _nezaposleniServis;
        protected void Page_Load(object sender, EventArgs e)
        {
            // Instantiate the service here
            var container = (IUnityContainer)Application["NezaposleniDbContext"];

            _nezaposleniServis = container.Resolve<INezaposleniServis>();

            // Your existing Page_Load logic here, if any

            // Register the event handler for the button click event
            btnSubmit.Click += btnSubmit_Click;
        }

        protected async void btnSubmit_Click(object sender, EventArgs e)
        {
            NezaposleniDodajFirma odnos = new NezaposleniDodajFirma(default, default, "Test");
            NezaposleniDodajFirma odnos2 = new NezaposleniDodajFirma(default, default, "Test2");
            List<NezaposleniDodajFirma> firma = new List<NezaposleniDodajFirma>
            {
                odnos,
                odnos2
            };

            NezposleniDodaj dodaj = new NezposleniDodaj("Ognjen", "Grgur", default, "adresa", "0631241344", "0610001850019", firma);

            // Use the service instantiated in Page_Load
            await _nezaposleniServis.Dodaj(dodaj);
        }
    }
}