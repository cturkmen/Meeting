namespace MeetingOrganizer.UI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Toplantilar",
                c => new
                    {
                        ToplantiId = c.Int(nullable: false, identity: true),
                        ToplantiKonusu = c.String(nullable: false),
                        Tarih = c.DateTime(nullable: false),
                        BaslangicSaati = c.String(nullable: false),
                        BitisSaati = c.String(nullable: false),
                        Katilimcilar = c.String(nullable: false),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ToplantiId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Toplantilar");
        }
    }
}
