namespace AkbilYonetimiUI
{
    partial class FrmKayitOl
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtIsım = new TextBox();
            txtSoyisim = new TextBox();
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            btnGirisYap = new Button();
            btnKayitOl = new Button();
            dtpDogunTarihi = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 71);
            label1.Name = "label1";
            label1.Size = new Size(50, 28);
            label1.TabIndex = 0;
            label1.Text = "İsim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(47, 126);
            label2.Name = "label2";
            label2.Size = new Size(78, 28);
            label2.TabIndex = 1;
            label2.Text = "Soyisim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(47, 181);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(47, 229);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 3;
            label4.Text = "Şifre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(47, 283);
            label5.Name = "label5";
            label5.Size = new Size(128, 28);
            label5.TabIndex = 4;
            label5.Text = "Doğum Tarihi:";
            // 
            // txtIsım
            // 
            txtIsım.Location = new Point(216, 63);
            txtIsım.Name = "txtIsım";
            txtIsım.Size = new Size(253, 23);
            txtIsım.TabIndex = 5;
            // 
            // txtSoyisim
            // 
            txtSoyisim.Location = new Point(216, 118);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(253, 23);
            txtSoyisim.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(216, 173);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(216, 221);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(253, 23);
            txtSifre.TabIndex = 8;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Font = new Font("Segoe Print", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(47, 333);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(183, 40);
            btnGirisYap.TabIndex = 10;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Font = new Font("Segoe Print", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(286, 333);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(183, 40);
            btnKayitOl.TabIndex = 11;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // dtpDogunTarihi
            // 
            dtpDogunTarihi.Location = new Point(216, 285);
            dtpDogunTarihi.Name = "dtpDogunTarihi";
            dtpDogunTarihi.Size = new Size(253, 23);
            dtpDogunTarihi.TabIndex = 12;
            // 
            // FrmKayitOl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(601, 386);
            Controls.Add(dtpDogunTarihi);
            Controls.Add(btnKayitOl);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Controls.Add(txtSoyisim);
            Controls.Add(txtIsım);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmKayitOl";
            Text = "FrmKayitOl";
            FormClosed += FrmKayitOl_FormClosed;
            Load += FrmKayitOl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIsım;
        private TextBox txtSoyisim;
        private TextBox txtEmail;
        private TextBox txtSifre;
        private Button btnGirisYap;
        private Button btnKayitOl;
        private DateTimePicker dtpDogunTarihi;
    }
}