using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace PersonelTakip
{
    public partial class frmPozisyonBilgileri : Form
    {
        public frmPozisyonBilgileri()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtPozisyonAd.Text.Trim() == "")
                MessageBox.Show("Pozisyon Giriniz");
            else if (cmbdepartman.SelectedIndex == -1)
                MessageBox.Show("Departman Seçiniz");
            else
            {
                Position pz = new Position();
                pz.PositionName = txtPozisyonAd.Text;
                pz.DepartmanID = Convert.ToInt32(cmbdepartman.SelectedValue);
                Pozisyonbll.PozisyonEkle(pz);
                MessageBox.Show("Pozisyon Eklendi");
                txtPozisyonAd.Clear();
                cmbdepartman.SelectedIndex = -1;
            }
        }
        
        List<Departman> departman = new List<Departman>();
        private void frmPozisyonBilgileri_Load(object sender, EventArgs e)
        {
            departman = DAL.DataAccesObject.DepartmanDao.departmanGetir();
            cmbdepartman.DataSource = departman;
            cmbdepartman.DisplayMember = "DepartmanName";
            cmbdepartman.ValueMember = "ID";
            cmbdepartman.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
