using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            frmgirisPanel frm =new frmgirisPanel();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnpersonel_Click(object sender, EventArgs e)
        {
            frmPersonelListesi frm = new frmPersonelListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

        }

        private void Btnİsler_Click(object sender, EventArgs e)
        {
            FrmİşListesi frm = new FrmİşListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnMaas_Click(object sender, EventArgs e)
        {
            FrmMaasListesi frm =new FrmMaasListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnİzinİşlemleri_Click(object sender, EventArgs e)
        {
            frmİzinListesi frm = new frmİzinListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnDepartman_Click(object sender, EventArgs e)
        {
            FrmDepartmanListesi frm =new FrmDepartmanListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnPozisyon_Click(object sender, EventArgs e)
        {
            frmPozisyonListesi frm = new frmPozisyonListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
