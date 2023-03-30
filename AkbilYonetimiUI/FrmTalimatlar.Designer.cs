namespace AkbilYonetimiUI
{
    partial class FrmTalimatlar
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            aNAMENÜToolStripMenuItem = new ToolStripMenuItem();
            cikisYapToolStripMenuItem = new ToolStripMenuItem();
            cmbBoxAkbiller = new ComboBox();
            label1 = new Label();
            btnTalimatKaydet = new Button();
            txtYuklenecekTutar = new TextBox();
            label8 = new Label();
            lblBekleyenTalimat = new Label();
            checkBoxTumunuGoster = new CheckBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            talimatiYukleToolStripMenuItem = new ToolStripMenuItem();
            talimatiIptalEtToolStripMenuItem = new ToolStripMenuItem();
            timerBekleyenTalimat = new System.Windows.Forms.Timer(components);
            dataGridViewTalimatlar = new DataGridView();
            groupBoxYukleme = new GroupBox();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTalimatlar).BeginInit();
            groupBoxYukleme.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aNAMENÜToolStripMenuItem, cikisYapToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1002, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aNAMENÜToolStripMenuItem
            // 
            aNAMENÜToolStripMenuItem.Name = "aNAMENÜToolStripMenuItem";
            aNAMENÜToolStripMenuItem.Size = new Size(81, 20);
            aNAMENÜToolStripMenuItem.Text = "ANA MENÜ";
            aNAMENÜToolStripMenuItem.Click += aNAMENÜToolStripMenuItem_Click;
            // 
            // cikisYapToolStripMenuItem
            // 
            cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            cikisYapToolStripMenuItem.Size = new Size(70, 20);
            cikisYapToolStripMenuItem.Text = "ÇIKIŞ YAP";
            cikisYapToolStripMenuItem.Click += cikisYapToolStripMenuItem_Click;
            // 
            // cmbBoxAkbiller
            // 
            cmbBoxAkbiller.FormattingEnabled = true;
            cmbBoxAkbiller.Location = new Point(53, 61);
            cmbBoxAkbiller.Name = "cmbBoxAkbiller";
            cmbBoxAkbiller.Size = new Size(449, 23);
            cmbBoxAkbiller.TabIndex = 1;
            cmbBoxAkbiller.SelectedIndexChanged += cmbBoxAkbiller_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 2;
            label1.Text = "Yüklenecek Tutar:";
            // 
            // btnTalimatKaydet
            // 
            btnTalimatKaydet.Location = new Point(339, 32);
            btnTalimatKaydet.Name = "btnTalimatKaydet";
            btnTalimatKaydet.Size = new Size(75, 23);
            btnTalimatKaydet.TabIndex = 3;
            btnTalimatKaydet.Text = "KAYDET";
            btnTalimatKaydet.UseVisualStyleBackColor = true;
            btnTalimatKaydet.Click += btnTalimatKaydet_Click;
            // 
            // txtYuklenecekTutar
            // 
            txtYuklenecekTutar.Location = new Point(140, 32);
            txtYuklenecekTutar.Name = "txtYuklenecekTutar";
            txtYuklenecekTutar.Size = new Size(100, 23);
            txtYuklenecekTutar.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(626, 61);
            label8.Name = "label8";
            label8.Size = new Size(127, 19);
            label8.TabIndex = 5;
            label8.Text = "Bekleyen Talimat";
            label8.Click += lblBekleyenTalimat_Click;
            // 
            // lblBekleyenTalimat
            // 
            lblBekleyenTalimat.AutoSize = true;
            lblBekleyenTalimat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBekleyenTalimat.Location = new Point(687, 164);
            lblBekleyenTalimat.Name = "lblBekleyenTalimat";
            lblBekleyenTalimat.Size = new Size(17, 19);
            lblBekleyenTalimat.TabIndex = 6;
            lblBekleyenTalimat.Text = "0";
            // 
            // checkBoxTumunuGoster
            // 
            checkBoxTumunuGoster.AutoSize = true;
            checkBoxTumunuGoster.Location = new Point(53, 215);
            checkBoxTumunuGoster.Name = "checkBoxTumunuGoster";
            checkBoxTumunuGoster.Size = new Size(108, 19);
            checkBoxTumunuGoster.TabIndex = 7;
            checkBoxTumunuGoster.Text = "Tümünü Göster";
            checkBoxTumunuGoster.UseVisualStyleBackColor = true;
            checkBoxTumunuGoster.CheckedChanged += checkBoxTumunuGoster_CheckedChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { talimatiYukleToolStripMenuItem, talimatiIptalEtToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(155, 48);
            contextMenuStrip1.Text = "SİL";
            // 
            // talimatiYukleToolStripMenuItem
            // 
            talimatiYukleToolStripMenuItem.Name = "talimatiYukleToolStripMenuItem";
            talimatiYukleToolStripMenuItem.Size = new Size(154, 22);
            talimatiYukleToolStripMenuItem.Text = "Talimati Yükle";
            talimatiYukleToolStripMenuItem.Click += talimatiYukleToolStripMenuItem_Click;
            // 
            // talimatiIptalEtToolStripMenuItem
            // 
            talimatiIptalEtToolStripMenuItem.Name = "talimatiIptalEtToolStripMenuItem";
            talimatiIptalEtToolStripMenuItem.Size = new Size(154, 22);
            talimatiIptalEtToolStripMenuItem.Text = "Talimatı İptal Et";
            talimatiIptalEtToolStripMenuItem.Click += talimatiIptalEtToolStripMenuItem_Click;
            // 
            // timerBekleyenTalimat
            // 
            timerBekleyenTalimat.Tick += timerBekleyenTalimat_Tick;
            // 
            // dataGridViewTalimatlar
            // 
            dataGridViewTalimatlar.AllowUserToAddRows = false;
            dataGridViewTalimatlar.AllowUserToDeleteRows = false;
            dataGridViewTalimatlar.AllowUserToOrderColumns = true;
            dataGridViewTalimatlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTalimatlar.Location = new Point(24, 257);
            dataGridViewTalimatlar.Name = "dataGridViewTalimatlar";
            dataGridViewTalimatlar.ReadOnly = true;
            dataGridViewTalimatlar.RowTemplate.Height = 25;
            dataGridViewTalimatlar.Size = new Size(957, 150);
            dataGridViewTalimatlar.TabIndex = 9;
            // 
            // groupBoxYukleme
            // 
            groupBoxYukleme.Controls.Add(label1);
            groupBoxYukleme.Controls.Add(txtYuklenecekTutar);
            groupBoxYukleme.Controls.Add(btnTalimatKaydet);
            groupBoxYukleme.Location = new Point(53, 113);
            groupBoxYukleme.Name = "groupBoxYukleme";
            groupBoxYukleme.Size = new Size(449, 70);
            groupBoxYukleme.TabIndex = 10;
            groupBoxYukleme.TabStop = false;
            // 
            // FrmTalimatlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 419);
            Controls.Add(groupBoxYukleme);
            Controls.Add(dataGridViewTalimatlar);
            Controls.Add(checkBoxTumunuGoster);
            Controls.Add(lblBekleyenTalimat);
            Controls.Add(label8);
            Controls.Add(cmbBoxAkbiller);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmTalimatlar";
            Text = "FrmTalimatlar";
            Load += FrmTalimatlar_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTalimatlar).EndInit();
            groupBoxYukleme.ResumeLayout(false);
            groupBoxYukleme.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aNAMENÜToolStripMenuItem;
        private ToolStripMenuItem cikisYapToolStripMenuItem;
        private ComboBox cmbBoxAkbiller;
        private Label label1;
        private Button btnTalimatKaydet;
        private TextBox txtYuklenecekTutar;
        private Label label8;
        private Label lblBekleyenTalimat;
        private CheckBox checkBoxTumunuGoster;
        private ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timerBekleyenTalimat;
        private DataGridView dataGridViewTalimatlar;
        private GroupBox groupBoxYukleme;
        private ToolStripMenuItem talimatiYukleToolStripMenuItem;
        private ToolStripMenuItem talimatiIptalEtToolStripMenuItem;
    }
}