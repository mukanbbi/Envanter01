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
    public partial class MakinaYonetimi : Form
    {
        public MakinaYonetimi()
        {
            InitializeComponent();
        }
        MakinaManager manager = new MakinaManager();
        Mesajlar mesajlar = new Mesajlar();
        void Yukle()
        {
            dgwMakina.DataSource = manager.GetAll();
        }
        void Temizle()
        {
            lblId.Text = "0";
            txtMakinaaTuru.Text = string.Empty;
        }

        private void DgwMakina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgwMakina.CurrentRow.Cells[0].Value.ToString();
            txtMakinaaTuru.Text = dgwMakina.CurrentRow.Cells[1].Value.ToString();
        }

        private void MakinaYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int islemSonucu = manager.Add(
                new Makina
                {
                    Adi = txtMakinaaTuru.Text
                }
                );
                if (islemSonucu > 0)
                {
                    Yukle();
                    Temizle();
                    mesajlar.MesajEklendi();
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
                if (lblId.Text != "0")
                {
                    int islemSonucu = manager.Update(
                        new Makina
                        {
                            Id = int.Parse(lblId.Text),
                            Adi = txtMakinaaTuru.Text
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
            catch (Exception)
            {

                mesajlar.MesajHata();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var makina = manager.Get(int.Parse(lblId.Text));
                    int islemSonucu = manager.Delete(makina);
                    if (islemSonucu > 0)
                    {
                        Yukle();
                        Temizle();
                        mesajlar.MesajSilindi();
                    }
                }
                else
                {
                    mesajlar.MesajKayitSec();
                }
            }
            catch (Exception)
            {

                mesajlar.MesajHata();
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            MakinaYonetimi makinaYonetimi = new MakinaYonetimi();
            this.Close();
        }
    }
}
