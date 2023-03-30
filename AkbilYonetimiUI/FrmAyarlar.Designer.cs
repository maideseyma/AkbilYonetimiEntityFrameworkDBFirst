namespace AkbilYonetimiUI
{
    partial class FrmAyarlar
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
            btnGuncelle = new Button();
            txtEmail = new TextBox();
            txtİsim = new TextBox();
            txtSoyisim = new TextBox();
            txtSifre = new TextBox();
            dtpDogumTarihi = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 63);
            label1.Name = "label1";
            label1.Size = new Size(58, 26);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 122);
            label2.Name = "label2";
            label2.Size = new Size(46, 26);
            label2.TabIndex = 1;
            label2.Text = "İsim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 176);
            label3.Name = "label3";
            label3.Size = new Size(72, 26);
            label3.TabIndex = 2;
            label3.Text = "Soyisim:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(371, 76);
            label4.Name = "label4";
            label4.Size = new Size(119, 26);
            label4.TabIndex = 3;
            label4.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(371, 132);
            label5.Name = "label5";
            label5.Size = new Size(90, 26);
            label5.TabIndex = 4;
            label5.Text = "Yeni Şifre:";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(278, 259);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(234, 75);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = " BİLGİLERİ GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(147, 55);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtİsim
            // 
            txtİsim.Location = new Point(147, 114);
            txtİsim.Name = "txtİsim";
            txtİsim.Size = new Size(200, 23);
            txtİsim.TabIndex = 7;
            // 
            // txtSoyisim
            // 
            txtSoyisim.Location = new Point(147, 168);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(200, 23);
            txtSoyisim.TabIndex = 8;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(501, 136);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(200, 23);
            txtSifre.TabIndex = 10;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(501, 76);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(200, 23);
            dtpDogumTarihi.TabIndex = 11;
            // 
            // FrmAyarlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(795, 422);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(txtSifre);
            Controls.Add(txtSoyisim);
            Controls.Add(txtİsim);
            Controls.Add(txtEmail);
            Controls.Add(btnGuncelle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAyarlar";
            Text = "FrmAyarlar";
            Load += FrmAyarlar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnGuncelle;
        private TextBox txtEmail;
        private TextBox txtİsim;
        private TextBox txtSoyisim;
        private TextBox txtSifre;
        private DateTimePicker dtpDogumTarihi;
    }
}