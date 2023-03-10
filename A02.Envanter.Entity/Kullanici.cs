using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02.Envanter.Entity
{
    public class Kullanici: IEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public bool AktifMi { get; set; }
        public int RolId { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
