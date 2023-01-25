using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A01.Envanter.WindowsApp
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void BarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BilgisayarYonetimi bilgisayarYonetimi = new BilgisayarYonetimi();
            bilgisayarYonetimi.MdiParent = this;
            bilgisayarYonetimi.Show();
        }

        private void BarButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DepartmanYonetimi departmanYonetimi = new DepartmanYonetimi();
            departmanYonetimi.MdiParent = this;
            departmanYonetimi.Show();
        }

        private void BarButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void BarButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DomainYonetimi domainYonetimi = new DomainYonetimi();
            domainYonetimi.MdiParent = this;
            domainYonetimi.Show();
        }

        private void BarButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FirmaYonetimi firmaYonetimi = new FirmaYonetimi();
            firmaYonetimi.MdiParent = this;
            firmaYonetimi.Show();
        }

        private void BarButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MarkaYonetimi markaYonetimi = new MarkaYonetimi();
            markaYonetimi.MdiParent = this;
            markaYonetimi.Show();
        }

        private void BarButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MailYonetimi mailYonetimi = new MailYonetimi();
            mailYonetimi.MdiParent = this;
            mailYonetimi.Show();
        }

        private void BarButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MakinaYonetimi makinaYonetimi = new MakinaYonetimi();
            makinaYonetimi.MdiParent = this;
            makinaYonetimi.Show();
        }

        private void BarButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            kullaniciYonetimi.MdiParent = this;
            kullaniciYonetimi.Show();
        }

        private void BarButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RolYonetimi rolYonetimi = new RolYonetimi();
            rolYonetimi.MdiParent = this;
            rolYonetimi.Show();
        }

        private void AnaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BarButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

        }

        private void BarButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Raporlar.KullaniciIstatislik kullaniciIstatislik = new Raporlar.KullaniciIstatislik();
            kullaniciIstatislik.MdiParent = this;
            kullaniciIstatislik.Show();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void BarButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Raporlar.BilgisayarListe bilgisayarListe = new Raporlar.BilgisayarListe();
            bilgisayarListe.MdiParent = this;
            bilgisayarListe.Show();
        }
    }
}
