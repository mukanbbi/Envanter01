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
    public partial class MailYonetimi : Form
    {
        public MailYonetimi()
        {
            InitializeComponent();
        }
        MailManager manager = new MailManager();
        DomainManager domainManager = new DomainManager();
        FirmaManager firmaManager = new FirmaManager();
        Mesajlar Mesajlar = new Mesajlar();
        void Yukle()
        {
            var sorgu = (from k in manager.GetAllByInclude2("domain", "firma")
                         select new
                         {
                             Id = k.Id,
                             DomainAdi = k.Domain.Adi,
                             FirmaAdi = k.Firma.Adi,
                             Adi = k.Adi,
                             Soyadi = k.Soyadi,
                             MailAdres = k.MailAdres,
                             AktifMi = k.AktifMi,
                             Not = k.Not
                         }).ToList();

            dgwMail.DataSource = sorgu;

            cmDomain.DataSource = domainManager.GetAll();
            cmDomain.DisplayMember = "Adi";
            cmDomain.ValueMember = "Id";

            cmFirma.DataSource = firmaManager.GetAll();
            cmFirma.DisplayMember = "Adi";
            cmFirma.ValueMember = "Id";
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
        private void DgwMail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgwMail.CurrentRow.Cells[0].Value.ToString(); //lblId yi dgw nin 0 ıncı değerine eşitle
            int mailId = Convert.ToInt32(lblId.Text); //değişken ile lblyi çevir
            var mail = manager.Find(mailId);//id bul
            txtAdi.Text = mail.Adi;
            chAktifMi.Checked = mail.AktifMi;
            cmDomain.SelectedValue = mail.DomainId;
            cmFirma.SelectedValue = mail.FirmaId;
            txtMail.Text = mail.MailAdres;
            txtSoyadi.Text = mail.Soyadi;
            txtNot.Text = mail.Not;
        }

        private void MailYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void BntEkle_Click(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                Mesajlar.MesajBosGecilemez();
            }
            else
            {
                var sonuc = manager.Add(
                                new Mail
                                {
                                    Adi = txtAdi.Text,
                                    AktifMi = chAktifMi.Checked,
                                    DomainId = Convert.ToInt32(cmDomain.SelectedValue),
                                    FirmaId = Convert.ToInt32(cmFirma.SelectedValue),
                                    MailAdres = txtMail.Text,
                                    Soyadi = txtSoyadi.Text,
                                    Not = txtNot.Text
                                });
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    Mesajlar.MesajEklendi();
                }
            }

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (lblId.Text=="0")
            {
                Mesajlar.MesajKayitSec();
            }
            else
            {
                var sonuc = manager.Update(
                new Mail
                {
                    Id = Convert.ToInt32(lblId.Text),
                    Adi = txtAdi.Text,
                    AktifMi = chAktifMi.Checked,
                    DomainId = Convert.ToInt32(cmDomain.SelectedValue),
                    FirmaId = Convert.ToInt32(cmFirma.SelectedValue),
                    MailAdres = txtMail.Text,
                    Soyadi = txtSoyadi.Text,
                    Not = txtNot.Text
                }
                );
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    Mesajlar.MesajGuncellendi();
                }
            }
            

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (lblId.Text=="0")
            {
                Mesajlar.MesajKayitSec();
            }
            else
            {
                DialogResult soru = MessageBox.Show("Silmek istediğinizden emin misiniz", "Uyarı", MessageBoxButtons.YesNo);
                if (soru == DialogResult.Yes)
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblId.Text));
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        Mesajlar.MesajSilindi();
                    }
                }
            }
            
            
                
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            MailYonetimi mailYonetimi = new MailYonetimi();
            this.Close();
        }
    }
}
