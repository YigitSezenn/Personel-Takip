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
    public partial class FrmİşListesi : Form
    {
        public FrmİşListesi()
        {
            InitializeComponent();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmİşListesi_Load(object sender, EventArgs e)
        {
           
        }

        private void lblİs_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblİşDurum_Click(object sender, EventArgs e)
        {

        }

        private void lblBitis_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void temizle_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmİşBilgileri frm = new FrmİşBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            FrmİşBilgileri frm = new FrmİşBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
