namespace A03.Envanter.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbnewkurulus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bilgisayar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmanId = c.Int(nullable: false),
                        FirmaId = c.Int(nullable: false),
                        MakinaId = c.Int(nullable: false),
                        MarkaId = c.Int(nullable: false),
                        KullaniciAdi = c.String(),
                        PcIsmi = c.String(),
                        DcName = c.String(),
                        Lisans1 = c.String(),
                        Lisans1Active = c.String(),
                        Lisans2 = c.String(),
                        Lisans2Active = c.String(),
                        Lisans3 = c.String(),
                        Lisans3Active = c.String(),
                        PcLanMac = c.String(),
                        PcWrilessMac = c.String(),
                        PcYedekMac = c.String(),
                        SabitIp1 = c.String(),
                        SabitIp2 = c.String(),
                        YedekleniyorMu = c.Boolean(nullable: false),
                        Not1 = c.String(),
                        Not2 = c.String(),
                        EklemeTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departman", t => t.DepartmanId, cascadeDelete: false)
                .ForeignKey("dbo.Firma", t => t.FirmaId, cascadeDelete: false)
                .ForeignKey("dbo.Makina", t => t.MakinaId, cascadeDelete: false)
                .ForeignKey("dbo.Marka", t => t.MarkaId, cascadeDelete: false)
                .Index(t => t.DepartmanId)
                .Index(t => t.FirmaId)
                .Index(t => t.MakinaId)
                .Index(t => t.MarkaId);
            
            CreateTable(
                "dbo.Departman",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Firma",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                        FirmaKisaAdi = c.String(),
                        VergiNo = c.String(),
                        Adres = c.String(),
                        Tel1 = c.String(),
                        Tel2 = c.String(),
                        AktifMi = c.Boolean(nullable: false),
                        Not = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Makina",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Marka",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Domain",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kullanici",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                        Soyadi = c.String(),
                        Email = c.String(),
                        Telefon1 = c.String(),
                        Telefon2 = c.String(),
                        EklenmeTarihi = c.DateTime(nullable: false),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                        AktifMi = c.Boolean(nullable: false),
                        RolId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rol", t => t.RolId, cascadeDelete: true)
                .Index(t => t.RolId);
            
            CreateTable(
                "dbo.Rol",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DomainId = c.Int(nullable: false),
                        FirmaId = c.Int(nullable: false),
                        Adi = c.String(),
                        Soyadi = c.String(),
                        MailAdres = c.String(),
                        AktifMi = c.Boolean(nullable: false),
                        Not = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Domain", t => t.DomainId, cascadeDelete: true)
                .ForeignKey("dbo.Firma", t => t.FirmaId, cascadeDelete: true)
                .Index(t => t.DomainId)
                .Index(t => t.FirmaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mail", "FirmaId", "dbo.Firma");
            DropForeignKey("dbo.Mail", "DomainId", "dbo.Domain");
            DropForeignKey("dbo.Kullanici", "RolId", "dbo.Rol");
            DropForeignKey("dbo.Bilgisayar", "MarkaId", "dbo.Marka");
            DropForeignKey("dbo.Bilgisayar", "MakinaId", "dbo.Makina");
            DropForeignKey("dbo.Bilgisayar", "FirmaId", "dbo.Firma");
            DropForeignKey("dbo.Bilgisayar", "DepartmanId", "dbo.Departman");
            DropIndex("dbo.Mail", new[] { "FirmaId" });
            DropIndex("dbo.Mail", new[] { "DomainId" });
            DropIndex("dbo.Kullanici", new[] { "RolId" });
            DropIndex("dbo.Bilgisayar", new[] { "MarkaId" });
            DropIndex("dbo.Bilgisayar", new[] { "MakinaId" });
            DropIndex("dbo.Bilgisayar", new[] { "FirmaId" });
            DropIndex("dbo.Bilgisayar", new[] { "DepartmanId" });
            DropTable("dbo.Mail");
            DropTable("dbo.Rol");
            DropTable("dbo.Kullanici");
            DropTable("dbo.Domain");
            DropTable("dbo.Marka");
            DropTable("dbo.Makina");
            DropTable("dbo.Firma");
            DropTable("dbo.Departman");
            DropTable("dbo.Bilgisayar");
        }
    }
}
