using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A04.Envanter.BL
{
    public class Mesajlar
    {
        public void MesajSilindi()
        {
            MessageBox.Show("Kayıt Silindi.", "Bilgi");
        }
        public void MesajEklendi()
        {
            MessageBox.Show("Kayıt Eklendi.", "Bilgi");
        }
        public void MesajGuncellendi()
        {
            MessageBox.Show("Kayıt Güncellendi.", "Bilgi");
        }
        public void MesajKayitSec()
        {
            MessageBox.Show("Lütfen Listeden Bir Kayıt Seçiniz.", "Bilgi");
        }
        public void MesajHata()
        {
            MessageBox.Show("Hata Oluştu.", "Bilgi");
        }
        public void MesajBosGecilemez()
        {
            MessageBox.Show("Boş geçilemez", "Uyarı");
        }
    }
}
