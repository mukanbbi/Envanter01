using A02.Envanter.Entity;
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

namespace A01.Envanter.WindowsApp
{
    public partial class BilgisayarYonetimi : Form
    {
        public BilgisayarYonetimi()
        {
            InitializeComponent();
        }

        BilgisayarManager manager = new BilgisayarManager();
        FirmaManager firmaManager = new FirmaManager();
        MakinaManager makinaManager = new MakinaManager();
        MarkaManager markaManager = new MarkaManager();
        DepartmanManager departmanManager = new DepartmanManager();
        Mesajlar mesajlar = new Mesajlar();
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
            dgwBilgisayar.DataSource = sorgu;

            cbDepartman.DataSource = departmanManager.GetAll();
            cbDepartman.DisplayMember = "Adi";
            cbDepartman.ValueMember = "Id";

            cbFirmaAdi.DataSource = firmaManager.GetAll();
            cbFirmaAdi.DisplayMember = "Adi";
            cbFirmaAdi.ValueMember = "Id";

            cbMakina.DataSource = makinaManager.GetAll();
            cbMakina.DisplayMember = "Adi";
            cbMakina.ValueMember = "Id";

            cbMarka.DataSource = markaManager.GetAll();
            cbMarka.DisplayMember = "Adi";
            cbMarka.ValueMember = "Id";
        }
        void Temizle()
        {
            var nesneler = groupBox1.Controls.OfType<TextBox>();
            foreach (var item in nesneler)
            {
                item.Clear();
            }

        }


        private void BilgisayarYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void BntEkle_Click(object sender, EventArgs e)
        {
            int sonuc = manager.Add(
                new Bilgisayar
                {
                    DepartmanId = Convert.ToInt32(cbDepartman.SelectedValue),
                    EklemeTarihi = dateEklemeTarihi.Value,
                    YedekleniyorMu = chYedekleniyorMu.Checked,
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Lisans1 = txtLisans1.Text,
                    Lisans1Active = txtLisans1Code.Text,
                    Lisans2 = txtLisans2.Text,
                    Lisans2Active = txtLisans2Code.Text,
                    Lisans3 = txtLisans3.Text,
                    Lisans3Active = txtLisans3Code.Text,
                    SabitIp1 = txtSabitIP1.Text,
                    SabitIp2 = txtSabitIP2.Text,
                    Not1 = txtNot1.Text,
                    Not2 = txtNot2.Text,
                    PcIsmi = txtPCAdi.Text,
                    PcLanMac = txtPCLanMac.Text,
                    PcWrilessMac = txtPCWrilessMac.Text,
                    PcYedekMac = txtPCYedekMac.Text,
                    DcName = txtDcName.Text,
                    FirmaId = Convert.ToInt32(cbFirmaAdi.SelectedValue),
                    MakinaId = Convert.ToInt32(cbMakina.SelectedValue),
                    MarkaId = Convert.ToInt32(cbMarka.SelectedValue)

                }
                );
            if (sonuc > 0)
            {

                Temizle();
                Yukle();
                mesajlar.MesajEklendi();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "0")
            {
                mesajlar.MesajKayitSec();
            }
            else
            {
                int sonuc = manager.Update(
                new Bilgisayar
                {
                    Id = Convert.ToInt32(lblId.Text),
                    DepartmanId = Convert.ToInt32(cbDepartman.SelectedValue),
                    EklemeTarihi = dateEklemeTarihi.Value,
                    YedekleniyorMu = chYedekleniyorMu.Checked,
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Lisans1 = txtLisans1.Text,
                    Lisans1Active = txtLisans1Code.Text,
                    Lisans2 = txtLisans2.Text,
                    Lisans2Active = txtLisans2Code.Text,
                    Lisans3 = txtLisans3.Text,
                    Lisans3Active = txtLisans3Code.Text,
                    SabitIp1 = txtSabitIP1.Text,
                    SabitIp2 = txtSabitIP2.Text,
                    Not1 = txtNot1.Text,
                    Not2 = txtNot2.Text,
                    PcIsmi = txtPCAdi.Text,
                    PcLanMac = txtPCLanMac.Text,
                    PcWrilessMac = txtPCWrilessMac.Text,
                    PcYedekMac = txtPCYedekMac.Text,
                    DcName = txtDcName.Text,
                    FirmaId = Convert.ToInt32(cbFirmaAdi.SelectedValue),
                    MakinaId = Convert.ToInt32(cbMakina.SelectedValue),
                    MarkaId = Convert.ToInt32(cbMarka.SelectedValue)
                });
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    mesajlar.MesajGuncellendi();

                }
            }

        }

        private void DgwBilgisayar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgwBilgisayar.CurrentRow.Cells[0].Value.ToString();//ID SEÇ
            int bilgisayarId = Convert.ToInt32(lblId.Text);//ıd conver yap
            var bilgisayar = manager.Find(bilgisayarId);//bilgisayar id bul
                                                        //eşitlemeye başla

            cbDepartman.SelectedValue = bilgisayar.DepartmanId;
            dateEklemeTarihi.Text = bilgisayar.EklemeTarihi.ToString();
            chYedekleniyorMu.Checked = bilgisayar.YedekleniyorMu;
            txtKullaniciAdi.Text = bilgisayar.KullaniciAdi;
            txtLisans1.Text = bilgisayar.Lisans1;
            txtLisans1Code.Text = bilgisayar.Lisans1Active;
            txtLisans2.Text = bilgisayar.Lisans2;
            txtLisans2Code.Text = bilgisayar.Lisans2Active;
            txtLisans3.Text = bilgisayar.Lisans3;
            txtLisans3Code.Text = bilgisayar.Lisans3Active;
            txtSabitIP1.Text = bilgisayar.SabitIp1;
            txtSabitIP2.Text = bilgisayar.SabitIp2;
            txtNot1.Text = bilgisayar.Not1;
            txtNot2.Text = bilgisayar.Not2;
            txtPCAdi.Text = bilgisayar.PcIsmi;
            txtPCLanMac.Text = bilgisayar.PcLanMac;
            txtPCWrilessMac.Text = bilgisayar.PcWrilessMac;
            txtPCYedekMac.Text = bilgisayar.PcYedekMac;
            txtDcName.Text = bilgisayar.DcName;
            cbFirmaAdi.SelectedValue = bilgisayar.FirmaId;
            cbMakina.SelectedValue = bilgisayar.MakinaId;
            cbMarka.SelectedValue = bilgisayar.MarkaId;

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "0")
            {
                mesajlar.MesajKayitSec();
            }
            else
            {
                DialogResult soru;
                soru = MessageBox.Show("Silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo);
                if (soru == DialogResult.Yes)
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblId.Text));
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        mesajlar.MesajSilindi();
                    }
                }



            }

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            BilgisayarManager manager = new BilgisayarManager();
            this.Close();
        }
    }
}
