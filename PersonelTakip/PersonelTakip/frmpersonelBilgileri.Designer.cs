namespace PersonelTakip
{
    partial class FrmPersonelBilgileri
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
            this.chckAdmin = new System.Windows.Forms.CheckBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btncontrol = new System.Windows.Forms.Button();
            this.lblkullanıcı = new System.Windows.Forms.Label();
            this.txtkullanıcı = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtresim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pctResim = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.lblMaas = new System.Windows.Forms.Label();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.lblPozisyon = new System.Windows.Forms.Label();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.cmbPozisyon = new System.Windows.Forms.ComboBox();
            this.dogum = new System.Windows.Forms.Label();
            this.DogumGunu = new System.Windows.Forms.DateTimePicker();
            this.adres = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctResim)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chckAdmin);
            this.panel1.Controls.Add(this.lblsifre);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.btncontrol);
            this.panel1.Controls.Add(this.lblkullanıcı);
            this.panel1.Controls.Add(this.txtkullanıcı);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 47);
            this.panel1.TabIndex = 0;
            // 
            // chckAdmin
            // 
            this.chckAdmin.AutoSize = true;
            this.chckAdmin.Location = new System.Drawing.Point(534, 9);
            this.chckAdmin.Name = "chckAdmin";
            this.chckAdmin.Size = new System.Drawing.Size(55, 17);
            this.chckAdmin.TabIndex = 6;
            this.chckAdmin.Text = "Admin";
            this.chckAdmin.UseVisualStyleBackColor = true;
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.Location = new System.Drawing.Point(358, 5);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(41, 19);
            this.lblsifre.TabIndex = 4;
            this.lblsifre.Text = "Şifre";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(405, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(123, 26);
            this.txtPassword.TabIndex = 5;
            // 
            // btncontrol
            // 
            this.btncontrol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncontrol.Location = new System.Drawing.Point(238, 3);
            this.btncontrol.Name = "btncontrol";
            this.btncontrol.Size = new System.Drawing.Size(84, 30);
            this.btncontrol.TabIndex = 3;
            this.btncontrol.Text = "Control";
            this.btncontrol.UseVisualStyleBackColor = true;
            // 
            // lblkullanıcı
            // 
            this.lblkullanıcı.AutoSize = true;
            this.lblkullanıcı.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullanıcı.Location = new System.Drawing.Point(3, 9);
            this.lblkullanıcı.Name = "lblkullanıcı";
            this.lblkullanıcı.Size = new System.Drawing.Size(100, 19);
            this.lblkullanıcı.TabIndex = 1;
            this.lblkullanıcı.Text = "Kullanıcı Adı";
            // 
            // txtkullanıcı
            // 
            this.txtkullanıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullanıcı.Location = new System.Drawing.Point(109, 5);
            this.txtkullanıcı.Name = "txtkullanıcı";
            this.txtkullanıcı.Size = new System.Drawing.Size(123, 26);
            this.txtkullanıcı.TabIndex = 2;
            this.txtkullanıcı.TextChanged += new System.EventHandler(this.txtkullanıcı_TextChanged);
            this.txtkullanıcı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkullanıcı_KeyPress);
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(109, 70);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(123, 26);
            this.txtad.TabIndex = 2;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(3, 74);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(32, 19);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "AD";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(109, 102);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(123, 26);
            this.txtSoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "SoyAd";
            // 
            // txtresim
            // 
            this.txtresim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtresim.Location = new System.Drawing.Point(109, 133);
            this.txtresim.Name = "txtresim";
            this.txtresim.ReadOnly = true;
            this.txtresim.Size = new System.Drawing.Size(123, 26);
            this.txtresim.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Resim";
            // 
            // pctResim
            // 
            this.pctResim.Location = new System.Drawing.Point(340, 53);
            this.pctResim.Name = "pctResim";
            this.pctResim.Size = new System.Drawing.Size(249, 248);
            this.pctResim.TabIndex = 3;
            this.pctResim.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(238, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Control";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtMaas
            // 
            this.txtMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaas.Location = new System.Drawing.Point(111, 166);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(123, 26);
            this.txtMaas.TabIndex = 2;
            this.txtMaas.TextChanged += new System.EventHandler(this.txtMaas_TextChanged);
            this.txtMaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaas_KeyPress);
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaas.Location = new System.Drawing.Point(5, 170);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(44, 19);
            this.lblMaas.TabIndex = 2;
            this.lblMaas.Text = "Maas";
            // 
            // lblDepartman
            // 
            this.lblDepartman.AutoSize = true;
            this.lblDepartman.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartman.Location = new System.Drawing.Point(3, 222);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(84, 19);
            this.lblDepartman.TabIndex = 2;
            this.lblDepartman.Text = "Departman";
            // 
            // lblPozisyon
            // 
            this.lblPozisyon.AutoSize = true;
            this.lblPozisyon.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPozisyon.Location = new System.Drawing.Point(12, 262);
            this.lblPozisyon.Name = "lblPozisyon";
            this.lblPozisyon.Size = new System.Drawing.Size(68, 19);
            this.lblPozisyon.TabIndex = 2;
            this.lblPozisyon.Text = "Pozisyon";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(109, 223);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(121, 27);
            this.cmbDepartman.TabIndex = 4;
            // 
            // cmbPozisyon
            // 
            this.cmbPozisyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPozisyon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPozisyon.FormattingEnabled = true;
            this.cmbPozisyon.Location = new System.Drawing.Point(109, 259);
            this.cmbPozisyon.Name = "cmbPozisyon";
            this.cmbPozisyon.Size = new System.Drawing.Size(121, 27);
            this.cmbPozisyon.TabIndex = 4;
            // 
            // dogum
            // 
            this.dogum.AutoSize = true;
            this.dogum.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogum.Location = new System.Drawing.Point(12, 304);
            this.dogum.Name = "dogum";
            this.dogum.Size = new System.Drawing.Size(104, 19);
            this.dogum.TabIndex = 2;
            this.dogum.Text = "Doğum Tarihi";
            // 
            // DogumGunu
            // 
            this.DogumGunu.Location = new System.Drawing.Point(122, 304);
            this.DogumGunu.Name = "DogumGunu";
            this.DogumGunu.Size = new System.Drawing.Size(200, 20);
            this.DogumGunu.TabIndex = 5;
            // 
            // adres
            // 
            this.adres.AutoSize = true;
            this.adres.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adres.Location = new System.Drawing.Point(12, 353);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(53, 19);
            this.adres.TabIndex = 6;
            this.adres.Text = "Adress";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(118, 349);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(386, 149);
            this.textBox1.TabIndex = 7;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKaydet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(189, 520);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(95, 34);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(303, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Kapat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmPersonelBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(615, 591);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DogumGunu);
            this.Controls.Add(this.cmbPozisyon);
            this.Controls.Add(this.cmbDepartman);
            this.Controls.Add(this.pctResim);
            this.Controls.Add(this.dogum);
            this.Controls.Add(this.lblPozisyon);
            this.Controls.Add(this.lblDepartman);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtresim);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtad);
            this.Name = "FrmPersonelBilgileri";
            this.Text = "PersonelBilgileri";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncontrol;
        private System.Windows.Forms.Label lblkullanıcı;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.CheckBox chckAdmin;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtresim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pctResim;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.Label lblPozisyon;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.ComboBox cmbPozisyon;
        private System.Windows.Forms.Label dogum;
        private System.Windows.Forms.DateTimePicker DogumGunu;
        private System.Windows.Forms.Label adres;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtkullanıcı;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button button2;
    }
}