
using System.Data.SqlClient;
using System.Text;
using AkbilYonetimiVeriKatmani;
using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani.Models;

namespace AkbilYonetimiUI

{
    public partial class FrmGiris : Form
    {
        public string Email { get; set; } // Kayıt ol formunda kayır olan kullanıcının emaili buraya gelsin

        AkbildbContext context = new AkbildbContext();
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            if (Email != null)
            {
                txtEmail.Text = Email;

            }
            txtEmail.TabIndex = 1;
            txtSifre.TabIndex = 2;
            checkBoxHatirla.TabIndex = 3;
            btnGirisYap.TabIndex = 4;
            btnKayitOl.TabIndex = 5;
            txtSifre.PasswordChar = '*';

            //beni hatirlayi Properties.Settings ile yapana kadar burası böyle kolaylık saglasin
            txtEmail.Text = "maideseymaersahan@gmail.com";
            txtSifre.Text = "123456";


        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            // Bu formu gizleyeceğiz.
            // Kayıt ol formunu açacağız.
            this.Hide();
            FrmKayitOl frm = new FrmKayitOl();
            frm.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

        private void GirisYap()
        {
            try

            {
                // 1) Email ve şifre textboxları dolu mu?
                if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSifre.Text))
                {
                    MessageBox.Show("Bilgileri eksiksiz giriniz!",
                        "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                // 2) Girdiği email ve şifre veritabanında mevcur mu?
                var kullanici = context.Kullanicilars.FirstOrDefault(x => x.Email == txtEmail.Text && x.Parola == GenelIslemler.MD5Encryption(txtSifre.Text));

                if (kullanici == null)
                {
                    MessageBox.Show("Email ya da şifrenizi yanlış girdiniz!");
                    return;

                }

                else
                {
                    MessageBox.Show($"HOŞGELDİNİZ... {kullanici.Ad} {kullanici.Soyad}");
                    GenelIslemler.GirisYapanKullaniciID = kullanici.Id;
                    GenelIslemler.GirisYapanKullaniciEmail = kullanici.Email;
                    GenelIslemler.GirisYapanKullaniciAdSoyad = $" {kullanici.Ad} {kullanici.Soyad}";

                    // beni hatılayı settings ile yazalım...

                    // temizlik
                    txtEmail.Clear(); txtSifre.Clear();
                    FrmAnasayfa frmAnasayfa = new FrmAnasayfa();
                    this.Hide();
                    frmAnasayfa.Show();

                }
            }
            catch (Exception hata)
            {
                // DipNot exceptionlar asla kullanıcıya gösterilmez
                // Exceptionlar loglanır. Biz şu an öğrenme / geliştirme aşamasında olduğumuz için yazdık.
                MessageBox.Show("Beklenmedik bir sorun oluştu!" + hata.Message);
            }
        }

        private void checkBoxHatirla_CheckedChanged(object sender, EventArgs e)
        {
            BeniHatirla();
        }

        private void BeniHatirla()
        {


        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) // basılan tuş enter ise griş yapacak


            {
                GirisYap();
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}