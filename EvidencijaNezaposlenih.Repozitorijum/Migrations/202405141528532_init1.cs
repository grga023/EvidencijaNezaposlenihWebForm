namespace EvidencijaNezaposlenih.Repozitorijum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Firmas", newName: "Firma");
            RenameTable(name: "dbo.Korisniks", newName: "Korisnik");
            RenameTable(name: "dbo.Nezaposlenis", newName: "Nezaposleni");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Nezaposleni", newName: "Nezaposlenis");
            RenameTable(name: "dbo.Korisnik", newName: "Korisniks");
            RenameTable(name: "dbo.Firma", newName: "Firmas");
        }
    }
}
