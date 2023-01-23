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
    public partial class MarkaYonetimi : Form
    {
        public MarkaYonetimi()
        {
            InitializeComponent();
        }
        MarkaManager manager = new MarkaManager();
        Mesajlar mesajlar = new Mesajlar();
        void Yukle()
        {
            dgwMarka.DataSource = manager.GetAll();
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
        private void MarkaYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void DgwMarka_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgwMarka.CurrentRow.Cells[0].Value.ToString();
            int markaId = Convert.ToInt32(lblId.Text);
            var marka = manager.Find(markaId);
            txtMarkaAdi.Text = marka.Adi;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (txtMarkaAdi.Text == "")
            {
                mesajlar.MesajBosGecilemez();
            }
            else
            {
                var sonuc = manager.Add(
                                new Marka
                                {
                                    Adi = txtMarkaAdi.Text
                                });
                if (sonuc > 0)
                {
                    Yukle();
                    Temizle();
                    mesajlar.MesajEklendi();
                }
            }

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (lblId.Text != "0")
            {
                int islemSonucu = manager.Update(
                         new Marka
                         {
                             Id = int.Parse(lblId.Text),
                             Adi = txtMarkaAdi.Text
                         }
                         );
                if (islemSonucu > 0)
                {
                    Yukle();
                    Temizle();
                    mesajlar.MesajGuncellendi();
                }
            }
            else
            {
                mesajlar.MesajKayitSec();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "0")
                {
                    mesajlar.MesajKayitSec();
                }
                else
                {
                    DialogResult soru = MessageBox.Show("Silmek istdiğinizden emin misiniz", "Uyarı", MessageBoxButtons.YesNo);
                    if (soru == DialogResult.Yes)
                    {


                        int islemSonucu = manager.Delete(Convert.ToInt32(lblId.Text));
                        if (islemSonucu > 0)
                        {
                            Yukle();
                            Temizle();
                            mesajlar.MesajSilindi();
                        }


                    }
                }



            }
            catch (Exception)
            {

                mesajlar.MesajHata();
            }
        }
    }
}
