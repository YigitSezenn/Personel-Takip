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
    public partial class frmPersonelListesi : Form
    {
        public frmPersonelListesi()
        {
            InitializeComponent();
        }

        private void txtUserNo_TextChanged(object sender, EventArgs e)
        {

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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmPersonelBilgileri frm = new FrmPersonelBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            FrmPersonelBilgileri frm = new FrmPersonelBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
