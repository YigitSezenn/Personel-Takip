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
    public partial class FrmDepartmanListesi : Form
    {
        public FrmDepartmanListesi()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmDepartmanBilgileri frm = new FrmDepartmanBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDepartmanListesi_Load(object sender, EventArgs e)
        {
            List<Departman> liste = new List<Departman> ();
            liste = DepartmanBLL.DepartmanGetir();
            dataGridView1.DataSource = liste;
            dataGridView1.Columns[0].Visible=false;
            dataGridView1.Columns[1].HeaderText = "Departman Adı";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
