namespace A03.Envanter.DAL.Migrations
{
    using A02.Envanter.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<A03.Envanter.DAL.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(A03.Envanter.DAL.DatabaseContext context)
        {
            if (!context.Kullanicilar.Any()) //eğer kullanıcılar tablosunda kayıt yoksa
            {
                var rol = context.Roller.Add(new Rol()
                {
                    Adi = "Admin"
                });

                context.Kullanicilar.Add(new Kullanici()
                {
                    Adi = "Admin",
                    AktifMi = true,
                    EklenmeTarihi = DateTime.Now,
                    Email = "admin@otoservissatis.tc",
                    KullaniciAdi = "admin",
                    Sifre = "123456",
                    Rol = rol,
                    RolId = rol.Id


                });
                context.SaveChanges();

            }
            base.Seed(context);
        }
    }
}
