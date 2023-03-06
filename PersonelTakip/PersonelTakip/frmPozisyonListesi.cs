using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DataAccesObject;
using DAL.DataTransfer;


namespace PersonelTakip
{
    public partial class frmPozisyonListesi : Form
    {
        public frmPozisyonListesi()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmPozisyonBilgileri frm = new frmPozisyonBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            liste = Pozisyonbll.PozisyonGetir();
            dataGridView1.DataSource = liste;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            frmPozisyonBilgileri frm = new frmPozisyonBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
        List<PozisyonDto> liste = new List<PozisyonDto>();

        private void frmPozisyonListesi_Load(object sender, EventArgs e)
        {
            liste = Pozisyonbll.PozisyonGetir();
            dataGridView1.DataSource = liste;
            dataGridView1.Columns[0].HeaderText = "Departman Adı";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[3].HeaderText = "PozisyonAd";
        }
    }
}
