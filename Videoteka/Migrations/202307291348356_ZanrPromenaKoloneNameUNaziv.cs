namespace Videoteka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZanrPromenaKoloneNameUNaziv : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Zanrs", "Naziv", c => c.String(maxLength: 100));
            DropColumn("dbo.Zanrs", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Zanrs", "Name", c => c.String(maxLength: 100));
            DropColumn("dbo.Zanrs", "Naziv");
        }
    }
}
