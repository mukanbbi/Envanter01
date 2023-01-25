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
    public partial class DepartmanYonetimi : Form
    {
        public DepartmanYonetimi()
        {
            InitializeComponent();
        }
        DepartmanManager manager = new DepartmanManager();
        Mesajlar mesajlar = new Mesajlar();

        void Yukle()
        {
            dgwDepartman.DataSource = manager.GetAll();
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

        private void DepartmanYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int sonuc = manager.Add(
                                new Departman
                                {
                                    Adi = txtMakinaaTuru.Text
                                }
                                );
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    mesajlar.MesajEklendi();
                }
            }
            catch (Exception)
            {

                mesajlar.MesajHata();
            }
        }

        private void DgwDepartman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgwDepartman.CurrentRow.Cells[0].Value.ToString();
            int departmanId = Convert.ToInt32(lblId.Text);
            var departman = manager.Find(departmanId);
            txtMakinaaTuru.Text = departman.Adi;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (lblId.Text=="0")
            {
                mesajlar.MesajKayitSec();
            }
            else
            {
                int sonuc = manager.Update(
                new Departman
                {
                    Id = Convert.ToInt32(lblId.Text),
                    Adi = txtMakinaaTuru.Text
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
                DialogResult soru;
                soru = MessageBox.Show("Silmek istediğiniz den eminmisiniz", "Uyarı", MessageBoxButtons.YesNo);
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
            DepartmanYonetimi departmanYonetimi = new DepartmanYonetimi();
            this.Close();
        }
    }
}
