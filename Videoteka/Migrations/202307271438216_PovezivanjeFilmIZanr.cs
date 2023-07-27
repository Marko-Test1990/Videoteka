namespace Videoteka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PovezivanjeFilmIZanr : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Zanrs");
            AddColumn("dbo.Films", "ZanrId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Zanrs", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Zanrs", "Id");
            CreateIndex("dbo.Films", "ZanrId");
            AddForeignKey("dbo.Films", "ZanrId", "dbo.Zanrs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Films", "ZanrId", "dbo.Zanrs");
            DropIndex("dbo.Films", new[] { "ZanrId" });
            DropPrimaryKey("dbo.Zanrs");
            AlterColumn("dbo.Zanrs", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Films", "ZanrId");
            AddPrimaryKey("dbo.Zanrs", "Id");
        }
    }
}
