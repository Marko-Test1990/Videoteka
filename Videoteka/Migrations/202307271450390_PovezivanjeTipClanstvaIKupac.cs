namespace Videoteka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PovezivanjeTipClanstvaIKupac : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kupacs", "TipClanstvaId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Kupacs", "TipClanstvaId");
            AddForeignKey("dbo.Kupacs", "TipClanstvaId", "dbo.TipClanstvas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kupacs", "TipClanstvaId", "dbo.TipClanstvas");
            DropIndex("dbo.Kupacs", new[] { "TipClanstvaId" });
            DropColumn("dbo.Kupacs", "TipClanstvaId");
        }
    }
}
