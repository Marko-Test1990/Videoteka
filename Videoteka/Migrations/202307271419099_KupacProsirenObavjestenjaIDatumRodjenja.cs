namespace Videoteka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KupacProsirenObavjestenjaIDatumRodjenja : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kupacs", "PrimaObavjestenja", c => c.Boolean(nullable: false));
            AddColumn("dbo.Kupacs", "DatumRodjenja", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kupacs", "DatumRodjenja");
            DropColumn("dbo.Kupacs", "PrimaObavjestenja");
        }
    }
}
