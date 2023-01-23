using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02.Envanter.Entity
{
    public class Firma: IEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string FirmaKisaAdi { get; set; }
        public string VergiNo { get; set; }
        public string Adres { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public bool AktifMi { get; set; }
        public string Not { get; set; }
        public DateTime EklenmeTarihi { get; set; }
    }
}
