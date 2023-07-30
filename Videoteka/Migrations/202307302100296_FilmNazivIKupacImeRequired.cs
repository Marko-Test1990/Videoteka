namespace Videoteka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FilmNazivIKupacImeRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Films", "Naziv", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Kupacs", "Ime", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kupacs", "Ime", c => c.String(maxLength: 255));
            AlterColumn("dbo.Films", "Naziv", c => c.String(maxLength: 255));
        }
    }
}
