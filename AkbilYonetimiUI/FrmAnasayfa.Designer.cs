namespace AkbilYonetimiUI
{
    partial class FrmAnasayfa
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
            btnAkbil = new Button();
            btnTalimat = new Button();
            btnAyarlar = new Button();
            SuspendLayout();
            // 
            // btnAkbil
            // 
            btnAkbil.BackColor = Color.FromArgb(255, 128, 0);
            btnAkbil.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAkbil.ForeColor = Color.Black;
            btnAkbil.Location = new Point(92, 82);
            btnAkbil.Name = "btnAkbil";
            btnAkbil.Size = new Size(219, 93);
            btnAkbil.TabIndex = 0;
            btnAkbil.Text = "AKBİL İŞLEMLERİ";
            btnAkbil.UseVisualStyleBackColor = false;
            btnAkbil.Click += btnAkbil_Click;
            // 
            // btnTalimat
            // 
            btnTalimat.BackColor = Color.FromArgb(255, 128, 0);
            btnTalimat.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTalimat.ForeColor = Color.Black;
            btnTalimat.Location = new Point(382, 82);
            btnTalimat.Name = "btnTalimat";
            btnTalimat.Size = new Size(225, 93);
            btnTalimat.TabIndex = 1;
            btnTalimat.Text = "TALİMATLAR";
            btnTalimat.UseVisualStyleBackColor = false;
            btnTalimat.Click += btnTalimat_Click;
            // 
            // btnAyarlar
            // 
            btnAyarlar.BackColor = Color.FromArgb(255, 128, 0);
            btnAyarlar.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAyarlar.ForeColor = Color.Black;
            btnAyarlar.Location = new Point(241, 245);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(226, 88);
            btnAyarlar.TabIndex = 2;
            btnAyarlar.Text = "AYARLAR";
            btnAyarlar.UseVisualStyleBackColor = false;
            btnAyarlar.Click += btnAyarlar_Click;
            // 
            // FrmAnasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 451);
            Controls.Add(btnAyarlar);
            Controls.Add(btnTalimat);
            Controls.Add(btnAkbil);
            Name = "FrmAnasayfa";
            Text = "FrmAnasayfa";
            Load += FrmAnasayfa_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAkbil;
        private Button btnTalimat;
        private Button btnAyarlar;
    }
}