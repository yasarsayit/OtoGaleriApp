namespace OtoGaleriApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aracs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marka = c.String(),
                        Model = c.String(),
                        Plaka = c.String(),
                        Yil = c.Int(nullable: false),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kisis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        Telefon = c.String(),
                        TC = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kullanicis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Satis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AracId = c.Int(nullable: false),
                        AliciId = c.Int(nullable: false),
                        SaticiId = c.Int(nullable: false),
                        SatisFiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kisis", t => t.AliciId)
                .ForeignKey("dbo.Aracs", t => t.AracId, cascadeDelete: true)
                .ForeignKey("dbo.Kullanicis", t => t.SaticiId)
                .Index(t => t.AracId)
                .Index(t => t.AliciId)
                .Index(t => t.SaticiId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Satis", "SaticiId", "dbo.Kullanicis");
            DropForeignKey("dbo.Satis", "AracId", "dbo.Aracs");
            DropForeignKey("dbo.Satis", "AliciId", "dbo.Kisis");
            DropIndex("dbo.Satis", new[] { "SaticiId" });
            DropIndex("dbo.Satis", new[] { "AliciId" });
            DropIndex("dbo.Satis", new[] { "AracId" });
            DropTable("dbo.Satis");
            DropTable("dbo.Kullanicis");
            DropTable("dbo.Kisis");
            DropTable("dbo.Aracs");
        }
    }
}
