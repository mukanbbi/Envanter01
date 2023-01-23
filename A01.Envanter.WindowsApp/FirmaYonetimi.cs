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
    public partial class FirmaYonetimi : Form
    {
        public FirmaYonetimi()
        {
            InitializeComponent();
        }
        FirmaManager manager = new FirmaManager();
        Mesajlar mesajlar = new Mesajlar();
        void Yukle()
        {
            dgwFirma.DataSource = manager.GetAll();
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

        private void DgwFirma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgwFirma.CurrentRow.Cells[0].Value.ToString();//lbltext eşitleeşitle
            var firmaId = Convert.ToInt32(lblId.Text);//tablo id yi lbl id ile eşitle
            var firma = manager.Find(firmaId);
            txtAdres.Text = firma.Adres;
            txtFirmaAdi.Text = firma.Adi;
            txtFirmaKisaAdi.Text = firma.FirmaKisaAdi;
            txtNot.Text = firma.Not;
            txtTel1.Text = firma.Tel1;
            txtTel2.Text = firma.Tel2;
            txtVergi.Text = firma.VergiNo;
            chAktifMi.Checked = firma.AktifMi;
            dtpEklemeTarihi.Text = firma.EklenmeTarihi.ToString();
        }

        private void FirmaYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (txtFirmaAdi.Text=="")
            {
                mesajlar.MesajBosGecilemez();
            }
            else
            {
                var sonuc = manager.Add(
                new Firma
                {
                    Adi = txtFirmaAdi.Text,
                    Adres = txtAdres.Text,
                    AktifMi = chAktifMi.Checked,
                    EklenmeTarihi = dtpEklemeTarihi.Value,
                    FirmaKisaAdi = txtFirmaKisaAdi.Text,
                    Not = txtNot.Text,
                    Tel1 = txtTel1.Text,
                    Tel2 = txtTel2.Text,
                    VergiNo = txtVergi.Text
                });
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
            if (lblId.Text=="0")
            {
                mesajlar.MesajKayitSec();
            }
            else
            {
                var yeni = manager.Update(
                new Firma
                {
                    Id = Convert.ToInt32(lblId.Text),
                    Adres = txtAdres.Text,
                    AktifMi = chAktifMi.Checked,
                    EklenmeTarihi = dtpEklemeTarihi.Value,
                    Adi = txtFirmaAdi.Text,
                    FirmaKisaAdi = txtFirmaKisaAdi.Text,
                    Not = txtNot.Text,
                    Tel1 = txtTel1.Text,
                    Tel2 = txtTel2.Text,
                    VergiNo = txtVergi.Text
                });
                if (yeni > 0)
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
                DialogResult soru = MessageBox.Show("Silmek istediğinizden emin misiniz", "Uyarı", MessageBoxButtons.YesNo);
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
    }
}
