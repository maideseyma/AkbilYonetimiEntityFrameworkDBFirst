using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani;
using AkbilYonetimiVeriKatmani.Models;

namespace AkbilYonetimiUI
{
    public partial class FrmTalimatlar : Form
    {
        AkbildbContext context = new AkbildbContext();
        public FrmTalimatlar()
        {
            InitializeComponent();
        }

        private void FrmTalimatlar_Load(object sender, EventArgs e)
        {
            // Comboxa akbilleri getir
            ComboBoxaKullanicininAkbilleriniGetir();
            //cmbBoxAkbiller.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxAkbiller.SelectedIndex = -1;
            cmbBoxAkbiller.Text = "Akbil seçiniz...";
            groupBoxYukleme.Enabled = false;

            TalimatlariDataGrideGetir();

            checkBoxTumunuGoster.Checked = false;
            BekleyenTalimatSayisiniGetir();
            timerBekleyenTalimat.Interval = 1000;
            timerBekleyenTalimat.Enabled = true;

            dataGridViewTalimatlar.ContextMenuStrip = contextMenuStrip1;
            dataGridViewTalimatlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BekleyenTalimatSayisiniGetir()
        {
            try
            {
                // burada bekleyen talimatları bulur
                var bekleyen = context.KullanicininTalimatlaris.Where(x => x.KullaniciId == GenelIslemler.GirisYapanKullaniciID && !x.YuklendiMi);

                if (cmbBoxAkbiller.SelectedIndex >= 0)
                {
                    // burada ise bekleyen talimatlar içinden sadece comboda seçili olanın sayısını alıyoruz
                    lblBekleyenTalimat.Text = bekleyen.Count(x => x.Akbil.Substring(0, 16) == cmbBoxAkbiller.SelectedValue.ToString()).ToString();
                }
                else
                {
                    // bekleyen talimatı yukarıda almıştık. Aldığımız sonucu count ile saydık
                    lblBekleyenTalimat.Text = bekleyen.Count().ToString();
                }

            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu!" + hata.Message);
            }

        }

        private void TalimatlariDataGrideGetir(bool tumunuGoster = false)
        {
            try
            {
                var talimatlar = context.KullanicininTalimatlaris.Where(x => x.KullaniciId == GenelIslemler.GirisYapanKullaniciID);

                if (!tumunuGoster)
                {
                    talimatlar = talimatlar.Where(x => !x.YuklendiMi);
                }

                if (cmbBoxAkbiller.SelectedIndex >= 0)
                {
                    talimatlar = talimatlar.Where(x => x.Akbil.Substring(0, 16) == cmbBoxAkbiller.SelectedValue.ToString());
                }

                dataGridViewTalimatlar.DataSource = talimatlar.ToList();
            

                //dataGridViewTalimatlar.DataSource = 

                dataGridViewTalimatlar.Columns["Id"].Visible = false;
                dataGridViewTalimatlar.Columns["KullaniciId"].Visible = false;
                dataGridViewTalimatlar.Columns["YuklendiMi"].HeaderText = "Talimat Yüklendi Mi?";

                foreach (DataGridViewColumn item in dataGridViewTalimatlar.Columns)
                {
                    item.Width = 200;
                }
                dataGridViewTalimatlar.Columns["Akbil"].Width = 400;

                //istediğiniz diğer kolonlara da ayarlama yapabilirsiniz.
            }
            catch (Exception hata)
            {
                MessageBox.Show("Talimatlar getirilirken hata oluştu! " + hata.Message);
            }
        }

        private void ComboBoxaKullanicininAkbilleriniGetir()
        {
            try
            {
                cmbBoxAkbiller.DataSource = context.Akbillers.Where(x => x.AkbilSahibiId == GenelIslemler.GirisYapanKullaniciID).ToList();
                cmbBoxAkbiller.DisplayMember = "AkbilNo";
                cmbBoxAkbiller.ValueMember = "AkbilNo";
            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu!" + hata.Message);
            }
        }

        private void cmbBoxAkbiller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxAkbiller.SelectedIndex >= 0)

