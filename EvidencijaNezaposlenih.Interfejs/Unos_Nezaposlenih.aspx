<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Unos_Nezaposlenih.aspx.cs" Inherits="EvidencijaNezaposlenih.Interfejs.Unos_Nezaposlenih" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Unos Nezaposlenih</title>
    <link rel="stylesheet" href="NezaposliUnos.css" />
    <style>
        .form-element {
            display: inline-block;
            margin-right: 10px;
            margin-bottom: 10px;
        }

        .form-element label {
            display: block;
            margin-bottom: 5px;
        }

        .form-element input,
        .form-element select {
            width: 150px;
            padding: 5px;
            border: 1px solid #ccc;
            border-radius: 3px;
            box-sizing: border-box;
        }
    </style>
</head>
<body>
    <form id="Form1" runat="server">
        <h1>Forma za unos nezaposlenih</h1>
        <div class="form-element">
            <label for="ime">Ime:</label>
            <input type="text" id="ime" name="ime" runat="server" />
        </div>
        <div class="form-element">
            <label for="prezime">Prezime:</label>
            <input type="text" id="prezime" name="prezime" runat="server" />
        </div>
        <div class="form-element">
            <label for="adresa">Adresa:</label>
            <input type="text" id="adresa" name="adresa" runat="server" />
        </div>
        <div class="form-element">
            <label for="telefon">Broj telefona:</label>
            <input type="tel" id="telefon" name="telefon" runat="server" />
        </div>
        <div class="form-element">
            <label for="jmbg">JMBG:</label>
            <input type="text" id="jmbg" name="jmbg" runat="server" />
        </div>
        <div class="form-element">
            <label for="datumPocetka">Datum početka radnog odnosa:</label>
            <input type="date" id="datumPocetka" name="datumPocetka" runat="server" />
        </div>
        <div class="form-element">
            <label for="datumZavrsetka">Datum završetka radnog odnosa:</label>
            <input type="date" id="datumZavrsetka" name="datumZavrsetka" runat="server" />
        </div>
        <div class="form-element">
            <label for="firma">Firma:</label>
            <select id="firma" name="firma" runat="server">
                <!-- Ovde ćemo dinamički dodati opcije iz koda na serverskoj strani -->
            </select>
        </div>
        <div class="form-element">
            <asp:Button ID="submitBtn" runat="server" Text="Potvrdi" OnClick="submitBtn_Click" />
        </div>
    </form>

    <script runat="server">
        protected void Page_Load(object sender, EventArgs e)
        {
            // Simulacija preuzimanja naziva firmi iz objekta
            string[] naziviFirmi = { "Firma 1", "Firma 2", "Firma 3" };

            // Pronađemo select element
            HtmlSelect firmaSelect = (HtmlSelect)FindControl("firma");

            // Iteriramo kroz niz naziva firmi i dodajemo ih kao opcije u select element
            foreach (string naziv in naziviFirmi)
            {
                ListItem option = new ListItem(naziv, naziv);
                firmaSelect.Items.Add(option);
            }
        }
    </script>
</body>
</html>



