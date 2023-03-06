namespace PersonelTakip
{
    partial class FrmİşListesi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.temizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbBaslamaTarihi = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblİşDurum = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblİs = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbPozisyon = new System.Windows.Forms.ComboBox();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.LblSoyAD = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtSoyAD = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnkapat = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.AdminPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AdminPanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 187);
            this.panel1.TabIndex = 0;
            // 
            // AdminPanel
            // 
            this.AdminPanel.Controls.Add(this.temizle);
            this.AdminPanel.Controls.Add(this.btnAra);
            this.AdminPanel.Controls.Add(this.groupBox1);
            this.AdminPanel.Controls.Add(this.comboBox1);
            this.AdminPanel.Controls.Add(this.dateTimePicker2);
            this.AdminPanel.Controls.Add(this.dateTimePicker1);
            this.AdminPanel.Controls.Add(this.lblİşDurum);
            this.AdminPanel.Controls.Add(this.lblBitis);
            this.AdminPanel.Controls.Add(this.label2);
            this.AdminPanel.Controls.Add(this.lblİs);
            this.AdminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPanel.Location = new System.Drawing.Point(334, 0);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(532, 187);
            this.AdminPanel.TabIndex = 1;
            this.AdminPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminPanel_Paint);
            // 
            // temizle
            // 
            this.temizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.temizle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizle.ForeColor = System.Drawing.Color.White;
            this.temizle.Location = new System.Drawing.Point(183, 136);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(95, 45);
            this.temizle.TabIndex = 4;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = false;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAra.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(82, 136);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(95, 45);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rbBaslamaTarihi);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(331, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşTeslim";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(113, 23);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "TeslimTarihi";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbBaslamaTarihi
            // 
            this.rbBaslamaTarihi.AutoSize = true;
            this.rbBaslamaTarihi.Location = new System.Drawing.Point(18, 20);
            this.rbBaslamaTarihi.Name = "rbBaslamaTarihi";
            this.rbBaslamaTarihi.Size = new System.Drawing.Size(127, 23);
            this.rbBaslamaTarihi.TabIndex = 0;
            this.rbBaslamaTarihi.TabStop = true;
            this.rbBaslamaTarihi.Text = "BaslamaTarihi";
            this.rbBaslamaTarihi.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 27);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(125, 73);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblİşDurum
            // 
            this.lblİşDurum.AutoSize = true;
            this.lblİşDurum.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblİşDurum.Location = new System.Drawing.Point(8, 106);
            this.lblİşDurum.Name = "lblİşDurum";
            this.lblİşDurum.Size = new System.Drawing.Size(82, 19);
            this.lblİşDurum.TabIndex = 10;
            this.lblİşDurum.Text = "İş Durumu";
            this.lblİşDurum.Click += new System.EventHandler(this.lblİşDurum_Click);
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitis.Location = new System.Drawing.Point(3, 73);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(87, 19);
            this.lblBitis.TabIndex = 11;
            this.lblBitis.Text = "Bitiş Tarihi";
            this.lblBitis.Click += new System.EventHandler(this.lblBitis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Başlama Tarihi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblİs
            // 
            this.lblİs.AutoSize = true;
            this.lblİs.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblİs.Location = new System.Drawing.Point(6, 12);
            this.lblİs.Name = "lblİs";
            this.lblİs.Size = new System.Drawing.Size(67, 19);
            this.lblİs.TabIndex = 11;
            this.lblİs.Text = "İş Tarihi";
            this.lblİs.Click += new System.EventHandler(this.lblİs_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbPozisyon);
            this.panel3.Controls.Add(this.cmbDepartman);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblDepartman);
            this.panel3.Controls.Add(this.LblSoyAD);
            this.panel3.Controls.Add(this.lblAd);
            this.panel3.Controls.Add(this.txtSoyAD);
            this.panel3.Controls.Add(this.txtAd);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtUserNo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 187);
            this.panel3.TabIndex = 0;
            // 
            // cmbPozisyon
            // 
            this.cmbPozisyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPozisyon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPozisyon.FormattingEnabled = true;
            this.cmbPozisyon.Location = new System.Drawing.Point(120, 136);
            this.cmbPozisyon.Name = "cmbPozisyon";
            this.cmbPozisyon.Size = new System.Drawing.Size(121, 27);
            this.cmbPozisyon.TabIndex = 4;
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(120, 103);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(121, 27);
            this.cmbDepartman.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pozisyon";
            // 
            // lblDepartman
            // 
            this.lblDepartman.AutoSize = true;
            this.lblDepartman.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartman.Location = new System.Drawing.Point(3, 106);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(111, 19);
            this.lblDepartman.TabIndex = 8;
            this.lblDepartman.Text = "Departman Adı";
            // 
            // LblSoyAD
            // 
            this.LblSoyAD.AutoSize = true;
            this.LblSoyAD.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSoyAD.Location = new System.Drawing.Point(3, 70);
            this.LblSoyAD.Name = "LblSoyAD";
            this.LblSoyAD.Size = new System.Drawing.Size(52, 19);
            this.LblSoyAD.TabIndex = 7;
            this.LblSoyAD.Text = "SoyAd";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(3, 38);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(32, 19);
            this.lblAd.TabIndex = 6;
            this.lblAd.Text = "AD";
            // 
            // txtSoyAD
            // 
            this.txtSoyAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyAD.Location = new System.Drawing.Point(109, 66);
            this.txtSoyAD.Name = "txtSoyAD";
            this.txtSoyAD.Size = new System.Drawing.Size(132, 26);
            this.txtSoyAD.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(109, 34);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(132, 26);
            this.txtAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txtUserNo
            // 
            this.txtUserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserNo.Location = new System.Drawing.Point(109, 5);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(132, 26);
            this.txtUserNo.TabIndex = 0;
            this.txtUserNo.TextChanged += new System.EventHandler(this.txtUserNo_TextChanged);
            this.txtUserNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserNo_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnkapat);
            this.panel2.Controls.Add(this.btnsil);
            this.panel2.Controls.Add(this.btnGüncelle);
            this.panel2.Controls.Add(this.btnOnayla);
            this.panel2.Controls.Add(this.btnEkle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnkapat
            // 
            this.btnkapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnkapat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkapat.ForeColor = System.Drawing.Color.White;
            this.btnkapat.Location = new System.Drawing.Point(519, 28);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(105, 45);
            this.btnkapat.TabIndex = 4;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.UseVisualStyleBackColor = false;
            this.btnkapat.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsil.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.White;
            this.btnsil.Location = new System.Drawing.Point(398, 28);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(103, 45);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGüncelle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ForeColor = System.Drawing.Color.White;
            this.btnGüncelle.Location = new System.Drawing.Point(277, 28);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(115, 45);
            this.btnGüncelle.TabIndex = 2;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOnayla.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.ForeColor = System.Drawing.Color.White;
            this.btnOnayla.Location = new System.Drawing.Point(75, 28);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(95, 45);
            this.btnOnayla.TabIndex = 0;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEkle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(176, 28);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(95, 45);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(866, 163);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmİşListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmİşListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmİşListesi";
            this.Load += new System.EventHandler(this.FrmİşListesi_Load);
            this.panel1.ResumeLayout(false);
            this.AdminPanel.ResumeLayout(false);
            this.AdminPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblSoyAD;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtSoyAD;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserNo;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbBaslamaTarihi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblİşDurum;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblİs;
        private System.Windows.Forms.ComboBox cmbPozisyon;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.Button btnAra;
    }
}