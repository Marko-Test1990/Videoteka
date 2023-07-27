namespace Videoteka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FilmProsirenDatumUnosaDatumIzdanjaBrojNaStanjuIBrojDostupnih : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "DatumUnosa", c => c.DateTime());
            AddColumn("dbo.Films", "DatumIzdanja", c => c.DateTime());
            AddColumn("dbo.Films", "BrojNaStanju", c => c.Byte(nullable: false));
            AddColumn("dbo.Films", "BrojDostupnih", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "BrojDostupnih");
            DropColumn("dbo.Films", "BrojNaStanju");
            DropColumn("dbo.Films", "DatumIzdanja");
            DropColumn("dbo.Films", "DatumUnosa");
        }
    }
}
