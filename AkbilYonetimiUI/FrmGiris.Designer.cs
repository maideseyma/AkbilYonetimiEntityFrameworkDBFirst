namespace AkbilYonetimiUI
{
    partial class FrmGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            checkBoxHatirla = new CheckBox();
            btnGirisYap = new Button();
            btnKayitOl = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 62);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 143);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(138, 67);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(217, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(138, 148);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(217, 23);
            txtSifre.TabIndex = 3;
            txtSifre.TextChanged += txtSifre_TextChanged;
            txtSifre.KeyPress += txtSifre_KeyPress;
            // 
            // checkBoxHatirla
            // 
            checkBoxHatirla.AutoSize = true;
            checkBoxHatirla.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxHatirla.Location = new Point(138, 296);
            checkBoxHatirla.Name = "checkBoxHatirla";
            checkBoxHatirla.Size = new Size(111, 27);
            checkBoxHatirla.TabIndex = 4;
            checkBoxHatirla.Text = "Beni Hatırla";
            checkBoxHatirla.UseVisualStyleBackColor = true;
            checkBoxHatirla.CheckedChanged += checkBoxHatirla_CheckedChanged;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Font = new Font("Segoe Print", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(20, 214);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(114, 46);
            btnGirisYap.TabIndex = 5;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Font = new Font("Segoe Print", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(241, 214);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(114, 46);
            btnKayitOl.TabIndex = 6;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.galata_kulesi_jpg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(815, 458);
            Controls.Add(btnKayitOl);
            Controls.Add(btnGirisYap);
            Controls.Add(checkBoxHatirla);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmGiris";
            Text = "FrmGiris";
            Load += FrmGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtSifre;
        private CheckBox checkBoxHatirla;
        private Button btnGirisYap;
        private Button btnKayitOl;
    }
}