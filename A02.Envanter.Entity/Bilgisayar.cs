using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02.Envanter.Entity
{
    public class Bilgisayar:IEntity
    {
        public int Id { get; set; }
        public int DepartmanId { get; set; }
        public int FirmaId { get; set; }
        public int MakinaId { get; set; }
        public int MarkaId { get; set; }
        public string KullaniciAdi { get; set; }
        public string PcIsmi { get; set; }
        public string DcName { get; set; }
        public string Lisans1 { get; set; }
        public string Lisans1Active { get; set; }
        public string Lisans2 { get; set; }
        public string Lisans2Active { get; set; }
        public string Lisans3 { get; set; }
        public string Lisans3Active { get; set; }
        public string PcLanMac { get; set; }
        public string PcWrilessMac { get; set; }
        public string PcYedekMac { get; set; }
        public string SabitIp1 { get; set; }
        public string SabitIp2 { get; set; }
        public bool YedekleniyorMu { get; set; }
        public string Not1 { get; set; }
        public string Not2 { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public virtual Departman Departman { get; set; }
        public virtual Firma Firma { get; set; }
        public virtual Makina Makina { get; set; }
        public virtual Marka Marka { get; set; }

    }
}
