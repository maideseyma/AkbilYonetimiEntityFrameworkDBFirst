using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkbilYonetimiUI
{
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            dtpDogumTarihi.MaxDate = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Value = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;


            KullanicininBilgileriniGetir();
        }

        private void KullanicininBilgileriniGetir()
        {
            try
            {
                // NOT: Giriş yapmış kullanıcının bilgileri ile select sorgusu yazacağız
                // Kullanıcı bilgisini alabilmek için burada iki yöntem kullabilirz
                // Static bir class açıp içinde GirişYapmışKullaniciEmail propertysi kullanılabilir
                // 2. yöntem olarak properties settings içine kayıtlı email bilgisinden yararlanabilir

              
            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik hata oluştu!" + hata.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                

               
            }
            catch (Exception hata)
            {

                MessageBox.Show("Güncelleme BAŞARISIZDIR" + hata.Message);
            }
        }
    }
}
