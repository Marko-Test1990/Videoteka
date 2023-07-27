namespace Videoteka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipKupcaPromenaNameUNaziv : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TipKupcas", "Naziv", c => c.String(maxLength: 50));
            DropColumn("dbo.TipKupcas", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TipKupcas", "Name", c => c.String(maxLength: 50));
            DropColumn("dbo.TipKupcas", "Naziv");
        }
    }
}
