using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02.Envanter.Entity
{
    public class Mail:IEntity
    {

        public int Id { get; set; }
        public int DomainId { get; set; }
        public int FirmaId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string MailAdres { get; set; }
       
        public bool AktifMi { get; set; }
        public string Not { get; set; }
        public virtual Domain Domain { get; set; }
        public virtual Firma Firma { get; set; }
    }
}
