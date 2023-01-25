using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using A04.Envanter.BL;

namespace A01.Envanter.WindowsApp
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        KullaniciManager manager = new KullaniciManager();
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            var kullanici = manager.Get(k => k.KullaniciAdi == txtAdi.Text && k.Sifre == txtSifre.Text && k.AktifMi==true);
            if (kullanici!=null)
            {
                AnaMenu anaMenu = new AnaMenu();
                anaMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}