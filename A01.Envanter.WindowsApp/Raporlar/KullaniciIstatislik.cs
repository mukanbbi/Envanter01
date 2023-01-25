
using A04.Envanter.BL;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace A01.Envanter.WindowsApp.Raporlar
{
    public partial class KullaniciIstatislik : Form
    {
        public KullaniciIstatislik()
        {
            InitializeComponent();
        }
        //DatabaseContext context = new DatabaseContext();
        MailManager mailManager = new MailManager();
       


        private void KullaniciIstatislik_Load(object sender, EventArgs e)
        {
            //lblToplamPersonel.Text = context.Mailler.Count().ToString();
            
            

        }
    }
}
