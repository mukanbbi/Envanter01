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
    public partial class RolYonetimi : Form
    {
        public RolYonetimi()
        {
            InitializeComponent();
        }
        RolManager manager = new RolManager();
        Mesajlar mesajlar = new Mesajlar();
        void Yukle()
        {
            dgwRol.DataSource = manager.GetAll();
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
        private void RolYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void DgwRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgwRol.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dgwRol.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text=="")
            {
                mesajlar.MesajBosGecilemez();
            }
            else
            {
                var sonuc = manager.Add(
                new Rol
                {
                    Adi = txtAdi.Text
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
                var sonuc = manager.Update(
                new Rol
                {
                    Id = Convert.ToInt32(lblId.Text),
                    Adi = txtAdi.Text
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
