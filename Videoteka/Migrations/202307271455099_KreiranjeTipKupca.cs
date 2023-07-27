namespace Videoteka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KreiranjeTipKupca : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipKupcas",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Kupacs", "TipKupcaId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Kupacs", "TipKupcaId");
            AddForeignKey("dbo.Kupacs", "TipKupcaId", "dbo.TipKupcas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kupacs", "TipKupcaId", "dbo.TipKupcas");
            DropIndex("dbo.Kupacs", new[] { "TipKupcaId" });
            DropColumn("dbo.Kupacs", "TipKupcaId");
            DropTable("dbo.TipKupcas");
        }
    }
}
