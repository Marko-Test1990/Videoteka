namespace Videoteka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KreiranjePozajmica : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pozajmicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KupacId = c.Int(nullable: false),
                        FilmId = c.Int(nullable: false),
                        DatumPozajmice = c.DateTime(),
                        DatumVracanja = c.DateTime(),
                        Napomena = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Films", t => t.FilmId, cascadeDelete: true)
                .ForeignKey("dbo.Kupacs", t => t.KupacId, cascadeDelete: true)
                .Index(t => t.KupacId)
                .Index(t => t.FilmId);
            
            AlterColumn("dbo.Films", "Naziv", c => c.String(maxLength: 255));
            AlterColumn("dbo.Zanrs", "Name", c => c.String(maxLength: 100));
            AlterColumn("dbo.Kupacs", "Ime", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pozajmicas", "KupacId", "dbo.Kupacs");
            DropForeignKey("dbo.Pozajmicas", "FilmId", "dbo.Films");
            DropIndex("dbo.Pozajmicas", new[] { "FilmId" });
            DropIndex("dbo.Pozajmicas", new[] { "KupacId" });
            AlterColumn("dbo.Kupacs", "Ime", c => c.String());
            AlterColumn("dbo.Zanrs", "Name", c => c.String());
            AlterColumn("dbo.Films", "Naziv", c => c.String());
            DropTable("dbo.Pozajmicas");
        }
    }
}
