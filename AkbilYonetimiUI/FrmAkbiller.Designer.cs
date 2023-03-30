namespace AkbilYonetimiUI
{
    partial class FrmAkbiller
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
            menuStrip1 = new MenuStrip();
            aNASAYFAToolStripMenuItem = new ToolStripMenuItem();
            cikisYAPToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btnKaydet = new Button();
            cmbBoxAkbilTipleri = new ComboBox();
            maskedTextBoxAkbilNo = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aNASAYFAToolStripMenuItem, cikisYAPToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(717, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aNASAYFAToolStripMenuItem
            // 
            aNASAYFAToolStripMenuItem.Name = "aNASAYFAToolStripMenuItem";
            aNASAYFAToolStripMenuItem.Size = new Size(77, 20);
            aNASAYFAToolStripMenuItem.Text = "ANASAYFA";
            aNASAYFAToolStripMenuItem.Click += aNASAYFAToolStripMenuItem_Click;
            // 
            // cikisYAPToolStripMenuItem
            // 
            cikisYAPToolStripMenuItem.Name = "cikisYAPToolStripMenuItem";
            cikisYAPToolStripMenuItem.Size = new Size(70, 20);
            cikisYAPToolStripMenuItem.Text = "ÇIKIŞ YAP";
            cikisYAPToolStripMenuItem.Click += cikisYAPToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 128);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(cmbBoxAkbilTipleri);
            groupBox1.Controls.Add(maskedTextBoxAkbilNo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(34, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 169);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Location = new Point(340, 53);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(107, 71);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // cmbBoxAkbilTipleri
            // 
            cmbBoxAkbilTipleri.FormattingEnabled = true;
            cmbBoxAkbilTipleri.Items.AddRange(new object[] { "Öğrenci Akbili", "Tam Akbil", "Anne Kartı", "65+ Kart", "Öğretmen Kart" });
            cmbBoxAkbilTipleri.Location = new Point(135, 116);
            cmbBoxAkbilTipleri.Name = "cmbBoxAkbilTipleri";
            cmbBoxAkbilTipleri.Size = new Size(140, 23);
            cmbBoxAkbilTipleri.TabIndex = 4;
            // 
            // maskedTextBoxAkbilNo
            // 
            maskedTextBoxAkbilNo.Location = new Point(135, 45);
            maskedTextBoxAkbilNo.Mask = "0000000000000000";
            maskedTextBoxAkbilNo.Name = "maskedTextBoxAkbilNo";
            maskedTextBoxAkbilNo.Size = new Size(140, 23);
            maskedTextBoxAkbilNo.TabIndex = 3;
            maskedTextBoxAkbilNo.MaskInputRejected += maskedTextBoxAkbilNo_MaskInputRejected;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 124);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 2;
            label2.Text = "Akbil TİP:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 53);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 0;
            label1.Text = "Akbil NO:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(640, 150);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmAkbiller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 413);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmAkbiller";
            Text = "FrmAkbiller";
            Load += FrmAkbiller_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aNASAYFAToolStripMenuItem;
        private ToolStripMenuItem cikisYAPToolStripMenuItem;
        private GroupBox groupBox1;
        private Button btnKaydet;
        private ComboBox cmbBoxAkbilTipleri;
        private MaskedTextBox maskedTextBoxAkbilNo;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}