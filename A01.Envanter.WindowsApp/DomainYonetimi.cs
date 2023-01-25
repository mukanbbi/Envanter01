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
    public partial class DomainYonetimi : Form
    {
        public DomainYonetimi()
        {
            InitializeComponent();
        }
        DomainManager manager = new DomainManager();
        Mesajlar mesajlar = new Mesajlar();

        void Yukle()
        {
            dgwDomain.DataSource = manager.GetAll();
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
        private void DomainYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        private void DgwDomain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgwDomain.CurrentRow.Cells[0].Value.ToString();//id eşitle
            int domainId = Convert.ToInt32(lblId.Text);
            var domain = manager.Find(domainId);
            txtDomainAdi.Text = domain.Adi;

        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDomainAdi.Text=="")
                {
                    mesajlar.MesajKayitSec();
                }
                else
                {
                    var sonuc = manager.Add(
                new Domain
                {
                    Id = Convert.ToInt32(lblId.Text),
                    Adi = txtDomainAdi.Text
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
            catch (Exception)
            {

                mesajlar.MesajHata();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {

                if (lblId.Text == "0")
                {
                    mesajlar.MesajKayitSec();
                }
                else
                {
                    int sonuc = manager.Update(
                    new Domain
                    {
                        Id = Convert.ToInt32(lblId.Text),
                        Adi = txtDomainAdi.Text
                    });
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        mesajlar.MesajGuncellendi();
                    }
                }
            }
            catch (Exception)
            {

                mesajlar.MesajHata();
            }
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
                soru = MessageBox.Show("Sİlmek istediğiniz den emin misiniz", "Uyarı", MessageBoxButtons.YesNo);
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
            DomainYonetimi domainYonetimi = new DomainYonetimi();
            this.Close();
        }
    }
}
