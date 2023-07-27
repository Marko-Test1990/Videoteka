namespace Videoteka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodataKlasaTipClanstva : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipClanstvas",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Clanarina = c.Short(nullable: false),
                        TrajanjeMjeseci = c.Byte(nullable: false),
                        ProcenatPopusta = c.Byte(nullable: false),
                        Naziv = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipClanstvas");
        }
    }
}
