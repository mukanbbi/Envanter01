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
        }
        private void DomainYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        private void DgwDomain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {

        }

       

    
    }
}
