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
    public partial class KullaniciYonetimi : Form
    {
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }
        KullaniciManager manager = new KullaniciManager();
        RolManager rolManager = new RolManager();
        Mesajlar mesajlar = new Mesajlar();
        void Yukle()
        {
            var sorgu = (from k in manager.GetAllByInclude("Rol")
                         select new
                         {
                             Id = k.Id,  //eşitin solu grıdalanları
                             Adı = k.Adi,
                             Soyadı = k.Soyadi,
                             Email = k.Email,
                             Telefon = k.Telefon1,
                             Telefon2 = k.Telefon2,
                             Kullanıcı_Adı = k.KullaniciAdi,
                             Sifre = k.Sifre,
                             Durum = k.AktifMi,
                             Eklenme_Tarihi = k.EklenmeTarihi,
                             Rolü = k.Rol.Adi

                         }
                         ).ToList();
            dgwKullanicilar.DataSource = sorgu;
            cbKullaniciRolu.DataSource = rolManager.GetAll();
            cbKullaniciRolu.ValueMember = "Id";
            cbKullaniciRolu.DisplayMember = "Adi";
        }
        void Temizle()
        {
            var nesneler = groupBox1.Controls.OfType<TextBox>();
            foreach (var item in nesneler)
            {
                item.Clear();
            }
            lblId.Text = "0";

        }

        private void DgwKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgwKullanicilar.CurrentRow.Cells[0].Value.ToString();
            int kullaniciId = Convert.ToInt32(lblId.Text);
            var kullanici = manager.Find(kullaniciId);
            txtAdi.Text = kullanici.Adi;
            txtKullaniciAdi.Text = kullanici.KullaniciAdi;
            txtMail.Text = kullanici.Email;
            txtSifre.Text = kullanici.Sifre;
            txtSoyadi.Text = kullanici.Soyadi;
            txtTelefon.Text = kullanici.Telefon1;
            cbAktif.Checked = kullanici.AktifMi;
            cbKullaniciRolu.SelectedValue = kullanici.Rol.Id;
            lblEklenmeTarihi.Text = kullanici.EklenmeTarihi.ToString();
        }

        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "")
            {
                mesajlar.MesajBosGecilemez();
            }
            else
            {
                var sonuc = manager.Add(
               new Kullanici
               {
                   Adi = txtAdi.Text,
                   AktifMi = cbAktif.Checked,
                   EklenmeTarihi = DateTime.Now,
                   Email = txtMail.Text,
                   KullaniciAdi = txtKullaniciAdi.Text,
                   RolId = Convert.ToInt32(cbKullaniciRolu.SelectedValue),
                   Sifre = txtSifre.Text,
                   Soyadi = txtSoyadi.Text,
                   Telefon1 = txtTelefon.Text
               }
               );
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    mesajlar.MesajEklendi();
                }
            }

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "0")
            {
                mesajlar.MesajKayitSec();
            }
            else if (txtKullaniciAdi.Text == "")
            {
                mesajlar.MesajBosGecilemez();
            }


            else
            {
                var sonuc = manager.Update(
               new Kullanici
               {
                   Id = Convert.ToInt32(Convert.ToInt32(lblId.Text)),
                   Adi = txtAdi.Text,
                   AktifMi = cbAktif.Checked,
                   EklenmeTarihi = DateTime.Now,
                   Email = txtMail.Text,
                   KullaniciAdi = txtKullaniciAdi.Text,
                   RolId = Convert.ToInt32(cbKullaniciRolu.SelectedValue),
                   Sifre = txtSifre.Text,
                   Soyadi = txtSoyadi.Text,
                   Telefon1 = txtTelefon.Text
               }
               );
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    mesajlar.MesajGuncellendi();
                }
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (lblId.Text=="0")
            {
                mesajlar.MesajKayitSec();
            }
            else
            {
                DialogResult soru = MessageBox.Show("Silinsin mi?", "Uyarı", MessageBoxButtons.YesNo);
                if (soru==DialogResult.Yes)
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
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            this.Close();
        }
    }
}


//DialogResult soru=MessageBox.Show("Silinsin mi?","Uyarı",MessageBoxButtons)
//else
//            {
//                var sonuc = manager.Delete(Convert.ToInt32(lblId.Text));
//                if (sonuc > 0)
//                {
//                    Temizle();
//Yukle();
//mesajlar.MesajSilindi();
//                }
//            }