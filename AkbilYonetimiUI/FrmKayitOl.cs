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
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent(); // İnşa etmek
        }

        private void FrmKayitOl_Load(object sender, EventArgs e)
        {
            #region Ayarlar
            txtSifre.PasswordChar = '*';
            dtpDogunTarihi.MaxDate = new DateTime(2016, 1, 1);
            dtpDogunTarihi.Value = new DateTime(2016, 1, 1);
            dtpDogunTarihi.Format = DateTimePickerFormat.Short;

            #endregion
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
               foreach (var item in Controls)
                {
                    if (item is TextBox && string.IsNullOrEmpty(((TextBox)item).Text))
                    {
                        MessageBox.Show("Zorunlu alanları doldurunuz!");
                        return;
                    }
                }


            
            }
            catch (Exception ex)
            {
                // ex log.txt'ye yazılanacak (loglama)
                MessageBox.Show("Beklenmedik bir hata oluştu! Lütfen tekrar deneyiniz !");
            }
        }

        private void GirisFormunaGit()
        {
            FrmGiris frmG = new FrmGiris();
            frmG.Email = txtEmail.Text.Trim();
            this.Hide();
            frmG.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            GirisFormunaGit();
        }

        private void FrmKayitOl_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisFormunaGit();
        }
    }
}
