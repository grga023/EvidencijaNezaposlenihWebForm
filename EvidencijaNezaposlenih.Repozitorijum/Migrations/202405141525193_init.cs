namespace EvidencijaNezaposlenih.Repozitorijum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Firmas",
                c => new
                    {
                        PIB = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                        Adresa = c.String(),
                        BrojTelefona = c.String(),
                        OdgovornoLice = c.String(),
                    })
                .PrimaryKey(t => t.PIB);
            
            CreateTable(
                "dbo.Korisniks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Nezaposlenis",
                c => new
                    {
                        ID_N = c.String(nullable: false, maxLength: 128),
                        Ime = c.String(),
                        Prezime = c.String(),
                        DatumRodjenja = c.DateTime(nullable: false),
                        Adresa = c.String(),
                        BrojTelefona = c.String(),
                        JMBG = c.String(),
                    })
                .PrimaryKey(t => t.ID_N);
            
            CreateTable(
                "dbo.RadniOdnos",
                c => new
                    {
                        PIB = c.Int(nullable: false),
                        ID_N = c.String(nullable: false, maxLength: 128),
                        RadniOdnosId = c.Int(nullable: false),
                        DatumPocetka = c.DateTime(nullable: false),
                        DatumZavrsetka = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.PIB, t.ID_N })
                .ForeignKey("dbo.Firmas", t => t.PIB, cascadeDelete: true)
                .ForeignKey("dbo.Nezaposlenis", t => t.ID_N, cascadeDelete: true)
                .Index(t => t.PIB)
                .Index(t => t.ID_N);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RadniOdnos", "ID_N", "dbo.Nezaposlenis");
            DropForeignKey("dbo.RadniOdnos", "PIB", "dbo.Firmas");
            DropIndex("dbo.RadniOdnos", new[] { "ID_N" });
            DropIndex("dbo.RadniOdnos", new[] { "PIB" });
            DropTable("dbo.RadniOdnos");
            DropTable("dbo.Nezaposlenis");
            DropTable("dbo.Korisniks");
            DropTable("dbo.Firmas");
        }
    }
}
