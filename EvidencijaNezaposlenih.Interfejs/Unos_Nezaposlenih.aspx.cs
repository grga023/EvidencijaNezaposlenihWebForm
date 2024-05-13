using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EvidencijaNezaposlenih.Interfejs
{
    public partial class Unos_Nezaposlenih : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] naziviFirmi = { "Firma 1", "Firma 2", "Firma 3" };

            Unos_Nezaposlenih firmaSelect = (Unos_Nezaposlenih)FindControl("firma");

            foreach (string naziv in naziviFirmi)
            {
                ListItem option = new ListItem(naziv, naziv);
               // firmaSelect.Items.Add(option);
            }
        }
    }
}

