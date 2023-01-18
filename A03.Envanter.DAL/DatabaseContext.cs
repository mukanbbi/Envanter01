using A02.Envanter.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A03.Envanter.DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Bilgisayar> Bilgisayarlar { get; set; }
        public DbSet<Departman> Departmanlar { get; set; }
        public DbSet<Domain> Domainler { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Mail> Mailler { get; set; }
        public DbSet<Makina> Makinalar { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Rol> Roller { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder) //kodu yaz
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public class DataBaseInitializer : CreateDatabaseIfNotExists<DatabaseContext>
        {
            protected override void Seed(DatabaseContext context)
            {
                //if (!context.Kullanicilar.Any()) //eğer kullanıcılar tablosunda kayıt yoksa
                //{
                //    var rol = context.Roller.Add(new Rol()
                //    {
                //        Adi = "Admin"
                //    });

                //    context.Kullanicilar.Add(new Kullanici()
                //    {
                //        Adi = "Admin",
                //        AktifMi = true,
                //        EklenmeTarihi = DateTime.Now,
                //        Email = "admin@otoservissatis.tc",
                //        KullaniciAdi = "admin",
                //        Sifre = "123456",
                //        Rol = rol,
                //        RolId = rol.Id


                //    });
                //    context.SaveChanges();

                //}
                base.Seed(context);
            }
            //public DatabaseContext() : base("name= DatabaseContext")
            //{
            //    Database.SetInitializer(new DataBaseInitializer());
            //}
        }
        public DatabaseContext(): base("name= DatabaseContext")
        {
            Database.SetInitializer(new DataBaseInitializer());
        }
    }
}