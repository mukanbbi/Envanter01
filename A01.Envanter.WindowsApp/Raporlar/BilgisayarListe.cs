using A04.Envanter.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A01.Envanter.WindowsApp.Raporlar
{
    public partial class BilgisayarListe : Form
    {
        public BilgisayarListe()
        {
            InitializeComponent();
        }
        BilgisayarManager manager = new BilgisayarManager();
        FirmaManager firmaManager = new FirmaManager();
        MakinaManager makinaManager = new MakinaManager();
        MarkaManager markaManager = new MarkaManager();
        DepartmanManager departmanManager = new DepartmanManager();

        void Yukle()
        {
            var sorgu = (from k in manager.GetAllByInclude4("departman", "firma", "makina", "marka")
                         select new
                         {
                             Id = k.Id,
                             Departman = k.Departman.Adi,
                             Firma = k.Firma.Adi,
                             Makina = k.Makina.Adi,
                             Marka = k.Marka.Adi,
                             KullaniciAdi = k.KullaniciAdi,
                             PcAd = k.PcIsmi,
                             Lisans1 = k.Lisans1,
                             Lisans2 = k.Lisans2,
                             Lisans2Active = k.Lisans2Active,
                             Lisans3 = k.Lisans3,
                             Lisans3Active = k.Lisans3Active,
                             PcLanMac = k.PcLanMac,
                             PcWrilessMac = k.PcWrilessMac,
                             PcYedekMac = k.PcYedekMac,
                             SabitIp1 = k.SabitIp1,
                             SabitIp2 = k.SabitIp2,
                             YedekleniyorMu = k.YedekleniyorMu,
                             Not1 = k.Not1,
                             Not2 = k.Not2,
                             EklemeTarihi = k.EklemeTarihi

                         }).ToList();
            dgwListele.DataSource = sorgu;
        }
        private void BilgisayarListe_Load(object sender, EventArgs e)
        {
            Yukle();
        }
    }
}