            {
                txtYuklenecekTutar.Clear();
                groupBoxYukleme.Enabled = true;
                
            }
            else
            {
                txtYuklenecekTutar.Clear();
                groupBoxYukleme.Enabled = false;
             
            }
            BekleyenTalimatSayisiniGetir();
            TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);

        }

        private void btnTalimatKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBoxAkbiller.SelectedIndex < 0)
                {
                    MessageBox.Show("Akbil seçmeden talimat kaydedilemez!");
                    return;
                }
                if (string.IsNullOrEmpty(txtYuklenecekTutar.Text))
                {
                    MessageBox.Show("Yüklenn miktar girişi zorunludur!");
                    return;

                }
                if (!decimal.TryParse(txtYuklenecekTutar.Text.Trim(), out decimal tutar))
                {
                    MessageBox.Show("Yükleme miktarı girişi uygun formatta olmalıdır!");
                    return;
                }

                Talimatlar yeniTalimat = new Talimatlar()
                {
                    EklenmeTarihi = DateTime.Now,
                    AkbilId = cmbBoxAkbiller.SelectedValue.ToString(),
                    YuklendiMi=false,
                    YuklenecekTutar=Convert.ToDecimal(txtYuklenecekTutar.Text),
                    YuklenmeTarihi=null


                };

                context.Talimatlars.Add(yeniTalimat);
                if (context.SaveChanges() >0)
                {
                    MessageBox.Show("Yeni talimat eklendi");
                    //temizlik
                    txtYuklenecekTutar.Clear();
                    //cmbBoxAkbiller.SelectedIndex = -1;
                    //cmbBoxAkbiller.Text = "Akbil Seçiniz";

                    groupBoxYukleme.Enabled = false;

                    BekleyenTalimatSayisiniGetir();
                    TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);
                    
                }
                else
                {
                    MessageBox.Show("Yeni talimat EKLENEMEDİ");
                }

            }
            catch (Exception hata)
            {

                MessageBox.Show("Talimat kaydedilemedi!" + hata.Message);
            }
        }

        private void checkBoxTumunuGoster_CheckedChanged(object sender, EventArgs e)
        {
            // if yazılsa daha iyi olurdu

            TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);
        }

        private void aNAMENÜToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frma = new FrmAnasayfa();
            this.Hide();
            frma.Show();



        }

        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güle güle çıkış yapıldı... ");
            //GenelIslemler.GirisYapanKullaniciAdSoyad = string.Empty;
            //GenelIslemler.GirisYapanKullaniciID = 0;

            FrmGiris giris = new FrmGiris();
            foreach (Form item in Application.OpenForms)
            {
                
                
                    item.Hide();
                }
               giris.Show();
            }

        private void lblBekleyenTalimat_Click(object sender, EventArgs e)
        {

        }

        private void timerBekleyenTalimat_Tick(object sender, EventArgs e)
        {
            if (lblBekleyenTalimat.Text != "0")
            {
                if (DateTime.Now.Second % 2 == 0)
                {
                    lblBekleyenTalimat.Font = new Font("Times New Roman", 30);
                    lblBekleyenTalimat.ForeColor = Color.OrangeRed;

                }
                else
                {
                    lblBekleyenTalimat.Font = new Font("Times New Roman", 15);
                    lblBekleyenTalimat.ForeColor = Color.OrangeRed;
                }
            }
        }

        private void talimatiYukleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int sayac = 0;
                foreach (DataGridViewRow item in dataGridViewTalimatlar.SelectedRows)
                {
                    if ((bool)item.Cells["Yuklendimi"].Value)
                    {
                        continue;
                    }
                    // önce talimatı yükledimi=1 yapacağız
                    var secilenTalimat = context.Talimatlars.FirstOrDefault(x => x.Id == (int)item.Cells["Id"].Value);

                    if (secilenTalimat!=null)
                    {
                        secilenTalimat.YuklendiMi = true;
                        secilenTalimat.YuklenmeTarihi = DateTime.Now;
                        context.Talimatlars.Update(secilenTalimat);
                        context.SaveChanges();

                        // sonra akbilin bakiyesine ekleme yapacağız
                        secilenTalimat.Akbil.Bakiye += Convert.ToDecimal(item.Cells["YuklenecekTutar"].Value);

                        context.Akbillers.Update(secilenTalimat.Akbil);

                        context.SaveChanges();
                        sayac++;


                    }


                } // foreach bitti.
                MessageBox.Show($"{sayac} adet talimat akbile yüklendi!");
                TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);
                BekleyenTalimatSayisiniGetir();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu!" + hata.Message);
            }
        }

        private void talimatiIptalEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int sayac = 0;
                foreach (DataGridViewRow item in dataGridViewTalimatlar.SelectedRows)
                {
                    //Yüklenmiş bir talimat iptal edilemez/silinemez.
                    if ((bool)item.Cells["YuklendiMi"].Value)
                    {
                        MessageBox.Show($"DİKKAT! {item.Cells["Akbil"].Value} {item.Cells["Yüklenecek Tutar"].Value} liralık yüklemesi yapılmıştır. YÜKLENEN TALİMAT İPTAL EDİLEMEZ/SİLİNEMEZ! \nİşlemlerinize devam etmek için tamama basınız.");
                        continue;
                    } // if bitti


                    var secilenTalimat = context.Talimatlars.FirstOrDefault(x => x.Id == (int)item.Cells["Id"].Value);
                    if (secilenTalimat!=null)
                    {
                        context.Talimatlars.Remove(secilenTalimat);
                        sayac += context.SaveChanges();
                    }

                } // foreach bitti

                MessageBox.Show($"Seçtiğiniz {sayac} adet talimat iptal edilmiştir.");
                TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);
                BekleyenTalimatSayisiniGetir();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir sorun oluştu! " + hata.Message);
            }
        }

    }
}