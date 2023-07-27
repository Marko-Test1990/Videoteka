namespace Videoteka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTipKupcaNakonPromeneImenaKolone : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE TipKupcas SET Naziv='Ucenik' WHERE Id=1");
            Sql("UPDATE TipKupcas SET Naziv='Student' WHERE Id=2");
            Sql("UPDATE TipKupcas SET Naziv='Nezaposlen' WHERE Id=3");
            Sql("UPDATE TipKupcas SET Naziv='Zaposlen' WHERE Id=4");
            Sql("UPDATE TipKupcas SET Naziv='Penzioner' WHERE Id=5");
        }
        
        public override void Down()
        {
        }
    }
}
