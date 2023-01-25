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
            MessageBox.Show("Kayıt Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void MesajEklendi()
        {
            MessageBox.Show("Kayıt Eklendi.", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void MesajGuncellendi()
        {
            MessageBox.Show("Kayıt Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void MesajKayitSec()
        {
            MessageBox.Show("Lütfen Listeden Bir Kayıt Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void MesajHata()
        {
            MessageBox.Show("Hata Oluştu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void MesajBosGecilemez()
        {
            MessageBox.Show("Boş geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
